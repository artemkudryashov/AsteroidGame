using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsteroidGame.VisualObjects.Interfaces;

namespace AsteroidGame.VisualObjects
{
    class SpaceShip : VisualObject, ICollision
    {
        public SpaceShip(Point Position, Point Direction, Size Size) 
            : base(Position, Direction, Size)
        {

        }

        public bool CheckCollision(ICollision Obj)
        {
            throw new NotImplementedException();
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
