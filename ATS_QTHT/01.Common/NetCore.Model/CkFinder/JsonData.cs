﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class JsonData
    {
        public List<JsonDataFile> files { get; set; }
        public string ckCsrfToken { get; set; }
    }
}
