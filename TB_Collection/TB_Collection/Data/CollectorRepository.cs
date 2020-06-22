using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Contracts;
using TB_Collection.Models;

namespace TB_Collection.Data
{
    public class CollectorRepository : RepositoryBase<Collector>, ICollectorRepository
    {
        public CollectorRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

        public Collector GetCollector(int collectorId) => FindByCondition(c => c.CollectorId.Equals(collectorId)).SingleOrDefault();

        public void CreateCollector(Collector collector) => Create(collector);
    }
}
