using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoft_task
{
    public abstract class Shape
    {
        internal string color;
        internal bool filled;

        // c-tor
        public Shape()
        {
           color = "green";
           filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }


        //getter & setter
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public bool getfilled()
        {
            return filled;
        }
        public void setfilled(bool filled)
        {
            this.filled = filled;
        }


        public override string ToString()
        {
            string s = filled? "filled": "Not filleed";
            return "A Shape with color of " + this.color + " and " + s;
        }
    }
}
