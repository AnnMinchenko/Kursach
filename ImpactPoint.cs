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
     * Класс Рыба - притягивает и поглощает частицы определенного цвета
    */
    public class Fish : ImpactPoint
    {
        public int Radius; // радиус частицы
        public int X; // X координата положения частицы в пространстве
        public int Y; // Y координата положения частицы в пространстве
        public int Fullness = 0; // количество поглощенных частиц
        public int Power = 0; // сила притяжения
        public Color FishColor; // цвет рыбы
        public TextureBrush fishBrush; // для отрисовки рыбы

        public Fish()
        {
            Radius = 120;
            Fullness = 1;
        }

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            // поглощение частиц
            if (r + particle.Radius < 50 && particle.particleColor == FishColor)
            {
                particle.Life = 0;
                Fullness++;
            }

            // притяжение частиц
            if (particle.particleColor == FishColor)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }

        }


        public override void Render(Graphics g)
        {
            if (FishColor == Color.DeepPink)
            {
                fishBrush = new TextureBrush(Properties.Resources.fish1, System.Drawing.Drawing2D.WrapMode.Clamp);
                g.FillEllipse(
                        fishBrush,
                        X - Radius / 2,
                        Y - Radius / 2 + 50,
                        Radius,
                        Radius
                    );
            }

            if (FishColor == Color.Navy)
            {
                fishBrush = new TextureBrush(Properties.Resources.fish2, System.Drawing.Drawing2D.WrapMode.Clamp);
                g.FillEllipse(
                        fishBrush,
                        X - Radius / 2,
                        Y - Radius / 2 + 50,
                        Radius,
                        Radius
                    );
            }

            if (FishColor == Color.Gold)
            {
                fishBrush = new TextureBrush(Properties.Resources.fish3, System.Drawing.Drawing2D.WrapMode.Clamp);
                g.FillEllipse(
                        fishBrush,
                        X - Radius / 2,
                        Y - Radius / 2 + 50,
                        Radius,
                        Radius
                    );
            }

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
