using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SearchSaver.Data
{
    public class ServiceDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }

        public ServiceDbContext(DbContextOptions<ServiceDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(et => new { et.Id });

            base.OnModelCreating(modelBuilder);
        }
    }
}
