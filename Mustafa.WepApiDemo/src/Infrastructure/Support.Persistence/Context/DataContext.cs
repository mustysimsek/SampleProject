using Microsoft.EntityFrameworkCore;
using Support.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.Persistence.Context
{
    public class DataContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=TECHLPT38\SQLEXPRESS;Integrated Security=True;Database=Northwind");
        //}

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Productnew> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
