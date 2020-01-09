using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class User
    {
        private bool _isLoggedIn;
        private string _token;

        public bool IsLoggedIn { get => _isLoggedIn; set => _isLoggedIn = value; }
        public string Token { get => _token; set => _token = value; }

        public User(string data)
        {

        }
    }
}
