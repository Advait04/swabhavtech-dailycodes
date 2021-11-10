using AccountCustomExceptionApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp.Model
{
    class Account
    {
        private const double _defaultBalance = 500;
        private readonly int _accNo;
        private readonly string _name;
        private double _balance;

        public Account(int accno, string name, double balance)
        {
            this._accNo = accno;
            this._name = name;
            this._balance = balance;

        }

        public Account(int accno, string name)
        {
            this._accNo = accno;
            this._name = name;
        }

        public double Deposit(double amount)
        {

            _balance += amount;
            return _balance;
        }

        public void Withdraw(double amount)
        {
            const double min_amount = 500.00;
            if(_balance - amount <min_amount)
            {
                throw new InsufficientFundsException(this, amount);
            }

            _balance = _balance - amount;


        }

        public int GetAccNo()
        {
            return _accNo;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetBalance()
        {
            return _balance;
        }




    }
}
