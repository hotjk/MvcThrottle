using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcThrottle
{
    [Serializable]
    public class ThrottlePolicyWhitelist
    {
        public string Entry { get; set; }

        public ThrottlePolicyType PolicyType { get; set; }
    }
}
