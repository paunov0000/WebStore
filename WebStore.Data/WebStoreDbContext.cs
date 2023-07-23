using AspNetCoreTemplate.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebStore.Data
{
    public class WebStoreDbContext : IdentityDbContext
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<IndividualProduct> IndividualProducts { get; set; } = null!;

        public DbSet<SubCategory> SubCategories { get; set; } = null!;
    }
}