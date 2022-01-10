using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Emitter
    {
        public List<Particle> particles = new List<Particle>();
        public List<ImpactPoint> impactPoints = new List<ImpactPoint>();

        public float GravitationX = 0;
        public float GravitationY = 1;

        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы
        public int ParticlesPerTick = 5;
        public static Random rand = new Random();

        public int ParticlesCount = 500;

        public bool check;

        public Color color1 = Color.White;
        public Color color2 = Color.White;
        public Color color3 = Color.White;

        public Color[] colorsList = { Color.White, Color.Blue, Color.White, Color.White };
       

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;

            foreach (var particle in particles.ToList())
            {

                if (particle.Life <= 0)
                {
                    if (particlesToCreate > 0)
                    {
                        /* у нас как сброс частицы равносилен созданию частицы */
                        particlesToCreate -= 1; // поэтому уменьшаем счётчик созданных частиц на 1
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                    foreach (var point in impactPoints.ToList())
                    {
                        point.ImpactParticle(particle);
                    }
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        // добавил новый метод, виртуальным, чтобы переопределять можно было
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);
            particle.X = X;
            particle.Y = Y;

            var direction = Direction
        + (double)Particle.rand.Next(Spreading)
        - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }

        public virtual Particle CreateParticle()
        {
            colorsList[1] = color1;
            colorsList[2] = color2;
            colorsList[3] = color3;
            int c = rand.Next(4);

            var particle = new Particle();
            particle.particleColor = colorsList[c];

            return particle;
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }

        
    }

    public class TopEmitter : Emitter
    {
        public int Width; // длина экрана

        public override void ResetParticle(Particle particle)
        {

            base.ResetParticle(particle); // вызываем базовый сброс частицы, там жизнь переопределяется и все такое

            // а теперь тут уже подкручиваем параметры движения
            particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
            particle.Y = 0;  // ноль -- это верх экрана 

            particle.SpeedY = 1; // падаем вниз по умолчанию
            particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
        }
    }

    public class FishEmitter : Emitter
    {
        public Color color;

        public override Particle CreateParticle()
        {
            var particle = new Particle();
            particle.particleColor = color;

            return particle;
        }
    }
}