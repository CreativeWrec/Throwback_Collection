﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Contracts;
using TB_Collection.Models;

namespace TB_Collection.Data
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
