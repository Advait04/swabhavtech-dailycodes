using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibF.Model
{
   public  class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items = new List<LineItem>();

        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;
        }
        public int Id
        {
            get
            {
                return _id;
            }

        }
        public DateTime DateTime
        {
            get
            {
                return _date;
            }
        }
    }
}

