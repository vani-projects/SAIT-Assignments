using CPRG214.Vani.AssetTracker.Data;
using CPRG214.Vani.AssetTracker.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace CPRG214.Vani.AssetTracker.BLL
{
    public class AssetManager
    {
        //get all assets
        public static List<Asset> GetAll()
        {
            var context = new AssetContext();
            var assets = context.Assets.
                Include(a => a.AssetType).ToList(); // include statements to get nested assetType
            return assets;
        }

        //insert new asset record to db
        public static void AddAsset(Asset asset)
        {
            var context = new AssetContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }

        //get all assets of a assettype 
        public async static Task<List<Asset>> GetAllByAssetType(int id)
        {
            var context = new AssetContext();
            var assets = await context.Assets.
                Where(a => a.AssetTypeId == id).
                Include(a => a.AssetType).ToListAsync(); // include statements to get nested assetType
            return assets;
        }
    }
}
