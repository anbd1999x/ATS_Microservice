﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class GetFiles
    {
        public string resourceType { get; set; }
        public CurrentFolder currentFolder { get; set; }
        public List<Files> files { get; set; }
    }
}
