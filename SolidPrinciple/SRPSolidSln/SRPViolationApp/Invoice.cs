﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;
        

        public Invoice(int id, string description, double amount, float tax, float discount)
        {
            this._id = id;
            this._description = description;
            this._amount = amount;
            this._tax = tax;
            this._discount = discount;
        }
        public double CalculateDiscount()
        {
            return ((_amount + CalculateTax()) * _discount) / 100;
        }
        public double CalculateTax()
        {
            return (_amount * _tax) / 100;
        }
        public double FinalAmount()
        {
            return _amount + CalculateTax() - CalculateDiscount();

        }
        public void PrintInvoice()
        {
            Console.WriteLine("Invoice Details:\nID: {0}\nDescription: {1}\n" +
                              "Original Amount: {2}\nTax: {3}%\nDiscount: {4}%\n" +
                              "Tax Amount: {5}\nDiscount Amount: {6}\n" +
                              "Total Amount: {7}", _id, _description, _amount, _tax, _discount,
                              CalculateTax(), CalculateDiscount(), FinalAmount());

        }
    }
}
