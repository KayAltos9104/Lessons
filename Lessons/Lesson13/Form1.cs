using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson13
{
    public partial class Form1 : Form
    {
        List<Rocket> rList = new List<Rocket>();
        AA_Rocket a;
        Graphics g;
        int scale = 5;
        public Form1()
        {
            InitializeComponent();
            
            Bitmap bmp = new Bitmap(515, 515);
            PbxField.Image = bmp;
            g = Graphics.FromImage(PbxField.Image);
            SolidBrush p = new SolidBrush(Color.White);
            g.FillRectangle(p, 0, 0, 520, 520);
            Rocket rocket = new Rocket(0, 50, 1.0, -1.0);
            rList.Add(rocket);
            AA_Rocket aa = new AA_Rocket(50, 100, -1, -3, 10);
            a = aa;            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {   
            while (true)
            {
                SolidBrush p = new SolidBrush(Color.White);
                g.FillRectangle(p, 0, 0, 520, 520);
                p.Color = Color.Black;
                g.FillEllipse(p, (Single)(a.X * scale - 5), (Single)(a.Y * scale - 5), 10, 10);
                //g.DrawEllipse(new Pen(Color.Black), (Single)(a.X*scale-5),(Single)(a.Y*scale-5), 10, 10);
                g.DrawEllipse(new Pen(Color.Blue), (Single)(a.X - a._detectRad) * scale, (Single)(a.Y - a._detectRad) * scale,
                    (Single)(a._detectRad * 2 * scale), (Single)(a._detectRad * 2 * scale));
                p.Color = Color.Red;
                foreach (var r in rList)
                {
                    //g.DrawEllipse(new Pen(Color.Red), (Single)(r.X * scale-5), (Single)(r.Y * scale-5), 10, 10);
                    g.FillEllipse(p, (Single)(r.X * scale - 5), (Single)(r.Y * scale - 5), 10, 10);
                }
                a.DetectEnemy(rList);
                a.Move();
                foreach (var r in rList)
                {
                    r.Move();
                }
                PbxField.Refresh();
                Thread.Sleep(100);
            }
            
        }
    }
}
