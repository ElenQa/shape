using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string shapeId) : base(shapeId)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Sqrt(radius);
            }
        }
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * radius;
                ;
            }
        }
    }
}


