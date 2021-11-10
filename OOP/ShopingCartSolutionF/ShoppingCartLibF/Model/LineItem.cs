using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibF.Model
{
    public class LineItem
    {
        private int _id;
        private int _quantity;
        private double _totalPrice;
        private Product _product;
        public LineItem(int id,Product product, int quantity)
        {
            _id = id;
            _product = product;
            _quantity = quantity;
            _totalPrice = CalculateTotalPrice(product);
        }
        public int ID
        {
            get
            {
                return _id;
            }
        }
        public double CalculateTotalPrice(Product product)
        {
            double singlePrice = product.Price - ((product.Price * product.Discount) / 100);
            return _quantity * singlePrice;
        }

        public Product Product 
        {
            get 
            { 
                return _product;
            } 
        }
        public int Quantity 
        { 
            get
            {
                return _quantity;
            } 
            set
            {
                _quantity = value;
            }
        }
        public double TotalPrice
        {
            get
            { 
                return _totalPrice;
            }
        }
    }
}
