using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        private int _accNo;
        private string _name;
        protected double _balance;


        public Account(int paccNo, string pname, double pbalance)
        {
            this._accNo = paccNo;
            this._name = pname;
            this._balance = pbalance;

        }
        public void  Deposit(double amount)
        {
            _balance += amount;
            
        }
        public abstract void Withdraw(double amount);
        public int accNo
        {
            get
            {
                return _accNo;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
           
        }

        public double balance
        {
            get
            {
                return _balance;
            }
            
        }

    }
}
