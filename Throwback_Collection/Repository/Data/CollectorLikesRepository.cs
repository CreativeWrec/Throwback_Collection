using Repository.CRUDHQ;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class CollectorLikesRepository : RepositoryBase<CollectorLikes>, ICollectorLikesRepository
    {
        public CollectorLikesRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        
        public Collec
    }
}
