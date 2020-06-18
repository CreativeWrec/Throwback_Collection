using Repository.CRUDHQ;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class CollectorLikesRepository : RepositoryBase<CollectorLikes>, ICollectorLikesRepository
    {
        public CollectorLikesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public CollectorLikes GetCollectorLikes(int collectorId, int itemId) => FindByCondition(l => l.CollectorId.Equals(collectorId) && l.ItemId.Equals(itemId)).SingleOrDefault();

        public void CreateCollectorLikes(CollectorLikes collectorLikes) => Create(collectorLikes);
    }
}
