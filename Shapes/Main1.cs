using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Main1
    {
          public static void Main()
        {
            Shape square = new Square(9, "Square 1");
            Shape tr = new Triangle(4, 6, 8, 45, "Triangle 1");
            Shape circle = new Circle(5, "Circle 1");

            Console.WriteLine(square);
            Console.WriteLine(tr);
            Console.WriteLine(circle);

            Console.ReadLine();
        }
    }
}
