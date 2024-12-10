using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class FileUpload
    {
        public string resourceType { get; set; }
        public CurrentFolder currentFolder { get; set; }
        public string fileName { get; set; }
        public int uploaded { get; set; }
    }
}
