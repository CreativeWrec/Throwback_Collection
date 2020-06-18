using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.CRUDHQ
{
    public interface ICollectorRepository : IRepositoryBase<Collector>
    {
        Collector GetCollector(int CollectorId);
        void CreateCollector(Collector collector);
    }
}
