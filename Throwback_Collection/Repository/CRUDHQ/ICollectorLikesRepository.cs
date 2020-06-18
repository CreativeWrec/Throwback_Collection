using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.CRUDHQ
{
    public interface ICollectorLikesRepository : IRepositoryBase<CollectorLikes>
    {
        CollectorLikes GetCollectorLikes(int collectorId, int itemId);
        void CreateCollectorLikes(CollectorLikes collectorLikes);
    }
}
