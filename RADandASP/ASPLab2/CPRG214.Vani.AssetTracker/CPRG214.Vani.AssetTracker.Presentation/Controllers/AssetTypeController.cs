using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214.Vani.AssetTracker.BLL;
using CPRG214.Vani.AssetTracker.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CPRG214.Vani.AssetTracker.Presentation.Controllers
{
    public class AssetTypeController : Controller
    {
        public IActionResult Index()
        {
            var assets = AssetTypeManager.GetAll();
            return View(assets);
        }

        public IActionResult Create()
        {
           
            return View();

        }

        [HttpPost]
        public IActionResult Create(AssetType assetType)
        {
            try
            {
                // TODO: Add insert logic here for Owner
                AssetTypeManager.Add(assetType);

                return RedirectToAction("Search", "Assets");
            }
            catch
            {
                return View();
            }
        }

    }
}