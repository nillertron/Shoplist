using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shoplist.Frontend.Models
{
    public class GroceryListViewModel
    {
        [Required]
        public int Id { get; set; }
    }
}
