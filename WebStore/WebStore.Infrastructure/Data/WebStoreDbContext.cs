﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.MVC.Data
{
    public class WebStoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Order> Orders { get; set; }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Review> Reviews { get; set; }


    }
}
