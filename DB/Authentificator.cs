using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Authentificator
    {
        private readonly string UserName;
        private readonly string Password;

        public Authentificator(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User Login()
        {

        }

        public User Register()
        {
            string userInformationQueryRequest = "";
            RequestManager rm = new RequestManager(userInformationQueryRequest);
            return Parse(rm.Data);
        }

        private User Parse(string data)
        {
            return new User(data);
        }
    }
}
