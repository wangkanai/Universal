﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleAnalytics
{
    internal class PageviewOption : FieldOption
    {
        public string Page { get; set; }
        public string Title { get; set; }
        public string HitCallback { get; set; }
        public bool AnonymizeIp { get; set; }
    }
}
