using Repository.CRUDHQ;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class CollectorCollectionRepository : RepositoryBase<CollectionObj>, ICollectorCollectionRepository 
    {
        public CollectorCollectionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
