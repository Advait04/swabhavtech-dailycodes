using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private int radius;
        private string colour;



        public void SetRadius(int pradius)
        {
            if (pradius > 10)
            {
                radius = 10;
            }
            else
            {
                radius = pradius;
            }
        }
        public int GetRadius()
        {
            return radius;
        }

        public void SetColour(string pcolour)
        {
            if (pcolour == "red" || pcolour == "blue" || pcolour == "green") 
            {
                colour = pcolour;
            }
            else
            {
                colour = "red";
            }
        }
        public string GetColour()
        {
            return colour;
        }
    }


}
