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
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingService _shoppingService;
        public ShoppingController(IShoppingService shoppingService)
        {
            _shoppingService = shoppingService;
        }

        [HttpGet("api/GetShopping", Name = "GetShopping")]
        public ActionResult<Shopping> GetShopping(long id)
        {
            return _shoppingService.GetShoppingById(id);
        }

        [HttpGet("api/GetAllShopping", Name = "GetAllShopping")]
        public ActionResult<IEnumerable<Shopping>> GetAllShopping()
        {
            return _shoppingService.GetShoppingList().ToList();
        }

        [HttpGet("api/GetAllShoppingItemById", Name = "GetAllShoppingItemById")]
        public ActionResult<IEnumerable<Item>> GetAllShoppingItemById(long id)
        {
            return _shoppingService.GetShoppingItemListById(id).Select(m=>m.Item).ToList();
        }

        [HttpPost("api/AddShoppingItem", Name = "AddShoppingItem")]
        public ActionResult AddShoppingItem(ShoppingItem model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _shoppingService.AddShoppingItem(model);
            return new OkObjectResult("");
        }

        [HttpPost("api/DeleteShoppingItem", Name = "DeleteShoppingItem")]
        public ActionResult DeleteShoppingItem(ShoppingItem model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _shoppingService.RemoveShoppingItem(model);
            return new OkObjectResult("");
        }

        [HttpPost("api/AddShopping", Name = "AddShopping")]
        public ActionResult<IEnumerable<Shopping>> AddShopping(Shopping model)
        {
            if(ModelState.IsValid)
            {
                _shoppingService.AddShopping(model);
            }
            return _shoppingService.GetShoppingList().ToList();
        }

        [HttpPost("api/UpdateShopping", Name = "UpdateShopping")]
        public ActionResult<IEnumerable<Shopping>> UpdateShopping(Shopping model)
        {
            if (ModelState.IsValid)
            {
                _shoppingService.UpdateShopping(model);
            }
            return new OkObjectResult("");
        }
    }
}