using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        private int side;

        public Square(int side, string shapeId) : base (shapeId)
        {
            this.side = side;        
         }
        public override double Area
        {
            get
            {
                return side * side;
            }
        }
        public override double Perimeter
        {
            get
            {
                return 4 * side;
            }
        }
    }

    }

