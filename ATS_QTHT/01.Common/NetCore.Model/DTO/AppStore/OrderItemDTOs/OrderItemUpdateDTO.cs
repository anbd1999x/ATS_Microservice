using System;

namespace NetCore.Models.DTO.AppStore.OrderItemDTOs
{
    public class OrderItemUpdateDTO
    {
        public Guid id { get; set; }
        public decimal quantity { get; set; }
    }
}