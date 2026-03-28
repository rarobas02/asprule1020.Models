using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprule1020.Models
{
    public class EvaluationRemarks
    {
        public Guid Id { get; set; }
        public Guid? RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        [ValidateNever]
        public Register? Register { get; set; }
        public string? est_name_input { get; set; }
        public string? est_type_input { get; set; }
        public string? est_legalorg_input { get; set; }
        public string? est_adress_input { get; set; }
        public string? est_barangay_input { get; set; }
        public string? est_citymun_input { get; set; }
        public string? est_province_input { get; set; }
        public string? est_region_input { get; set; }
        public string? est_manag_first_input { get; set; }
        public string? est_manag_mid_input { get; set; }
        public string? est_manag_last_input { get; set; }
        public string? est_regdate_input { get; set; }
        public string? est_bus_nature_input { get; set; }
        public string? est_bnature_oth_input { get; set; }
        public string? est_cur_cap_input { get; set; }
        public string? est_total_asset_input { get; set; }
        public string? est_contact_input { get; set; }
        public string? est_tin_input { get; set; }
        public string? est_email_input { get; set; }
        public string? est_malenum_input { get; set; }
        public string? est_femalenum_input { get; set; }
        public string? est_totalemploy_input { get; set; }
        public string? est_techinfo1_input { get; set; }
        public string? est_techinfooth1_input { get; set; }
        public string? est_techinfo2_input { get; set; }
        public string? est_techinfooth2_input { get; set; }
        public string? est_chemsub_input { get; set; }
        public string? est_sec_number_input { get; set; }
        public string? est_sec_dateiss_input { get; set; }
        public string? est_sec_permit_input { get; set; }
        public string? est_peza_input { get; set; }
        public string? est_bperm_number_input { get; set; }
        public string? est_bperm_dateiss_input { get; set; }
        public string? est_bperm_validity_input { get; set; }
        public string? est_bus_perm_input { get; set; }
        public string? est_valid_number_input { get; set; }
        public string? est_valid_dateiss_input { get; set; }
        public string? est_valid_validity_input { get; set; }
        public string? est_termrep_input { get; set; }
    }
}