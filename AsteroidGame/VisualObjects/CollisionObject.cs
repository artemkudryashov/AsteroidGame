using AsteroidGame.VisualObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame.VisualObjects
{
    abstract class CollisionObject : VisualObject, ICollision
    {
        protected CollisionObject(Point Position, Point Direction, Size Size)
            : base(Position, Direction, Size)
        {
        }

        public bool CheckCollision(ICollision Obj) => Rect.IntersectsWith(Obj.Rect);

    }
}
