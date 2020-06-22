using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Models;

namespace TB_Collection.Contracts
{
    public interface ICollectorWishlistRepository : IRepositoryBase<CollectorWishlist>
    {
        CollectorWishlist GetCollectorWishlist(int collectorId, int itemId);
        void CreateCollectorWishlist(CollectorWishlist collectorWishlist);
    }
}
