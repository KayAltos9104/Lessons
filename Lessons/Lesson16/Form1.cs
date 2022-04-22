using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson16
{
    public partial class Form1 : Form, IView
    {
        float x = 0;
        float y = 0;
        Random rnd = new Random();
        List<Bullet> _bullets = new List<Bullet>();
        List<Character> _enemies = new List<Character>();

        bool initialized = false;

        public event EventHandler<CharacterEventArgs> CharacterUpdated = delegate { };
        public event EventHandler OnUpdateModel = delegate { };
        public event EventHandler<ShootEventArgs> Shooted = delegate { };

        public Form1()
        {
            InitializeComponent();
            tmrFPS.Start();
        }

        private void Draw (object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Black, 1.0f);
            g.Clear(Color.White);           
            if (initialized)
            {
                g.FillRectangle(b, x, y, 30, 30);
                g.DrawRectangle(p, x, y, 30, 30);
               
                foreach (var enemy in _enemies)
                {
                    b.Color = Color.Blue;
                    g.FillEllipse(b, enemy.Pos.X, enemy.Pos.Y, 30, 30);
                    g.DrawEllipse(p, enemy.Pos.X, enemy.Pos.Y, 30, 30);
                }
                foreach (var bullet in _bullets)
                {
                    b.Color = Color.Black;
                    g.FillEllipse(b, bullet.Pos.X, bullet.Pos.Y, 10, 10);                    
                }
            }
        }

        private void Form_Click(object sender, MouseEventArgs e)
        {
            initialized = true;

            x = e.X;
            y = e.Y;
            if (e.Button == MouseButtons.Left)
                CharacterUpdated.Invoke(this, new CharacterEventArgs() { Position = (x, y) });
            else if (e.Button == MouseButtons.Right)
                Shooted.Invoke(this, new ShootEventArgs() { Position = (x, y) });
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }      

        public void Draw((float x, float y) pos, List<Bullet> bullets, List<Character> enemies)
        {
            x = pos.x;
            y = pos.y;
            _bullets = bullets;
            _enemies = enemies;
            this.Refresh();
        }

        private void tmrFPS_Tick(object sender, EventArgs e)
        {
            OnUpdateModel.Invoke(this, new EventArgs());
        }
    }
}
