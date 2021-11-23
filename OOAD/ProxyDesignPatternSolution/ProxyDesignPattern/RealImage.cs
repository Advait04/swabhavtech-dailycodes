using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
   public class RealImage:IImage
    {
        private string _FileName;

        public RealImage(string Filename)
        {
            this._FileName = Filename;
            Console.WriteLine("Loading File:" + GetFileName());
        }

        public RealImage()
        {
        }

        public string GetFileName()
        {

            return _FileName;

        }
        public void Display()
        {
            Console.WriteLine("Display File Name:" + GetFileName());
        }
    }
}
