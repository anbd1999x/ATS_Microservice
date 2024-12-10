using System;

namespace NetCore.Models.Business.Order
{
    public class ProductMenuComboCurrentVersion
    {
        public Guid id { get; set; }
        public Guid product_menu_combo_id { get; set; }
        public int version { get; set; }
    }
}