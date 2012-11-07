using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Domain
{
    class User
    {
        public User(string Login, string Password)
        {
            _Login = Login;
            _Password = Password;
        }
        private string _Login;
        private string _Password;
        public string Login { get { return _Login; } }
        public string Password { get { return _Password; } }
    }
}
