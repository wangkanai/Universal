﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleAnalytics
{
    internal class DisplayFeatures : Require
    {
        public DisplayFeatures(Configuration config)
        {
        }
        public override string ToString()
        {
            return "ga('require', 'displayfeatures');";
        }
    }
}
