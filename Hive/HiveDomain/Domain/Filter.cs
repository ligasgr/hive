using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Hive.Domain
{
    public interface Filter
    {
        string ToQuery(string baseName, string joinCondition);
    }
}
