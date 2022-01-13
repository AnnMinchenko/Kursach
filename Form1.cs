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
        PinkFish pFish = new PinkFish(); // розовая рыба
        BlueFish bFish = new BlueFish(); // синяя рыба
        YellowFish yFish = new YellowFish(); // желтая рыба
        int yfull = 200, pfull = 50, bfull = 100; // максимальное число поглощенных частиц

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

            pemitter = new FishEmitter // эмиттер - фонтан розовой рыбы
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

            bemitter = new FishEmitter // эмиттер - фонтан синей рыбы
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

            yemitter = new FishEmitter // эмиттер - фонтан желтой рыбы
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
            // тут теперь обновляем эмиттер
            emitter.UpdateState(); 
            pemitter.UpdateState();
            bemitter.UpdateState();
            yemitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.FromArgb(0, 0, 0, 0));

                // а тут теперь рендерим через эмиттер
                emitter.Render(g); 
                pemitter.Render(g);
                bemitter.Render(g);
                yemitter.Render(g);
            }


            picDisplay.Invalidate();

            // проверка количества поглощенных частиц розовой рыбой
            if (pFish.Fullness % pfull == 0 || pFish.Fullness % (pfull + 1) == 0 || pFish.Fullness % (pfull + 2) == 0)
            {
                pemitter.ParticlesPerTick = 80; // испускание фонтанчика
                pFish.Fullness = 1; // обнуление счетчика
            }
            else
                pemitter.ParticlesPerTick = 0;

            // проверка количества поглощенных частиц синей рыбой
            if (bFish.Fullness % bfull == 0 || bFish.Fullness % (bfull + 1) == 0 || bFish.Fullness % (bfull + 2) == 0)
            {
                bemitter.ParticlesPerTick = 80;
                bFish.Fullness = 1;
            }
            else
                bemitter.ParticlesPerTick = 0;

            // проверка количества поглощенных частиц желтой рыбой
            if (yFish.Fullness % yfull == 0 || yFish.Fullness % (yfull + 1) == 0 || yFish.Fullness % (yfull + 2) == 0)
            {
                yemitter.ParticlesPerTick = 80;
                yFish.Fullness = 1;
            }
            else
                yemitter.ParticlesPerTick = 0;
        }

        // изменение максимального числа поглощенных частиц розовой рыбы
        private void tb_pfish_Scroll(object sender, EventArgs e)
        {
            pfull = tb_pfish.Value;
            lbl_pfish.Text = $"Максимальная сытость: {tb_pfish.Value}";
        }

        // изменение максимального числа поглощенных частиц синей рыбы
        private void tb_bfish_Scroll(object sender, EventArgs e)
        {
            bfull = tb_bfish.Value;
            lbl_bfish.Text = $"Максимальная сытость: {tb_bfish.Value}";
        }

        // изменение максимального числа поглощенных частиц желтой рыбы
        private void tb_yfish_Scroll(object sender, EventArgs e)
        {
            yfull = tb_yfish.Value;
            lbl_yfish.Text = $"Максимальная сытость: {tb_yfish.Value}";
        }

        // изменение силы притяжения розовой рыбы
        private void tb_pgravity_Scroll(object sender, EventArgs e)
        {
            pFish.Power = tb_pgravity.Value;
        }

        // изменение силы притяжения синей рыбы
        private void tb_bgravity_Scroll(object sender, EventArgs e)
        {
            bFish.Power = tb_bgravity.Value;
        }

        // изменение силы притяжения желтой рыбы
        private void tb_ygravity_Scroll(object sender, EventArgs e)
        {
            yFish.Power = tb_ygravity.Value;
        }

        // изменение количества падающих сверху частиц
        private void tb_ParticlesCount_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tb_ParticlesCount.Value;
        }

        // включение/отключение генерации розовых частиц
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

        // включение/отключение генерации синих частиц
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

        // включение/отключение генерации желтых частиц
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