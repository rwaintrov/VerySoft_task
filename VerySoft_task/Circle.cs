using System;

namespace VerySoft_task
{
    public class Circle: Shape, GeometricObject
    {
        //prop
        internal double radius;
        
        //c-tor
        public Circle() : base()
        {
            radius = 1;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }


        // method
        // calculate area
        public double getArea()
        {
            return Math.PI*Math.Pow(2, radius); 
        }
        
        // calculate Perimeter
        public double getPerimeter()
        {
            return 2*Math.PI*radius;
        }


        // getter & setter
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}