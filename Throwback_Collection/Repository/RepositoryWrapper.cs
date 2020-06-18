using Repository.CRUDHQ;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private ICollectorRepository _collector;
        private ICollectorCollectionRepository _collectorCollection;
        private ICollectorLikesRepository _collectorLikes;
        private ICollectorWishlistRepository _collectorWishlist;
        private IItemRepository _item;
        
        public ICollectorRepository Collector
        {
            get
            {
                if (_collector == null)
                {
                    _collector = new CollectorRepository(_context);
                }
                return _collector;
            }
        }
        public ICollectorCollectionRepository CollectorCollection
        {
            get
            {
                if (_collectorCollection == null)
                {
                    _collectorCollection = new CollectorCollectionRepository(_context);
                }
                return _collectorCollection;
            }
        }
        public ICollectorLikesRepository CollectorLikes
        {
            get
            {
                if(_collectorLikes == null)
                {
                    _collectorLikes = new CollectorLikesRepository(_context);
                }
                return _collectorLikes;
            }
        }
        public ICollectorWishlistRepository CollectorWishlist
        {
            get
            {
                if(_collectorWishlist == null)
                {
                    _collectorWishlist = new CollectorWishlistRepository(_context);
                }
                return _collectorWishlist;
            }
        }
        public IItemRepository Item
        {
            get
            {
                if(_item == null)
                {
                    _item = new ItemRepository(_context);
                }
                return _item;
            }
        }
        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }   
}
