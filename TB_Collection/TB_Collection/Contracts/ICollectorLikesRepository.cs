using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Models;

namespace TB_Collection.Contracts
{
    public interface ICollectorLikesRepository : IRepositoryBase<CollectorLikes>
    {
        CollectorLikes GetCollectorLikes(int collectorId, int itemId);
        void CreateCollectorLikes(CollectorLikes collectorLikes);
    }
}
