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
        Emitter emitter, pemitter, bemitter, yemitter;
        PinkFish pFish = new PinkFish();
        BlueFish bFish = new BlueFish();
        YellowFish yFish = new YellowFish();

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

            pemitter = new FishEmitter
            {
                color = Color.DeepPink,
                Direction = 90,
                Spreading = 25,
                SpeedMin = 10,
                SpeedMax = 20,
                ParticlesPerTick = 0,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            bemitter = new FishEmitter
            {
                color = Color.Navy,
                Direction = 90,
                Spreading = 25,
                SpeedMin = 10,
                SpeedMax = 20,
                ParticlesPerTick = 0,
                X = picDisplay.Width * 3 / 4,
                Y = picDisplay.Height / 2,
            };

            yemitter = new FishEmitter
            {
                color = Color.Gold,
                Direction = 90,
                Spreading = 25,
                SpeedMin = 10,
                SpeedMax = 20,
                ParticlesPerTick = 0,
                X = picDisplay.Width / 4,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);
            emitters.Add(this.pemitter);
            emitters.Add(this.bemitter);
            emitters.Add(this.yemitter);


            pFish = new PinkFish();

            pFish.X = picDisplay.Width / 2;
            pFish.Y = picDisplay.Height / 2;
            emitter.impactPoints.Add(pFish);

            bFish = new BlueFish();

            bFish.X = picDisplay.Width * 3 / 4;
            bFish.Y = picDisplay.Height / 2;
            emitter.impactPoints.Add(bFish);

            yFish = new YellowFish();

            yFish.X = picDisplay.Width / 4;
            yFish.Y = picDisplay.Height / 2;
            emitter.impactPoints.Add(yFish);
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер
            pemitter.UpdateState();
            bemitter.UpdateState();
            yemitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.FromArgb(0, 0, 0, 0));
                emitter.Render(g); // а тут теперь рендерим через эмиттер
                pemitter.Render(g);
                bemitter.Render(g);
                yemitter.Render(g);
            }


            picDisplay.Invalidate();

            if (pFish.Fullness % 100 == 0 || pFish.Fullness % 101 == 0 || pFish.Fullness % 102 == 0)
            {
                pemitter.ParticlesPerTick = 80;
                pFish.Fullness = 1;
            }
            else
                pemitter.ParticlesPerTick = 0;

            if (bFish.Fullness % 100 == 0 || bFish.Fullness % 101 == 0 || bFish.Fullness % 102 == 0)
            {
                bemitter.ParticlesPerTick = 80;
                bFish.Fullness = 1;
            }
            else
                bemitter.ParticlesPerTick = 0;

            if (yFish.Fullness % 100 == 0 || yFish.Fullness % 101 == 0 || yFish.Fullness % 102 == 0)
            {
                yemitter.ParticlesPerTick = 80;
                yFish.Fullness = 1;
            }
            else
                yemitter.ParticlesPerTick = 0;
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
                emitter.color1 = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                emitter.color2 = Color.Navy;
            }
            else
            {
                emitter.color2 = Color.White;
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
                emitter.color3 = Color.White;
            }
        }
    }
}