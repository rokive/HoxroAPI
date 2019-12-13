using Entity.Models;
using Repositories.Repositories;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly IGenericRepository<Shopping> _genericShoppingRepo;
        private readonly IGenericRepository<ShoppingItem> _genericShoppingItemRepo;

        public ShoppingService(IGenericRepository<Shopping> genericShoppingRepo, IGenericRepository<ShoppingItem> genericShoppingItemRepo)
        {
            _genericShoppingRepo = genericShoppingRepo;
            _genericShoppingItemRepo = genericShoppingItemRepo;
        }

        public void AddShopping(Shopping model)
        {
            _genericShoppingRepo.Create(model);
            _genericShoppingRepo.Save();
        }

        public void AddShoppingItem(ShoppingItem model)
        {
            _genericShoppingItemRepo.Create(model);
            _genericShoppingItemRepo.Save();
        }

        public Shopping GetShoppingById(long id)
        {
           return _genericShoppingRepo.GetById(id);
        }

        public IEnumerable<ShoppingItem> GetShoppingItemListById(long id)
        {
            return _genericShoppingItemRepo.Get(m => m.ShoppingId == id, null, "Item");
        }

        public IEnumerable<Shopping> GetShoppingList()
        {
           return _genericShoppingRepo.Get();
        }

        public void RemoveShoppingItem(ShoppingItem model)
        {
            ShoppingItem shoppingItem = _genericShoppingItemRepo.Get(m=>m.ItemId==model.ItemId&&m.ShoppingId==model.ShoppingId).FirstOrDefault();
            _genericShoppingItemRepo.Delete(shoppingItem);
            _genericShoppingItemRepo.Save();
        }

        public void UpdateShopping(Shopping model)
        {
            Shopping updateShopping = _genericShoppingRepo.GetById(model.Id);
            updateShopping.Name = model.Name;
            _genericShoppingRepo.Update(updateShopping);
            _genericShoppingRepo.Save();
        }
    }
}
