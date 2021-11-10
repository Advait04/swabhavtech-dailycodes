using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityApp
{
    class InvalidUserException:Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid User entered!!!";
            }
        }
    }
}
