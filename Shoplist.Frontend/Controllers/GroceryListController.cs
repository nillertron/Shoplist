using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shoplist.Frontend.Models;
using Shoplist.Infrastructure.GroceryList;

namespace Shoplist.Frontend.Controllers
{
    public class GroceryListController : Controller
    {
        private readonly IGrocerylistCRUD grocerylistCRUD;
        public GroceryListController(IGrocerylistCRUD grocerylistCRUD)
        {
            this.grocerylistCRUD = grocerylistCRUD;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult>Search(int id)
        {
            var dto = await grocerylistCRUD.GetListFromId(id);
            if (dto == null)
            {
                ModelState.AddModelError(string.Empty, "Not found");
                return View("Index");
            }
            return View("Details",dto);
        }
    }
}
