using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Models;

namespace TB_Collection.Contracts
{
    public interface ICollectorCollectionRepository : IRepositoryBase<CollectionObj>
    {
        CollectionObj GetCollectionObj(int collectorId, int itemId);
        void CreateCollectorCollection(CollectionObj collectionObj);
    }
}
