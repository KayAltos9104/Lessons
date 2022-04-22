using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15_2
{
    public partial class FrmMain : Form, IView
    {
        float _x;
        float _y;
        float _radius;
        Presenter p;
        public FrmMain()
        {
            InitializeComponent();
            p = new Presenter(new Circle(), this);
        }

        public event EventHandler Initialized = delegate { };
        public event EventHandler<DirectionEventArgs> DirectionChanged=delegate { };

        public void Render(float X, float Y, float Radius)
        {
            _x = X; 
            _y = Y; 
            _radius = Radius;
            PbxField.Refresh();
        }

        private void PaintMap(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Black, 1.5f);
            g.FillEllipse(b,_x-_radius, _y-_radius, 2*_radius, 2*_radius);
            g.DrawEllipse(p, _x - _radius, _y - _radius, 2 * _radius, 2 * _radius);
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            Initialized.Invoke(this, EventArgs.Empty);
        }
    }
}
