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
                g.Clear(Color.White);
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
    }
}