﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountToStringEqualityApp.Model
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
        public override string ToString()
        {
            string ovstring = "Acc no:" + Convert.ToString(this._accNo) + "Name:" + Convert.ToString(this._name) + "Balance:" + Convert.ToString(this._balance);
                return ovstring+"\nParent" +base.ToString();

            
        }
        public override bool Equals(object obj)
        {
            if (_name == ((Account)obj).GetName() || _accNo == ((Account)obj).GetAccNo())
            {
                return true;
            }
            else
            {
                return base.Equals(obj);
            }

        }
        internal bool Tostring()
        {
            throw new NotImplementedException();
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

