using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Hive.Domain
{
    [DataContract]
    public class User
    {
        public User(string Login, string Password)
        {
            _Login = Login;
            _Password = Password;
        }
        private string _Login;
        private string _Password;
        [DataMember]
        public string Login { get { return _Login; } set { _Login = value; } }
        [DataMember]
        public string Password { get { return _Password; } set { _Password = value; } }
    }
}
