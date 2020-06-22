﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Contracts;
using TB_Collection.Models;

namespace TB_Collection.Data
{
    public class CollectorCollectionRepository : RepositoryBase<CollectionObj>, ICollectorCollectionRepository
    {
        public CollectorCollectionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public CollectionObj GetCollectionObj(int collectorId, int itemId) => FindByCondition(c => c.CollectorId.Equals(collectorId) && c.ItemId.Equals(itemId)).SingleOrDefault();

        public void CreateCollectorCollection(CollectionObj collectionObj) => Create(collectionObj);
    }
}
