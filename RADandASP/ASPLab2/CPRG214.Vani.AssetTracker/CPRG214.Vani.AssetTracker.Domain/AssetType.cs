using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CPRG214.Vani.AssetTracker.Domain
{
    [Table("AssetType")]
   public class AssetType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Asset> Assets { get; set; }
    }
}
