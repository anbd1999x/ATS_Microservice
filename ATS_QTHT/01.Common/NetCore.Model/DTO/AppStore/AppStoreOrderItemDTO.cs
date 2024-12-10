using System;
using NetCore.Extensions;

namespace LOYNetCore.ModelsALTY.DTO.AppStore
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