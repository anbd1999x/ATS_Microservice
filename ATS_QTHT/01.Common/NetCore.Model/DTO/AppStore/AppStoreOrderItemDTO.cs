using System;
using NetCore.Core.Enums;

namespace NetCore.Models.DTO.AppStore
{
    public class AppStoreOrderItemDTO
    {
        public Guid id;
        public Guid tableId;
        public Guid orderId;
        public decimal quantity;
        public Enums.OrderItemStatus status;
        public DateTime dateCreated;
    }
}