using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemsExternalLib;

namespace ShoppingCartClientApp
{
    public class HatToItemAdapter : IItem
    {
        private Hat _hat;

        public HatToItemAdapter(Hat hat)
        {
            _hat = hat;
        }

        public string ItemName()
        {
            return _hat.ShortName;
        }
        public double ItemPrice()
        {
            return _hat.Price;

        }
    }
}

