using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asprule1020.Models
{
    [Table("tbl_psgc_provdist")]
    public class PhProvDist
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("psgc_reg")]
        public string? PsgcReg { get; set; }

        [Column("region")]
        public string? Region { get; set; }

        [Column("psgc_provdist")]
        public string? PsgcProvDist { get; set; }

        [Column("province_district")]
        public string? ProvinceDistrict { get; set; }

        [Column("geographic_level")]
        public string? GeographicLevel { get; set; }

        [Column("old_name")]
        public string? OldName { get; set; }
    }
}
