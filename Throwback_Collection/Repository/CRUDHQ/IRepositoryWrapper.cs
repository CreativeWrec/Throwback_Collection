using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.CRUDHQ
{
    public interface IRepositoryWrapper
    {
        ICollectorCollectionRepository CollectorCollection { get; }
        ICollectorLikesRepository CollectorLikes { get; }
        ICollectorRepository Collector { get; }
        ICollectorWishlistRepository CollectorWishlist { get; }
        IItemRepository Item { get;}
        void Save();
    }
}
