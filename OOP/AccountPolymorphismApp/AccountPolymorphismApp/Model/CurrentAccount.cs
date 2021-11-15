using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountPolymorphismApp.Model
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int paccNo, string pname, double pbalance) : base(paccNo, pname, pbalance)

        {

        }


        public override void Withdraw(double amount)
        {
            if (DoOverDraftCheck())
            {
                _balance = balance - amount;
            }
        }

        private bool DoOverDraftCheck()
        {
            return true;
        }

    }
}

