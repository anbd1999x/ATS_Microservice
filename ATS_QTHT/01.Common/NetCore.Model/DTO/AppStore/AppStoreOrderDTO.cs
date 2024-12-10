using System;
using System.Collections.Generic;
using NetCore.Extensions;

namespace NetCore.Models.DTO.AppStore
{
    public class AppStoreOrderDTO
    {
        public Guid id;
        public Guid tableId;
        public DateTime dateCreated;
        public List<AppStoreOrderItemDTO> orderItems;
    }
}