using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Hive.ServiceLibrary.Contract
{
    [MessageContract(WrapperNamespace = ServiceConstants.Namespace)]
    public class WsFilter : Hive.Domain.Filter
    {
        Dictionary<string, object> filterSpecification = new Dictionary<string,object>();

        public WsFilter() { }

        public WsFilter(Dictionary<string, object> filterSpecification)
        {
            this.filterSpecification = filterSpecification;
        }

        [MessageBodyMember]
        public Dictionary<string, object> FilterSpecification
        {
            get { return filterSpecification; }
            set { this.filterSpecification = value; }
        }

        public string ToQuery(string baseName, string joinCondition)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            foreach (KeyValuePair<string, object> entry in filterSpecification)
            {
                sb.Append(baseName);
                sb.Append(".");
                sb.Append(entry.Key);
                if (entry.Value.GetType() == typeof(string))
                {
                    sb.Append(" like \"");
                    sb.Append(entry.Value);
                    sb.Append("%\"");
                }
                else
                {
                    sb.Append( "= ");
                    sb.Append(entry.Value);
                }
                if (counter < filterSpecification.Count - 1)
                {
                    sb.Append(" ");
                    sb.Append(joinCondition);
                    sb.Append(" ");
                }
                counter++;
            }

            return sb.ToString();
        }
    }
}
