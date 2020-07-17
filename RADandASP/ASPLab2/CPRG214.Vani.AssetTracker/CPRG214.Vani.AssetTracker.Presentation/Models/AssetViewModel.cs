using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CPRG214.Vani.AssetTracker.Presentation.Models
{
    public class AssetViewModel
    {

        public string Id { get; set; }       
        
        [Display(Name ="Tag Number")]
        public string TagNo { get; set; }
        
        [Display(Name ="Asset Type")]
        public string AssetType { get; set; }        
        public string Manufacturer { get; set; }
        public string Model { get; set; }        
        public string Description { get; set; }
       [Display(Name ="Serial Number")]
        public string SNo { get; set; }
    }
}
