using Repository.CRUDHQ;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class CollectorWishlistRepository : RepositoryBase<CollectorWishlist>, ICollectorWishlistRepository
    {
        public CollectorWishlistRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
