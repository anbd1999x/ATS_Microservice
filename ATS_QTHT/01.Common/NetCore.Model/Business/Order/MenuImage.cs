using System;

namespace NetCore.Models.Business.Order
{
    public class MenuImage
    {
        public Guid id { get; set; }
        public Guid menu_id { get; set; }
        public string name { get; set; }
        public string links { get; set; }
    }
}