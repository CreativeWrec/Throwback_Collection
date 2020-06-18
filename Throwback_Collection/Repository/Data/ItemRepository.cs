using Repository.CRUDHQ;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext applicationDbContext) :base(applicationDbContext)
        { 
        }

        public Item GetItem(int itemId) => FindByCondition(i => i.ItemId.Equals(itemId)).SingleOrDefault();

        public void CreateItem(Item item) => Create(item);
    }
}
