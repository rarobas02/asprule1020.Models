using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asprule1020.Models
{
    public class Register : IdentityUser
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string TransId { get; set; }
        public string? Rule1020Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Mobile number must be 11 digits")]
        public string EstPhone { get; set; } 

        //[Required]
        //public string password { get; set; } 

        [Required]
        public string EstName { get; set; } 

        [Required]
        public string EstType { get; set; } 

        [Required]
        public string EstLegalOrg { get; set; } 
        public string? EstLegalOrgOther { get; set; }
        [Required]
        public string EstRegion { get; set; } 
        [Required]
        public string EstProvince { get; set; } 
        [Required]
        public string EstCityMun { get; set; } 
        [Required]
        public string EstBrgy { get; set; } 
        [Required]
        public string EstStreet { get; set; } 
        [Required]
        [MaxLength(50)]
        public string EstOwnerFirst { get; set; } 
        [MaxLength(50)]
        public string? EstOwnerMid { get; set; }
        [Required]
        [MaxLength(50)]
        public string EstOwnerLast { get; set; } 
        [Required]
        public string EstCurrentCap { get; set; } 
        [Required]
        public string EstTotalAssets { get; set; } 
        [Required]
        public string EstBusinessNature { get; set; } 
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provide Valid Business Nature")]
        public string? EstOtherBusNature { get; set; }
        [Required]
        public int EstMaleCount { get; set; }
        [Required]
        public int EstFemaleCount { get; set; }
        public int EstTotalEmployees { get; set; }
        public List<string>? EstTechInfo1 { get; set; }
        public string? EstTechInfo1Other { get; set; }
        public List<string>? EstTechInfo2 { get; set; }
        public string? EstTechInfo2Other { get; set; }
        [Required]
        public string EstChemSubstance { get; set; } 
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "SEC Company Registration Number / DTI Business Name No. must be between 5 and 50 characters")]
        public string EstSECNumber { get; set; } 
        [Required]
        public DateTime? EstSECDateIssued { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Business or Mayor's Permit must be between 3 and 50 characters")]
        public string EstBisPermitNumber { get; set; }
        public string EstIsPeza { get; set; }
        public DateTime? EstBisPermitDateIssued { get; set; }
        public DateTime? EstBisPermitValidityDate { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Business or Mayor's Permit must be between 3 and 50 characters")]
        public string EstOwnerValidIDNumber { get; set; } 
        [MaxLength(50)]
        public DateTime? EstOwnerValidIDDateIssued { get; set; }
        public DateTime? EstOwnerValidIDDateExpire { get; set; }
        public DateTime? EstOwnerValidIDDate { get; set; }
        [Required]
        public string EstSECFile { get; set; }
        [Required]
        public string EstBisPermitFile { get; set; }
        [Required]
        public string EstOwnerValidIDFile { get; set; }
        public string? EstEvalName { get; set; }
        public DateTime? EstEvalDate { get; set; }
        public string? EstEvalRemarks { get; set; } 
        public string? EstPoHeadName { get; set; } 
        public string? EstPoHeadEvalDate { get; set; } 
        public string? EstPoHeadRemarks { get; set; } 
        public string? EstEvalEmailSendStatus { get; set; } 
        public DateTime? EstReopeningDate { get; set; }
        public string? EstReasonForUpdate { get; set; } = string.Empty;
        public bool? EstIsUpdating { get; set; } = false; 
        public bool? EstIsEmailApprovedSent { get; set; } = false;
        public DateTime EstEmailApprovedSentDate { get; set; }
        public bool? EstIsEmailReapplicationSent { get; set; } = true;
        public DateTime? EstEmailReapplicationSentDate { get; set; }
        public string? EstEvalAssinged { get; set; } = "Evaluator";
        public string EstStatus { get; set; } = "For Review";
        public DateTime EstRegistrationDate { get; set; } = DateTime.Now;

    }
}

