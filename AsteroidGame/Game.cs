using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AsteroidGame
{



    static class Game
    {
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


            var timer = new Timer { Interval = 100 };
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
            __GameObjects = new VisualObject[30];
            for (int i = 0; i < __GameObjects.Length; i++)
            {
                __GameObjects[i] = new VisualObject(
                    new Point(600,i*20),
                    new Point(15-i,20-i),
                    new Size(20,20));
            }
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
