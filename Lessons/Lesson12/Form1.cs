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

namespace Lesson12
{
    public partial class FrmMain : Form
    {
        CellularAutomata CA_current;
        Graphics g;
        int _scale = 10;

        (int X, int Y) _cursorPos = (-1, -1);

        public FrmMain()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(100* _scale, 100* _scale);
            PbxVis.Image = bmp;
            g = Graphics.FromImage(PbxVis.Image);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {            
            
            for (int i = 0; i < 20; i++)
            {
                CA_current.TransitionRule();
                Visualization();
                Thread.Sleep(2000);
            }
        }

        void Visualization()
        {
            var field = CA_current.GetField();
            SolidBrush p = new SolidBrush(Color.White);
            for (int x = 0; x < field.GetLength(0); x++)
                for (int y = 0; y < field.GetLength(0); y++)
                {
                    if (field[x, y].State == 0)
                    {
                        p.Color = Color.White;                        
                    }
                    if (field[x, y].State == 1)
                    {
                        p.Color = Color.Red;
                    }
                    g.FillRectangle(p, x * _scale, y * _scale, _scale, _scale);
                }
            PbxVis.Refresh();
        }

        void CursorVis()
        {
            if (_cursorPos.X!=-1&& _cursorPos.Y!=-1)
            {
                SolidBrush p = new SolidBrush(Color.Black);
                g.FillRectangle(p, _cursorPos.X, _cursorPos.Y, _scale, _scale);
            }
            PbxVis.Refresh();
        }
        void ClearCursor ()
        {
            if (_cursorPos.X != -1 && _cursorPos.Y != -1)
            {
                SolidBrush p = new SolidBrush(Color.White);
                g.FillRectangle(p, _cursorPos.X, _cursorPos.Y, _scale, _scale);
            }
            PbxVis.Refresh();
        }
        private void BtnInit_Click(object sender, EventArgs e)
        {
            CA_current = new GoL(50, 50);
            //CA_current.InitGen();
            Visualization();
        }

        private void CursorMove (object sender, MouseEventArgs e)
        {
            ClearCursor();
            _cursorPos.X = e.Location.X;
            _cursorPos.Y = e.Location.Y;
            CursorVis();
        }

        private void CursorClick(object sender, MouseEventArgs e)
        {           
            int x= e.Location.X/_scale;
            int y = e.Location.Y/_scale;
            listBox1.Items.Add(_cursorPos.X + ";" + _cursorPos.Y);
            if (CA_current!=null)
            {
                CA_current.GetField()[x, y].SetState(1);
                Visualization();
                PbxVis.Refresh();
            }            
        }
    }
}
