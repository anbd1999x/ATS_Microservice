using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class CompanyBranch
    {
        public int id { get; set; }                  // ID của chi nhánh
        public string name { get; set; }             // Tên công ty
        public string code { get; set; }             // Mã công ty
        public DateTime date_created { get; set; }   // Ngày tạo
        public DateTime date_updated { get; set; }   // Ngày cập nhật
    }
}
