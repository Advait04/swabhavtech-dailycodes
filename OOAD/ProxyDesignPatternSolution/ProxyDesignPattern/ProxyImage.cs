using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
   public class ProxyImage:IImage
    {
        private string _fileName;
        private RealImage realImage;

        public ProxyImage(string filename, RealImage realImage)
        {
            this._fileName = filename;
            Console.WriteLine("Loading File:" + filename);
        }
        public string FileName
        {
            get
            {
                return _fileName;
            }
        }
        public void Display()
        {
            Console.WriteLine("Display the Filename:" + FileName);
            if (realImage == null)
            {
                realImage = new RealImage();
            }
            realImage.Display();
        }
    }
}
