using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.CRUDHQ
{
    public interface ICollectorCollectionRepository : IRepositoryBase<CollectionObj>
    {
        CollectionObj GetCollectionObj(int collectorId, int itemId);
        void CreateCollectorCollection(CollectionObj collectionObj);
    }
}
