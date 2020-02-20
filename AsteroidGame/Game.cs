﻿using System;
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

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static void Initialize(Form form)
        {
            __Context = BufferedGraphicsManager.Current;
            Graphics g = form.CreateGraphics();

            Width = form.Width;
            Height = form.Height;


            __Buffer = __Context.Allocate(g, new Rectangle(0, 0, Width, Height));
        }

        public static void Draw()
        {
            var g = __Buffer.Graphics;
            g.Clear(Color.Black);

            g.DrawRectangle(Pens.White, new Rectangle(50, 50, 200, 200));
            g.FillEllipse(Brushes.Red, new Rectangle(100, 50, 70, 120));

            __Buffer.Render();
        }

    }
}