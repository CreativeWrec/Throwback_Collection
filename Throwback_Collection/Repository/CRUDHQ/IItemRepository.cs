using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.CRUDHQ
{
    public interface IItemRepository : IRepositoryBase<Item>
    {
        Item GetItem(int itemId);
        void CreateItem(Item item);
    }
}
