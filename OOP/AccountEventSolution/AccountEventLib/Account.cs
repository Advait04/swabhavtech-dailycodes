﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventLib
{
    public delegate void DBalanceChanged(Account acc);

    public class Account
    {
        private string _name;
        private int _accountNumber;
        private double _balance;
        private double _withdraw;
        public event DBalanceChanged OnBalanceChanged = null;
        public Account(string name, int accountNumber, double balance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
            if (OnBalanceChanged != null) OnBalanceChanged(this);
        }
        public void Withdraw(double amount)
        {
            _withdraw = amount;
            const double MINAMOUNT = 500.00;
            if (_balance - amount < MINAMOUNT)
            {
                throw new Exception("Insufficient Balance");
            }
            _balance = _balance - amount;
            if (OnBalanceChanged != null) OnBalanceChanged(this);
        }
        public double WithdrawAmount
        {
            get
            {
                return _withdraw;
            }
        }
        public int GetAccountNumber()
        {
            return _accountNumber;
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
