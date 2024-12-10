using System;
using System.Collections.Generic;
using NetCore.Core.Enums;

namespace NetCore.Models.DTO.AppStore
{
    public class OrderDetailDTO
    {
        public string table_name { get; set; }
        public List<OrderItemDetailDTO> orders { get; set; }
        public decimal? total_gross_amount { get; set; }
        public int? floor { get; set; }
        public Guid? invoicetotalid { get; set; }
    }

    public class OrderItemDetailDTO
    {
        public Guid id { get; set; }
        public string product_name { get; set; }
        public decimal quantity { get; set; }
        public Enums.OrderItemStatus status { get; set; }
        public decimal price { get; set; }
        public decimal total_amount { get; set; }
        public Guid product_menu_id { get; set; }
        public string? note { get; set; }
        public bool is_paid { get; set; }
    }

    public class OrderItemForMessageDTO
    {
        public string Name { get; set; }
        public decimal? quantity { get; set; }
        public decimal Price { get; set; }
    }
}