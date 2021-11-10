using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int heigth;
       

        private int Valdiate(int pvalue )
        {
            if(pvalue>100 && pvalue<1)
            {
                Valu
            }
          
            
        }

        public  void SetWidth(int pwidth)
        {
            if(pwidth>100)
            {
                width = 100;

            }
            else if (pwidth < 1)
            {
                width = 1;
            }
            else
            {
                width = pwidth;
            }
        }

         public int  GetWidth()
        {
            return width;
           
        }

        public void SetHeigth(int pheigth)
        {
            if(pheigth>50)
            {
                heigth = 50;
            }
            else if(pheigth > 1) 
            {
                heigth = 1;
            }
            else
            {
                heigth = pheigth;
            }

        }

        public int GetHeigth()
        {
            return heigth;
        }
    }
}
