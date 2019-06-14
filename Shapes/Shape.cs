using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private string ShapeName;
        public Shape(string shapeId)
        {
            ShapeId = shapeId;
        }
        public string ShapeId
        {
            get
            {
                return ShapeName;
            }
            private set
            {
                ShapeName = value;
            }
        }
        public abstract double Area
        {
            get;
        }
                
        public abstract double Perimeter
        {
            get;
        }

        public override string ToString()
        {
            return $"{ShapeId} Area = {Area:F2}, Perimeter = {Perimeter:F2}";
        }
    }
}
