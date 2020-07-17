using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPRG214.Vani.AssetTracker.Domain
{
    [Table("Asset")]
    public class Asset
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Tag Number")]
        public string TagNo { get; set; }
        [Required]
        [Display(Name = "Asset Type")]
        public int AssetTypeId { get; set; } //FK
        [Required]
        public string Manufacturer { get; set; }
        
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name ="Serial Number")]
        public string SNo { get; set; }

        //navigation property 
        public AssetType AssetType { get; set; }

       

    }
}
