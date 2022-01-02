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
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        Brush brush = new TextureBrush(Properties.Resources.fon);

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new TopEmitter
            {
                SpeedMin = 10,
                SpeedMax = 10,
                ParticlesPerTick = 0,
                Width = picDisplay.Width,
                GravitationY = 0.25f
            };

            emitters.Add(this.emitter);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.FromArgb(0, 0, 0, 0));
                //g.FillRectangle(brush, 0, 0, picDisplay.Width, picDisplay.Height);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();
        }


        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.X = e.X;
            emitter.Y = e.Y;
        }

        private void tb_ParticlesCount_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tb_ParticlesCount.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked)
           {
                emitter.color1 = Color.DeepPink;
           }
           else
           {
                emitter.color1 = Color.Black;
           }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                emitter.color2 = Color.Bisque;
            }
            else
            {
                emitter.color2 = Color.Black;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                emitter.color3 = Color.Gold;
            }
            else
            {
                emitter.color3 = Color.Black;
            }
        }
    }
}