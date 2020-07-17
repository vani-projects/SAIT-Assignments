using CPRG214.Vani.AssetTracker.BLL;
using CPRG214.Vani.AssetTracker.Domain;
using CPRG214.Vani.AssetTracker.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Author:Shravani
/// Date:May,2020
/// </summary>

namespace CPRG214.Vani.AssetTracker.Presentation.ViewComponents
{
    public class AssetsByTypeViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Asset> assets = null;
            if(id == 0)
            {
                assets =  AssetManager.GetAll();
            }
            else
            {
                assets = await AssetManager.GetAllByAssetType(id); //filter and get data async
            }
            //transform collection of assets to collection of assetViewModel.both are same but are of different type.
            var assetList = assets.Select(a => new AssetViewModel
            {
                Description = a.Description,
                AssetType = a.AssetType.Name,
                TagNo = a.TagNo,
                SNo = a.SNo
            }).ToList();
            return View(assetList);
        }
    }
}
