using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoplist.Domain;
using Shoplist.Infrastructure.DTO;
using Shoplist.Infrastructure.Item;

namespace Shoplist.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemCrud itemCrud;   
        public ItemController(IItemCrud itemCrud)
        {
            this.itemCrud = itemCrud;
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var item = await itemCrud.GetItemFromId(id);
                await itemCrud.Delete(item);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody]ItemDto item)
        {
            try
            {
                await itemCrud.Create(item);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
