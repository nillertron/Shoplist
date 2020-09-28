using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoplist.Domain;
using Shoplist.Infrastructure.DTO;
using Shoplist.Infrastructure.GroceryList;

namespace Shoplist.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroceryListController : ControllerBase
    {
        private readonly IGrocerylistCRUD grocerylistCRUD;
        public GroceryListController(IGrocerylistCRUD grocerylistCRUD)
        {
            this.grocerylistCRUD = grocerylistCRUD;
        }
        [HttpGet("GetSingle")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var obj = await grocerylistCRUD.GetListFromId(id);
                return Ok(obj);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(GroceryListDto list)
        {
            try
            {
                await grocerylistCRUD.Create(list);
                return Ok(list);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
