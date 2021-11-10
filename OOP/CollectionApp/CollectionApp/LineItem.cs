using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp
{
    class LineItem
    {
        public string productName;
        public double price;
        public int quantity;
       

        public LineItem(string productname, double Pprice, int pquantity)
        {
            this.productName = productname;
            this.price = Pprice;
            this.quantity = pquantity;
        }
        public string productname
        {
            get
            {
                return productName;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
        }
        public double TotalPrice()
        {
           double totalPrice = price * quantity;
            return totalPrice;
        }
        
}

}
    
