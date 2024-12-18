﻿using System;
using NetCore.Core.Enums;

namespace NetCore.Models.Business.Order
{
    public class OrderItem
    {
        public Guid id { get; set; }
        public Guid order_id { get; set; }
        public Guid? product_id { get; set; }
        public Guid? product_menu_combo_id { get; set; }
        public Guid product_menu_id { get; set; }
        public int? version { get; set; }
        public decimal base_price { get; set; }
        public decimal price_override { get; set; }
        public decimal total_price_gross_amount { get; set; }
        public decimal total_price_net_amount { get; set; }
        public decimal quantity { get; set; }
        public Enums.OrderItemStatus status { get; set; }
        public string? note { get; set; }
    }
}