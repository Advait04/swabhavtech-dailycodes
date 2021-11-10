using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityApp
{
    class SecurityService
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        public SecurityService()
        {
            users.Add("101", new User("101", "Advait", "Kunte", "ak@gmail.com", "@101"));
            users.Add("102", new User("102", "rohit", "Sharma", "rs@gmail.com", "@102"));
            users.Add("103", new User("103", "rahul", "KL", "rk@gmail.com", "@103"));
            users.Add("104", new User("104", "Virat", "Kohli", "vk@gmail.com", "@104"));
            users.Add("105", new User("105", "Surya", "Yadav", "sy@gmail.com", "@105"));
        }

        public User Login(string id, string password)
        {
            foreach (var user in users)
            {
                var LoginStatus = CheckUser(user.Value, id, password);
                if (LoginStatus != null) return LoginStatus;
            }
            throw new InvalidUserException();
        }

        private User CheckUser(User user, string id, string password)
        {
            if (user.ID == id && user.Password == password)
                return user;
            return null;
        }
    }
}
