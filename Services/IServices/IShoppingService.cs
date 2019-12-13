using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IShoppingService
    {
        void AddShopping(Shopping model);

        void UpdateShopping(Shopping model);

        void AddShoppingItem(ShoppingItem model);

        Shopping GetShoppingById(long id);

        IEnumerable<Shopping> GetShoppingList();

        IEnumerable<ShoppingItem> GetShoppingItemListById(long Id);

        void RemoveShoppingItem(ShoppingItem model);
    }
}
