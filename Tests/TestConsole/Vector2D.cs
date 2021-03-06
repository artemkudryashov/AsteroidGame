﻿using System;

namespace TestConsole
{
    readonly struct Vector2D
    {
        private readonly double _X;
        //private double _Y;

        public double X
        {
            get
            {
                return _X;
            }
        }
        //public double Y { get => _Y; set => _Y = value; }
        public double Y { get; }

        public double Length => Math.Sqrt(X * X + Y * Y);

        public Vector2D(double x, double y)
        {
            this._X = x;
            this.Y = y;
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector2D)
            {
                return ((Vector2D)obj).X == X && ((Vector2D)obj).Y == Y;
            }
            return false;
        }

        public override int GetHashCode()
        {

            var hash = X.GetHashCode();
            unchecked
            {
                hash = (hash * 372) ^ Y.GetHashCode();
            }
            return hash;
        }



        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2D operator +(Vector2D a, double b)
        {
            return new Vector2D(a.X + b, a.Y + b);
        }

        public static Vector2D operator -(Vector2D a)
        {
            return new Vector2D(-a.X, -a.Y);
        }
    }

}
