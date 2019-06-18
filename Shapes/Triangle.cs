using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        private int side1;
        private int side2;
        private int side3;
        private double angle;

        
        public Triangle(int side1, int side2, int side3, double angle, string shapeId) : base(shapeId)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.angle = angle;
        }
        public override double Area
        {
            get
            {
                return 0.5 * (side1 * side2) * Math.Sin(angle);
            }
        }
        public override double Perimeter
        {
            get
            {
                return side1 + side2 + side3;
            }
        }
    }
}


