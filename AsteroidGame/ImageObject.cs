using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace AsteroidGame
{
    class ImageObject : VisualObject
    {
        private Image _Image;

         public ImageObject(Point Position, Point Direction, Size Size, Image Image) : base(Position, Direction, Size)
        {
            _Image = Image;

        }

    }
}
