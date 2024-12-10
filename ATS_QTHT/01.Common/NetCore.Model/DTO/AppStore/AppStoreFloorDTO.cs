using System;
using System.Collections.Generic;
using NetCore.Extensions;

namespace NetCore.Models.DTO.AppStore
{
    public class AppStoreFloorDTO
    {
        public Guid Id { get; set; }
        public Guid TableId { get; set; }
        public DateTime DateCreated { get; set; }
        public List<AppStoreOrderItemDTO> OrderItems { get; set; }
    }
}