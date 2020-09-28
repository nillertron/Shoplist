using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shoplist.Infrastructure.DTO;
using Shoplist.Infrastructure.Item;

namespace Shoplist.Frontend.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemCrud itemCrud;
        public ItemController(IItemCrud itemCrud)
        {
            this.itemCrud = itemCrud;
        }
        [HttpPost]
        public async Task<IActionResult> Create(ItemDto model)
        {
            try
            {
                await itemCrud.Create(model);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await itemCrud.Delete(new ItemDto(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
