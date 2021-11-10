using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountApp.Model
{
    public class Account
    {
        private const double _defaultBalance = 500;
        private readonly int _accNo;
        private readonly string _name;
        private double _balance;
        static int _count = 0;


        public Account(int accno,string name,double balance)
        {
            this._accNo = accno;
            this._name = name;
            this._balance = balance;
            _count++;

        }

        public Account(int accno,string name)
        {
            this._accNo = accno;
            this._name = name;
            _count++;
        }

        public double Deposit (double amount )
        {
            
            _balance += amount;
            return _balance;
        }

        public void Withdraw(double amount)
        {
            if(amount < _balance && (-_balance - amount) >= -_defaultBalance)
            {
                _balance -= amount;
                Console.WriteLine("Transaction Completed..Amount Debited:" + amount);
                    
            }
            else
            {
                Console.WriteLine("Transaction Failed..");
            }
              

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

        public void SetCount(int count)
        {
            count = _count;
        }

        public int GetCount()
        {
            return _count;

        }


            
          

    }
}
