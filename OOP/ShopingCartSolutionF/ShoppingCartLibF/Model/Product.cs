using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibF.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discount;

        public Product(int id, string name, double price, float discount)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._discount = discount;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public override int GetHashCode()
        {
            return _id;
        }
        public override bool Equals(object obj)
        {
            Product matchProduct = (Product)obj;
            if (this.Id == matchProduct.Id && this.Name == matchProduct.Name) return true;
            return false;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float Discount
        {
            get
            {
                return _discount;
            }
        }
        public double GetDiscountedPrice()
        {
            return _price - ((_price * _discount) / 100);
        }
    }
}
