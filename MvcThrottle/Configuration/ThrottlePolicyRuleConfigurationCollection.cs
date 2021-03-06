﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcThrottle
{
    public class ThrottlePolicyRuleConfigurationCollection : ConfigurationElementCollection
    {

        protected override ConfigurationElement CreateNewElement()
        {
            return new ThrottlePolicyRuleConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ThrottlePolicyRuleConfigurationElement)element).Entry;
        }
    }
}
