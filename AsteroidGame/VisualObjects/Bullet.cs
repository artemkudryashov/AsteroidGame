﻿using AsteroidGame.VisualObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame.VisualObjects
{
    class Bullet : CollisionObject
    {
        private const int _BulletSizeX = 20;
        private const int _BulletSizeY = 5;

        public Bullet(int Position)
            : base(new Point(0, Position), Point.Empty, new Size(_BulletSizeX, _BulletSizeY))
        {

        }

        public override void Draw(Graphics g)
        {
            var rect = Rect;
            g.FillEllipse(Brushes.Red, rect);
            g.DrawEllipse(Pens.White, rect);
            //g.FillEllipse(Brushes.Red,_Position.X, _Position.Y, _Size.Width, _Size.Height);
            //g.DrawEllipse(Pens.White,_Position.X, _Position.Y, _Size.Width, _Size.Height);
        }


        public override void Update()
        {

            _Position = new Point(_Position.X + 3, _Position.Y);

        }


    }
}
