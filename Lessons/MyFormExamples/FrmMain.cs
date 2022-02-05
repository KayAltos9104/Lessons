using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson_11._1;

namespace MyFormExamples
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random();
        public FrmMain()
        {
            InitializeComponent();
            TbxResult.Enabled = false;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            double mod = double.Parse(TbxInputModule.Text);
            double angle = double.Parse(TbxInputAngle.Text);
            Vector vel = new Vector(angle, mod);
            double result = Math.Round(Calculating.Calculate(vel), 3);
            TbxResult.Text = result.ToString();
            int scale = 100;
            if (PbxThrowing.Image != null)
                PbxThrowing.Image.Dispose();

            Bitmap bmp = new Bitmap(50 * scale, 5*scale);

            PbxThrowing.Image = bmp;

            Graphics g = Graphics.FromImage(PbxThrowing.Image);

            SolidBrush p = new SolidBrush(Color.White);
            for (int i = 0; i <= result+1; i++)
            {
                if(i>result)
                {
                    p = new SolidBrush(Color.Red);                    
                }
                g.FillRectangle(p, i * scale, 0, scale, scale);
                //p = new SolidBrush(Color.White);
            }
            PbxThrowing.Refresh();
        }
        private void CustomClick(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            current.Location = new Point(rnd.Next(0, this.ClientSize.Width), rnd.Next(0, this.ClientSize.Height));
        }

        private void TbxInput_TextChanged(object sender, EventArgs e)
        {
            TextBox tbxCur = (TextBox)sender;            
            while (!double.TryParse(tbxCur.Text, out double result))
            {
                if (tbxCur.Text.Length != 0)
                    tbxCur.Text = tbxCur.Text.Substring(0, tbxCur.Text.Length - 1);
                else
                    tbxCur.Text = "0";
            }
        }
    }
}
