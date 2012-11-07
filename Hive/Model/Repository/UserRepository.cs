using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Repository
{
    interface UserRepository
    {
        void VerifyUser(User user);
    }
}
