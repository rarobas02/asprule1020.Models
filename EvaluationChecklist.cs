using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprule1020.Models
{
    public class EvaluationChecklist
    {
        public Guid Id { get; set; }
        public Guid? RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        [ValidateNever]
        public Register? Register { get; set; }
        public bool est_name_ck { get; set; }
        public bool est_type_ck { get; set; }
        public bool est_legalorg_ck { get; set; }
        public bool est_adress_ck { get; set; }
        public bool est_barangay_ck { get; set; }
        public bool est_citymun_ck { get; set; }
        public bool est_province_ck { get; set; }
        public bool est_region_ck { get; set; }
        public bool est_manag_first_ck { get; set; }
        public bool est_manag_mid_ck { get; set; }
        public bool est_manag_last_ck { get; set; }
        public bool est_regdate_ck { get; set; }
        public bool est_bus_nature_ck { get; set; }
        public bool est_bnature_oth_ck { get; set; }
        public bool est_cur_cap_ck { get; set; }
        public bool est_total_asset_ck { get; set; }
        public bool est_contact_ck { get; set; }
        public bool est_tin_ck { get; set; }
        public bool est_email_ck { get; set; }
        public bool est_malenum_ck { get; set; }
        public bool est_femalenum_ck { get; set; }
        public bool est_totalemploy_ck { get; set; }
        public bool est_techinfo1_ck { get; set; }
        public bool est_techinfooth1_ck { get; set; }
        public bool est_techinfo2_ck { get; set; }
        public bool est_techinfooth2_ck { get; set; }
        public bool est_chemsub_ck { get; set; }
        public bool est_sec_number_ck { get; set; }
        public bool est_sec_dateiss_ck { get; set; }
        public bool est_sec_permit_ck { get; set; }
        public bool est_peza_ck { get; set; }
        public bool est_bperm_number_ck { get; set; }
        public bool est_bperm_dateiss_ck { get; set; }
        public bool est_bperm_validity_ck { get; set; }
        public bool est_bus_perm_ck { get; set; }
        public bool est_valid_number_ck { get; set; }
        public bool est_valid_dateiss_ck { get; set; }
        public bool est_valid_validity_ck { get; set; }
        public bool est_termrep_ck { get; set; }
    }
}