using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace HoxroAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [ResponseCache(Duration = 1000)]
        [HttpGet("api/GetAllItem", Name = "GetAllItem")]
        public ActionResult<IEnumerable<Item>> GetAllItem()
        {
            return _itemService.GetItems().ToList();
        }
    }
}