﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    public class BKVATransaction
    {
        public string? RequestId { get; set; }
        public string? RequestTime { get; set; }
        public string? PartnerCode { get; set; }
        public string? AccNo { get; set; }
        public string? ClientIdNo { get; set; }
        public string? TransId { get; set; }
        public decimal? TransAmount { get; set; }
        public string? TransTime { get; set; }
        public decimal? BefTransDebt { get; set; }
        public decimal? AffTransDebt { get; set; }
        public int? AccountType { get; set; }
        public string? OrderId { get; set; }
        public string? Signature { get; set; }
        public int? Status { get; set; }
        public DateTime? date_created { get; set; }
    }
}
