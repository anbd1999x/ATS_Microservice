﻿using System;

namespace NetCore.Models.Business.Order
{
    public class ProductMenu
    {
        public Guid id { get; set; }
        public Guid menu_id { get; set; }
        public Guid? product_id { get; set; }
        public decimal base_price { get; set; }
        public decimal price_override { get; set; }
        public Guid? product_menu_combo_id { get; set; }
        public Guid? product_menu_group_id { get; set; }
    }
}