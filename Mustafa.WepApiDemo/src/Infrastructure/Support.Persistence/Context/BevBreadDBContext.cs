using Microsoft.EntityFrameworkCore;
using Support.Domain.Entities;

namespace Support.Persistence.Context
{
    public class BevBreadDBContext : DbContext
    {
        public BevBreadDBContext(DbContextOptions<BevBreadDBContext> options) : base(options)
        {

        }
        public DbSet<Product> STProduct { get; set; }
        public DbSet<ProductVariant> STProductVariant { get; set; }
        public DbSet<BranchProductRelation> STBranchProductRelation { get; set; }
        public DbSet<Branch> STBranch { get; set; }
        public DbSet<ProductCategory> MTProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-To-One
            modelBuilder.Entity<Product>().HasOne(x => x.ProductCategory).WithOne(x => x.Product)
                .HasForeignKey<Product>(x => x.FKCategoryId);

            //One-To-Many
            modelBuilder.Entity<Product>().HasMany(x => x.ProductVariants).WithOne(x => x.Product)
                .HasForeignKey(x => x.FKProductId);

            //Many-To-Many
            modelBuilder.Entity<BranchProductRelation>().HasKey(x => new { x.FKProductId, x.FKBranchId });

            modelBuilder.Entity<Product>().HasMany(x=>x.BranchProductRelations).WithOne(x => x.Product)
                .HasForeignKey(x=>x.FKProductId);
            modelBuilder.Entity<Branch>().HasMany(x => x.BranchProductRelations).WithOne(x => x.Branch)
                .HasForeignKey(x => x.FKBranchId);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
