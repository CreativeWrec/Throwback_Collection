using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TB_Collection.Models;

namespace TB_Collection.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CollectionObj>().HasKey(o => new { o.CollectorId, o.ItemId });
            builder.Entity<CollectorWishlist>().HasKey(w => new { w.CollectorId, w.ItemId });
            builder.Entity<CollectorLikes>().HasKey(l => new { l.CollectorId, l.ItemId });
        }
        public DbSet<Collector> Collectors { get; set; }
        public DbSet<CollectionObj> Collections { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CollectorWishlist> Wishlists { get; set; }
        public DbSet<CollectorLikes> CollectorLikes { get; set; }
    }
}
