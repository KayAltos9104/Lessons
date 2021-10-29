using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson6;

namespace Lesson6_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Soldier Shepard = new Soldier();
            KroganMerc Wrex = new KroganMerc();
            string log;

            for (int i = 0; i < 100; i++)
            {
                log = "";
                Shepard.Update(Wrex, out log);
                listBox1.Items.Add(log);
                //Console.WriteLine(log);
                Wrex.Update(Shepard, out log);
                listBox1.Items.Add(log);
                //Console.WriteLine(log);
                //Console.ReadKey();
            }
        }
    }
}
