﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityApp
{
   public class UserView
    {
        private string _email, _firstName, _lastName;
        public UserView(string email, string firstName, string lastName)
        {
            _email = email;
            _firstName = firstName;
            _lastName = lastName;
        }
        public string FirstName
        {
            get
            { 
                return _firstName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
    }
}
