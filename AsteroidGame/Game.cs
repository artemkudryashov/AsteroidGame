using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsteroidGame.VisualObjects;

namespace AsteroidGame
{



    static class Game
    {
        private const int __FrameTimeout = 10;

        private static BufferedGraphicsContext __Context;
        private static BufferedGraphics __Buffer;
        private static VisualObject[] __GameObjects;

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static void Initialize(Form form)
        {
            __Context = BufferedGraphicsManager.Current;
            Graphics g = form.CreateGraphics();

            Width = form.Width;
            Height = form.Height;


            __Buffer = __Context.Allocate(g, new Rectangle(0, 0, Width, Height));


            var timer = new Timer { Interval = __FrameTimeout };
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private static void OnTimerTick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        public static void Load()
        {
            var game_objects = new List<VisualObject>();
            var rnd = new Random();
            const int stars_count = 150;
            const int star_size = 5;
            const int star_max_speed = 20;
            for (int i = 0; i < stars_count; i++)
            {
                game_objects.Add(new Star(
                    new Point(rnd.Next(0,Width), rnd.Next(0,Height)),
                    new Point(rnd.Next(0, star_max_speed), 0),
                    star_size));
            }

            const int ellipses_count = 20;
            const int ellipses_size_x = 20;
            const int ellipses_size_y = 30;

            for (int i = 0; i < ellipses_count; i++)
            {
                game_objects.Add(new EllipseObject(
                    new Point(600, i * 20),
                    new Point(15 - i, 20 - i),
                    new Size(ellipses_size_x, ellipses_size_y)));
            }

            const int asteroids_count = 10;
            const int asteroids_size = 25;
            const int asteroids_max_speed = 20;
            for (int i = 0; i < asteroids_count; i++)
            {
                game_objects.Add(new Asteroid(
                    new Point(rnd.Next(0, Width), rnd.Next(0, Height)),
                    new Point(rnd.Next(0, asteroids_max_speed), 0),
                    asteroids_size));
            }


            //__GameObjects = new VisualObject[30];
            //for (int i = 0; i < __GameObjects.Length /2 ; i++)
            //{
            //    __GameObjects[i] = new VisualObject(
            //        new Point(600,i*20),
            //        new Point(15-i,20-i),
            //        new Size(20,20));
            //}

            //for (int i = __GameObjects.Length / 2; i < __GameObjects.Length ; i++)
            //{
            //    __GameObjects[i] = new Star(
            //        new Point(600,i*20),
            //        new Point(-i,0),
            //        20);
            //}
            //var image = Properties.Resources.Asteroid;
            //var image_object = new ImageObject(new Point(4,7), new Point(-4,6), new Size(20,20), image);
            __GameObjects = game_objects.ToArray();
        }

        public static void Draw()
        {
            var g = __Buffer.Graphics;
            g.Clear(Color.Black);

            //g.DrawRectangle(Pens.White, new Rectangle(50, 50, 200, 200));
            //g.FillEllipse(Brushes.Red, new Rectangle(100, 50, 70, 120));

            foreach (var item in __GameObjects)
            {
                item.Draw(g);
                __Buffer.Render();
            }

            __Buffer.Render();
        }

        public static void Update()
        {
            foreach (var item in __GameObjects)
            {
                item.Update();
            }
        }

    }
}
