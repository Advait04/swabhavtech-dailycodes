using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountCustomExceptionApp
{
    class InsufficientFundsException : Exception
    {
        private string _message;
        
       public InsufficientFundsException(Account acc,double withdrawamount)
        {
            _message = "\n Transaction account number: " + Convert.ToString(acc.GetAccNo())+"To Maintain Minimum balance"
                +acc.GetName()+"."+acc.GetBalance()+"Withdrwa amount:"
                +Convert.ToString(withdrawamount);
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}


