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
            int tr_side1 = 0;
            int tr_side2 = 0;
            int tr_side3 = 0;
            double tr_angle = 0;
            int c_radius = 0;
            int sq_side = 0;


            Console.WriteLine("Select the number of shape, that need to calculate Area and Perimetr: \n1.Square \n2.Triangle \n3.Circle");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)

            {
                case 1:
                    Console.WriteLine("Enter a square's side");
                    sq_side = int.Parse(Console.ReadLine());


                    break;
                case 2:
                    Console.WriteLine("Enter a triangle's first side");
                    tr_side1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a triangle's second side");
                    tr_side2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a triangle's trird side");
                    tr_side3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a triangle's angle beside 1st and 2nd side");
                    tr_angle = int.Parse(Console.ReadLine());

                    break;
                case 3:
                    Console.WriteLine("Enter a circle's radius");
                    c_radius = int.Parse(Console.ReadLine());

                    break;

            }

            Shape square = new Square(sq_side, "Square");
            Shape tr = new Triangle(tr_side1, tr_side2, tr_side3, tr_angle, "Triangle");
            Shape circle = new Circle(c_radius, "Circle");

            if (choise == 1)
            {
                Console.WriteLine(square);
            }
            else if (choise == 2)
            {
                if (tr_angle > 180 || tr_angle < 0)
                {
                    Console.WriteLine("Incorrect value");
                }
                else
                {
                    Console.WriteLine(tr);
                }
                
            }
            else if (choise == 3)
            {
                Console.WriteLine(circle);
            }
            else
            {
                Console.WriteLine("Incorrect entered number");
            }
                  
           
            Console.ReadLine();
        }
    }
}
