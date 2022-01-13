using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public abstract class ImpactPoint
    {
        public int X; // ну точка же, вот и две координаты
        public int Y;
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    /*
     * Класс Розовая рыба - притягивает и поглощает розовые частицы
    */
    public class PinkFish : ImpactPoint
    {
        public int Radius; // радиус частицы
        public int X; // X координата положения частицы в пространстве
        public int Y; // Y координата положения частицы в пространстве
        public int Fullness = 0; // количество поглощенных частиц
        public int Power = 0; // сила притяжения

        public PinkFish()
        {
            Radius = 120;
            Fullness = 0;
        }

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            // поглощение розовых частиц
            if (r + particle.Radius < 50 && particle.particleColor == Color.DeepPink)
            {
                particle.Life = 0;
                Fullness++;
            }

            // притяжение розовых частиц
            if (particle.particleColor == Color.DeepPink)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }

        }

        TextureBrush pinkFish = new TextureBrush(Properties.Resources.fish1, System.Drawing.Drawing2D.WrapMode.Clamp);
        public override void Render(Graphics g)
        {
            g.FillEllipse(
                    pinkFish,
                    X - Radius / 2,
                    Y - Radius / 2 + 50,
                    Radius,
                    Radius
                );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали
            var text = $"Съедено: {Fullness}";
            var font = new Font("Verdana", 10);
            g.DrawString(
                    text,
                    font,
                    new SolidBrush(Color.Black),
                    X,
                    Y + 120,
                    stringFormat
                );
        }
    }

    /*
     * Класс Синяя рыба - притягивает и поглощает синие частицы 
    */
    public class BlueFish : ImpactPoint
    {
        public int Radius; // радиус частицы
        public int X; // X координата положения частицы в пространстве
        public int Y; // Y координата положения частицы в пространстве
        public int Fullness = 0; // количество поглощенных частиц
        public int Power = 0; // сила притяжения

        public BlueFish()
        {
            Radius = 120;
            Fullness = 0;
        }
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            // поглощение синих частиц
            if (r + particle.Radius < 50 && particle.particleColor == Color.Navy)
            {
                particle.Life = 0;
                Fullness++;
            }

            // притяжение синих частиц
            if (particle.particleColor == Color.Navy)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        TextureBrush blueFish = new TextureBrush(Properties.Resources.fish2, System.Drawing.Drawing2D.WrapMode.Clamp);
        public override void Render(Graphics g)
        {
            g.FillEllipse(
                    blueFish,
                    X - Radius / 2,
                    Y - Radius / 2 + 50,
                    Radius,
                    Radius
                );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали
            var text = $"Съедено: {Fullness}";
            var font = new Font("Verdana", 10);
            g.DrawString(
                    text,
                    font,
                    new SolidBrush(Color.Black),
                    X,
                    Y + 120,
                    stringFormat
                );
        }
    }

    /*
     * Класс Желтая рыба - притягивает и поглощает желтые частицы 
    */
    public class YellowFish : ImpactPoint
    {
        public int Radius; // радиус частицы
        public int X; // X координата положения частицы в пространстве
        public int Y; // Y координата положения частицы в пространстве
        public int Fullness = 0; // количество поглощенных частиц
        public int Power = 0; // сила притяжения

        public YellowFish()
        {
            Radius = 120;
            Fullness = 0;
        }
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            // поглощение желтых частиц
            if (r + particle.Radius < 50 && particle.particleColor == Color.Gold)
            {
                particle.Life = 0;
                Fullness++;
            }

            // притяжение желтых частиц
            if (particle.particleColor == Color.Gold)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        TextureBrush yellowFish = new TextureBrush(Properties.Resources.fish3, System.Drawing.Drawing2D.WrapMode.Clamp);
        public override void Render(Graphics g)
        {
            g.FillEllipse(
                    yellowFish,
                    X - Radius / 2,
                    Y - Radius / 2 + 45,
                    Radius,
                    Radius
               );

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали
            var text = $"Съедено: {Fullness}";
            var font = new Font("Verdana", 10);
            g.DrawString(
                    text,
                    font,
                    new SolidBrush(Color.Black),
                    X,
                    Y + 120,
                    stringFormat
                );
        }

    }

}
