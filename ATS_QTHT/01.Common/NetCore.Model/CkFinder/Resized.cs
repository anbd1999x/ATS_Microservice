﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Resized
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public List<string> __custom { get; set; }
    }
}
