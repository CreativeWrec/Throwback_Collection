using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TB_Collection.Models;

namespace TB_Collection.Contracts
{
    public interface ICollectorRepository : IRepositoryBase<Collector>
    {
        Collector GetCollector(int collectorId);
        void CreateCollector(Collector collector);
    }
}
