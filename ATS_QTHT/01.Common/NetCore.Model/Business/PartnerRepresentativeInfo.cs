using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class PartnerRepresentativeInfo : MasterCommonModel
    {
        public int? id { get; set; }
        public int? bk_id { get; set; }
        public Guid? partner_id { get; set; }
        public int type { get; set; }
        public string representative_name { get; set; }
        public string representative_title { get; set; }
        public string representative_job { get; set; }
        public int document_type { get; set; }
        public string id_number { get; set; }        
        public string dob { get; set; }
        public string hometown { get; set; }
        public string permanent_address { get; set; }
        public string current_address { get; set; }
        public string gender { get; set; }
        public string valid_thru { get; set; }
        public string religion { get; set; }
        public string nation { get; set; }
        public string nationality { get; set; }
        public string place_of_birth { get; set; }
        public string identifiers { get; set; }
        public string issued_date { get; set; }
        public string issued_place { get; set; }
        public string citizen_numb { get; set; }
        public string citizen_card_front { get; set; }
        public string citizen_card_back { get; set; }
        public string profile_picture { get; set; }

        [NotMapped]
        public string? number { get; set; }
    }
}
