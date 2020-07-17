using CPRG214.Vani.AssetTracker.Data;
using CPRG214.Vani.AssetTracker.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPRG214.Vani.AssetTracker.BLL
{
   public class AssetTypeManager
    {
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetContext();
            var types = context.AssetTypes.Select(type => new
            {
                Value = type.Id,
                Text = type.Name
            }).ToList();
            return types;
        }

        public static List<AssetType> GetAll()
        {
            var context = new AssetContext();
            var types = context.AssetTypes.OrderBy(p => p.Name).ToList();
            return types;
        }

        public static void Add(AssetType assetType)
        {
            var context = new AssetContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }

    }

    
}
