using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            for (var i = 0; i < 500; ++i)
            {
                var particle = new Particle();
                
                particle.X = picDisplay.Image.Width / 2;
                particle.Y = picDisplay.Image.Height / 2;
                
                particles.Add(particle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                foreach (var particle in particles)
                {
                    particle.Draw(g);
                }
            }

            picDisplay.Invalidate();
        }
    }
}
