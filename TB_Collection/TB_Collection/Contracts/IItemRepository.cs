using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Data;
using TB_Collection.Models;

namespace TB_Collection.Contracts
{
    public interface IItemRepository : IRepositoryBase<Item>
    {
        Item GetItem(int item);
        void CreateItem(Item item);
    }
}
