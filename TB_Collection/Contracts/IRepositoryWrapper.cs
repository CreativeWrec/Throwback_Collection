using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TB_Collection.Contracts
{
    public interface IRepositoryWrapper
    {
        ICollectorCollectionRepository CollectorCollection { get; }
        ICollectorLikesRepository CollectorLikes { get; }
        ICollectorRepository Collector { get; }
        ICollectorWishlistRepository CollectorWishlist { get; }
        IItemRepository Item { get; }
        void Save();
    }
}
