using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Model.Repository
{
    public interface UserRepository
    {
        Hive.Model.Domain.User Find(String login);
    }
}
