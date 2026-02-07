using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asprule1020.Models
{
    public class Register
    {
        [Key]
        [Required]
        public string transId { get; set; }
        [Required]
        public string rule1020Id { get; set; }
        [Required]
        public string userName { get; set; } 

        [Required, EmailAddress]
        [MaxLength(50)]
        public string estEmail { get; set; } 

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Mobile number must be 11 digits")]
        public string estPhone { get; set; } 

        [Required]
        public string password { get; set; } 

        [Required]
        public string estName { get; set; } 

        [Required]
        public string estType { get; set; } 

        [Required]
        public string estLegalOrg { get; set; } 
        public string? estLegalOrgOther { get; set; }
        [Required]
        public string estRegion { get; set; } 
        [Required]
        public string estProvince { get; set; } 
        [Required]
        public string estCityMun { get; set; } 
        [Required]
        public string estBrgy { get; set; } 
        [Required]
        [MaxLength(150)]
        public string estStreet { get; set; } 
        [Required]
        [MaxLength(50)]
        public string estOwnerFirst { get; set; } 
        [MaxLength(50)]
        public string? estOwnerMid { get; set; }
        [Required]
        [MaxLength(50)]
        public string estOwnerLast { get; set; } 
        [Required]
        public string estCurrentCap { get; set; } 
        [Required]
        public string estTotalAssets { get; set; } 
        [Required]
        public string estBusinessNature { get; set; } 
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provide Valid Business Nature")]
        public string? estOtherBusNature { get; set; }
        [Required]
        public int estMaleCount { get; set; }
        [Required]
        public int estFemaleCount { get; set; }
        public int estTotalEmployees { get; set; }
        public List<string>? estTechInfo1 { get; set; }
        public string? estTechInfo1Other { get; set; }
        public List<string>? estTechInfo2 { get; set; } 
        public string? estTechInfo2Other { get; set; }
        [Required]
        public string estChemSubstance { get; set; } 
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "SEC Company Registration Number / DTI Business Name No. must be between 5 and 50 characters")]
        public string estSECNumber { get; set; } 
        [Required]
        public DateTime? estSECDateIssued { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Business or Mayor's Permit must be between 3 and 50 characters")]
        public string estBisPermitNumber { get; set; } 
        public DateTime? estBisPermitDateIssued { get; set; }
        public DateTime? estBisPermitValidityDate { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Business or Mayor's Permit must be between 3 and 50 characters")]
        public string estOwnerValidIDNumber { get; set; } 
        [MaxLength(50)]
        public DateTime? estOwnerValidIDDateIssued { get; set; }
        public DateTime? estOwnerValidIDDateExpire { get; set; }
        public DateTime? estOwnerValidIDDate { get; set; }
        [Required]
        public string estSECFile { get; set; }
        [Required]
        public string estBisPermitFile { get; set; }
        [Required]
        public string estOwnerValidIDFile { get; set; }
        public string estEvalName { get; set; }
        public DateTime estEvalDate { get; set; }
        public string estEvalRemarks { get; set; } 
        public string estPoHeadName { get; set; } 
        public string estPoHeadEvalDate { get; set; } 
        public string estPoHeadRemarks{ get; set; } 
        public string estEvalEmailSendStatus{ get; set; } 
        public DateTime estReopeningDate { get; set; }
        public string estReasonForUpdate { get; set; } = string.Empty;
        public bool estIsUpdating { get; set; } = false; 
        public bool estIsEmailApprovedSent { get; set; } = false;
        public DateTime estEmailApprovedSentDate { get; set; }
        public bool estIsEmailReapplicationSent { get; set; } = true;
        public DateTime estEmailReapplicationSentDate { get; set; }
        public string estEvalAssinged { get; set; } = "Evaluator";
        public string estStatus { get; set; } = "For Review";
        public DateTime estRegistrationDate { get; set; } = DateTime.Now;

    }
}

