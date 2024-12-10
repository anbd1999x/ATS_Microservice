using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Partner : MasterCommonModel
    {
        public Guid? id { get; set; }
        public Guid? service_type_id { get; set; }

        //[NotMapped]
        //public Guid? sub_service_type_id { get; set; }
        public int? store_type_id { get; set; }        
        public string? code { get; set; }
        public string? name { get; set; }
        public string? company_name { get; set; }
        public string? phone { get; set; }
        public string? hotline { get; set; }
        public string? email { get; set; }
        public string? start_hour { get; set; }
        public string? end_hour { get; set; }
        public string? working_day { get; set; }
        public string? store_owner { get; set; }
        public string? description { get; set; }
        public string? tax_code { get; set; }
        public Guid? product_label_id { get; set; }
        public decimal? tax_tncn { get; set; }
        public string? username { get; set; }
        public int? province_id { get; set; }
        public int? district_id { get; set; }
        public int? ward_id { get; set; }
        public int? status { get; set; }
        public string? address { get; set; }
        public string? latitude { get; set; }
        public string? longtitude { get; set; }
        public string? avatar { get; set; }
        public string? avatar_small { get; set; }
        public Boolean? is_delete { get; set; }
        public decimal? discount_rate { get; set; }
        public decimal? customer_discount_rate { get; set; }
        public decimal? rating { get; set; }
        public decimal? total_rating { get; set; }
        public Guid? support_person_id { get; set; }
        public string? support_person_phone { get; set; }
        // Bổ sung 14/09
        public string? license_no { get; set; }
        public int? license_person_number { get; set; }
        public string? license_owner { get; set; }
        public DateTime? license_birth_date { get; set; }
        public int? license_nation_id { get; set; }
        public string? indetifier_no { get; set; }
        public DateTime? identifier_date { get; set; }
        public string? identifier_at { get; set; }
        public DateTime? identifier_date_expire { get; set; }
        public string? identifier_address { get; set; }
        public int? identifier_province_id { get; set; }
        public Boolean? is_same_address { get; set; }
        public string? now_address { get; set; }
        public int? now_nation_id { get; set; }
        public int? now_province_id { get; set; }
        public string? identifier_front_image { get; set; }
        public string? identifier_back_image { get; set; }
        public Boolean? is_confirm_email_register { get; set; }
        public string? login_code { get; set; }
        public string? license_image { get; set; }
        public DateTime? license_date { get; set; }
        public int? owner_percent { get; set; }
        public int? identifier_nation_id { get; set; }
        public string? bk_partner_code { get; set; }
        public string? bk_merchant_id { get; set; }
        public string? bk_email { get; set; }
        public string? bk_password { get; set; }
        public int? bk_bank_id { get; set; }
        public string? bk_bank_no { get; set; }
        public string? bk_bank_name { get; set; }
        public string? bk_bank_owner { get; set; }
        public string? API_KEY { get; set; }
        public string? API_SECRET { get; set; }
        public int? Encrypt_status { get; set; } //1 là mã hóa , 0 là chưa mã hóa
        public string? RSA_publicKey { get; set; }
        public string? RSA_privateKey { get; set; }
        public string? link_QR { get; set; }
        public string? link_qr_ob { get; set; }
        public string? acc_no_ob { get; set; }
        public string? acc_name_ob { get; set; }
        public string? bank_name_ob { get; set; }
        public DateTime? time_otp_limit {get; set;}
        public int? count_otp_fail { get; set; }
        public Boolean? is_hidden_info { get; set; }
        public Boolean? is_accept_affiliate { get; set; }
        public Boolean? payment_realtime { get; set; }
        public Boolean? realtime_payment_non_app_user { get; set; }

        // new field for onboarding partner
        public int? industry_id { get; set; }
        public int? sub_merchant_type { get; set; }
        public string brand_name { get; set; }
        public string controlling_company { get; set; }
        public string franchise_brand { get; set; }
        public int? contract_signature_type { get; set; }
        public string store_representative_title { get; set; }
        public string store_owner_gender { get; set; }
        public int? document_type { get; set; }
        public string store_representative_job { get; set; }
        public string fax { get; set; }
        public string? authorized_capital { get; set; }
        public DateTime? change_date { get; set; }
        public DateTime? bk_datetime { get; set; }        
        public int? settlement_by_branch { get; set; }
        public int? business_model { get; set; }
        public string? reason { get; set; }
        public string? Accessaries { get; set; }

        public string? nationality { get; set; }
        public string? license_address { get; set; }
        public int? user_district_id { get; set; }
        public int? user_ward_id { get; set; }
        public int version { get; set; } = 1;

        public string company_short_name { get; set; }
        public string company_foreign_name { get; set; }
        public string website { get; set; }

        public string business_registration_certificate_front { get; set; }
        public string business_registration_certificate_behind { get; set; }
        public string tax_certificate_front { get; set; }
        public string tax_certificate_behind { get; set; }

        public DateTime? bk_updatetime { get; set; }

        public string? source_ob { get; set; }
        public bool? is_visible { get; set; }
        
        public int? type_tag { get; set; }
        public int? floor_count { get; set; }
        public string? theme { get; set; }
    }
}
