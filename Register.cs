using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace asprule1020.Models
{
    public class Register
    {
        [Required]
        public string userName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string estEmail { get; set; } = string.Empty;

        [Required]
        public string estPhone { get; set; } = string.Empty;

        [Required]
        public string password { get; set; } = string.Empty;

        [Required]
        public string estName { get; set; } = string.Empty;

        [Required]
        public string estType { get; set; } = string.Empty;

        [Required]
        public string estLegalOrg { get; set; } = string.Empty;

        public string? estLegalOrgOther { get; set; }

        [Required]
        public string estRegion { get; set; } = string.Empty;

        [Required]
        public string estProvince { get; set; } = string.Empty;

        [Required]
        public string estCityMun { get; set; } = string.Empty;

        [Required]
        public string estBrgy { get; set; } = string.Empty;

        [Required]
        public string estStreet { get; set; } = string.Empty;

        [Required]
        public string estOwnerFirst { get; set; } = string.Empty;

        public string? estOwnerMid { get; set; }

        [Required]
        public string estOwnerLast { get; set; } = string.Empty;

        [Required]
        public string estCurrentCap { get; set; } = string.Empty;

        [Required]
        public string estTotalAssets { get; set; } = string.Empty;

        [Required]
        public string estBusinessNature { get; set; } = string.Empty;

        public string? estOtherBusNature { get; set; }

        public int? estMaleCount { get; set; }

        public int? estFemaleCount { get; set; }

        public int? estTotalEmployees { get; set; }

        public List<string>? estTechInfo1 { get; set; }

        public string? estTechInfo1Other { get; set; }

        public List<string>? estTechInfo2 { get; set; } 

        public string? estTechInfo2Other { get; set; }

        [Required]
        public string estChemSubstance { get; set; } = string.Empty;

        [Required]
        public string estSECNumber { get; set; } = string.Empty;

        public DateTime? estSECDateIssued { get; set; }

        [Required]
        public string estBisPermitNumber { get; set; } = string.Empty;

        public DateTime? estBisPermitDateIssued { get; set; }

        public DateTime? estBisPermitValidityDate { get; set; }

        [Required]
        public string estOwnerValidIDNumber { get; set; } = string.Empty;

        public DateTime? estOwnerValidIDDateIssued { get; set; }

        public DateTime? estOwnerValidIDDateExpire { get; set; }

        public DateTime? estOwnerValidIDDate { get; set; }

        public string estSECFile { get; set; } = string.Empty;
        public string estBisPermitFile { get; set; } = string.Empty;
        public string estOwnerValidIDFile { get; set; } = string.Empty;

    }
}

