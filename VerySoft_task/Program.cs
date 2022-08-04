using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoft_task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape s=new Circle();
            Console.WriteLine(((Circle)s).getArea());//polymorphism
           
           
            
            GeometricObject[] go = new GeometricObject[4];
            go[0]=new Rectangle(2,7);
            go[1]=new Rectangle(4,3); 
            go[2]=new Circle(5);
            go[3]=new Circle(7);
            
            Console.WriteLine("interface arr");
            for (int i = 0; i < go.Length; i++)
            {
                Console.WriteLine(i+1+". Area of the shape is "+go[i].getArea());
                Console.WriteLine(i+1+". Perimeter of the shape is "+go[i].getPerimeter());
            }
            Shape[] arrShape =
            {
                new Circle(4),
                new Rectangle(2,4),
            };

            
            Console.WriteLine("shape arr");
            for (int i = 0; i < arrShape.Length; i++)
            {
                if (arrShape[i] is Rectangle)
                {
                    Console.WriteLine(i+1+". Area of the shape is "+((Rectangle)arrShape[i]).getPerimeter());
                    Console.WriteLine(i+1+". Perimeter of the shape is "+((Rectangle)arrShape[i]).getArea()); 
                }
                else
                {
                    Console.WriteLine(i+1+". Area of the shape is" +((Circle)arrShape[i]).getPerimeter());
                    Console.WriteLine(i+1+". Perimeter of the shape is "+((Circle)arrShape[i]).getArea());
                }
            }

            Circle c1 = new Circle();
            Circle c2 = new Circle(4);
            Circle c3 = new Circle(5, "red", true);

            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(2, 4);
            Rectangle r3 = new Rectangle(3, 7, "yellow", false);
            
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.ReadLine();
           
        }
    }
}
