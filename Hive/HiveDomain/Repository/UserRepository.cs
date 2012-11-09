using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Domain;

namespace Hive.Repository
{
    public interface UserRepository
    {
        User Find(String login);
    }
}
