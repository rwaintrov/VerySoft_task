using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoft_task
{
    public class Rectangle:Shape,GeometricObject {
        //prop
        internal double length;
        internal double width;
        
        //c-tor
        public Rectangle():base()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(double length, double width, string color,bool filled):base(color,filled)
        {
            this.length = length;
            this.width = width;
        }


        //method
        // calculate area
        public double getArea()
        {
            return length*width;
        }

        // calculate Perimeter
        public double getPerimeter()
        {
            return (length*2)+(width*2);
        }


        // getter & setter
        public double getLengh()
        {
            return length;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getWidth()
        {
            return width;
        }
        public void setWidht(double width)
        {
            this.width = width;
        }

        public override string ToString()
        {
            return "A Rectangle with widht = " + width + " and length = " + length + " which is a subclass of " + base.ToString();
        }
       
    }
}
