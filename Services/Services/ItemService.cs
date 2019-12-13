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
    public class ItemService : IItemService
    {
        private readonly IGenericRepository<Item> _genericItemRepo;
        public ItemService(IGenericRepository<Item> genericRepository)
        {
            _genericItemRepo = genericRepository;
        }
        public IEnumerable<Item> GetItems()
        {
            return _genericItemRepo.Get();
        }
    }
}
