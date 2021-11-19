using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemsExternalLib
{
   public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        
        public Hat(string shortname,string longname,double amount)
        {
            _shortName = shortname;
        }
        private double HatGst()
        {
            return (_basePrice * 8) / 100;
        }

        public double Price
        {
           get
            {
                return _basePrice + HatGst();
            }
        }
        public string ShortName
        {
          get
                {
                return _shortName;
            }
        }
        public string LongName
        {
            get
            {
                return _longName;
            }
           
        }
    }
}
