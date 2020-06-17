using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Collector> Collectors {get; set; }
        public DbSet<CollectionObj> Collections  {get; set; }
        public DbSet<Item> Items {get; set; }
        public DbSet<CollectorWishlist> Wishlists {get; set; }
    }

}
