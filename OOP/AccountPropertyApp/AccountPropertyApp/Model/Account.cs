using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPropertyApp.Model
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
            if (amount < _balance && (-_balance - amount) >= -_defaultBalance)
            {
                _balance -= amount;
                Console.WriteLine("Transaction Completed..Amount Debited:" + amount);

            }
            else
            {
                Console.WriteLine("Transaction Failed..");
            }


        }

        public int AccNo
        {
            get
            {
                return _accNo;
            }
        }


        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }




    }
}
