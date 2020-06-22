using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Contracts;
using TB_Collection.Models;

namespace TB_Collection.Data
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Item GetItem(int itemId) => FindByCondition(i => i.ItemId.Equals(itemId)).SingleOrDefault();

        public void CreateItem(Item item) => Create(item);
    }
}
