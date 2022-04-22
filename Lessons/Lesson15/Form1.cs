using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15
{
    public partial class FrmMain : Form
    {       
        delegate int OutputParams(int a, int b);
        delegate void del1();
        Random rnd = new Random();
        int t = 0;

        List<int[]> arrays = new List<int[]>();
        public FrmMain()
        {
            InitializeComponent();
        }
       


        private void BtnStart_Click(object sender, EventArgs e)
        {
            OutputParams p;
            //Анонимные
            p = delegate (int s1, int s2)
            {
                return s1 + s2;
            };

            p += delegate (int s1, int s2)
            {
                return s2 - s1;
            };

            int d = p.Invoke(2, 3);
            //MessageBox.Show(d.ToString());
            del1 t = () => MessageBox.Show("Привет!");
            del1 t2 = () =>
            {
                MessageBox.Show("Пока!");
                MessageBox.Show("Я уже попрощался");
            };

            OutputParams p2 = (int x, int y) =>  x + y;

            OutputParams p3 = (int f, int g) =>
            {
                var u = f * g;
                return u;
            };
            t2.Invoke();
        }
        //void, Task, Task<>

        private async void BtnAsyncDemo_ClickAsync(object sender, EventArgs e)
        {
            //MultipleArray();
            //var r = await SquareAsync(10);
            //MessageBox.Show(SquareAsync(10).ToString());
            var t = await SumArray();
            MessageBox.Show(t.ToString());
        }

        public async Task MultipleArray()
        {   
            var sync = new object();
            int[] array = new int[100000];
            await Task.Run(() =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 5001);
                }

                lock (sync)
                {
                    arrays.Add(array);
                }
            }
            );
            
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] *= 2;
            //}                     
        }
        async Task<int> SumArray()
        {
            int[] array = new int[1000000];

            await Task.Run(() =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 5001);
                }
            }
            );
            return array[0];
        }
        async Task<int> SquareAsync(int n)
        {
            await Task.Delay(1000);
            return n * n;
        }
    }    
}
