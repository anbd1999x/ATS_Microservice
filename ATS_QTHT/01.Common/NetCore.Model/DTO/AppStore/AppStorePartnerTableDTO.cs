using System;
using System.Collections.Generic;
using NetCore.Core.Enums;

namespace NetCore.Models.DTO.AppStore
{
    public class AppStorePartnerTableDTO
    {
        public Guid id;
        public string name;
        public int capacity;
        public Enums.TableStatus? table_status;
        public Enums.TableStatus? order_status;
        public int? orderedProductCount;
        public int? pendingProductCount;
        public int? readyProductCount;
        public DateTime? firstOrderTime;
        public int floor;

    }
    public class AppStorePartnerTableSignalRDTO : AppStorePartnerTableDTO
    {
        public Guid partner_id { get; set; }
        public int? partner_branch_id { get; set; }
    }

    public class AppStorePartnerTableStatusDTO 
    {
        public Guid partner_id { get; set; }
        public int? partner_branch_id { get; set; }

        public List<AppStorePartnerTableDTO> lst_partner_table { get; set; }
    }
}