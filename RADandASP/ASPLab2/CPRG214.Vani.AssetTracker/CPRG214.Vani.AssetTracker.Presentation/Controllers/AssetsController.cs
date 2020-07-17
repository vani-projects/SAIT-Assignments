using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214.Vani.AssetTracker.BLL;
using CPRG214.Vani.AssetTracker.Domain;
using CPRG214.Vani.AssetTracker.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPRG214.Vani.AssetTracker.Presentation.Controllers
{
    public class AssetsController : Controller
    {
        public IActionResult Index()
        {
            var assets = AssetManager.GetAll();
            return View(assets);
        }

        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType", id);
        }

        public IActionResult Search()
        {
            ViewBag.AssetTypes = GetAssetTypes();
            return View();
        }

       //create asset
        public IActionResult Create()
        {
            var types = AssetTypeManager.GetAsKeyValuePairs();
            var list = new SelectList(types, "Value", "Text");
            ViewBag.TypeId = list;
            ViewBag.AssetTypeId = GetAssetTypes();
            return View();

        }

        [HttpPost]
        public IActionResult Create(Asset asset)
        {
            try
            {
                AssetManager.AddAsset(asset);
                return RedirectToAction("Search");
            }
            catch
            {
                return View();
            }            
        }

        protected IEnumerable GetAssetTypes()
        {
            //create the collection of asset types select list items
            var types = AssetTypeManager.GetAsKeyValuePairs();
            var names = new SelectList(types, "Value", "Text");
            var list = names.ToList(); // to get all types on dropdown and get all the assets on viewcomponent 
            list.Insert(0, new SelectListItem   // to add with index of zero i.e specified index use insert instead of add
            {
                Text = "All Asset Types",
                Value = "0"
            });
            return list;
        }

    }
}