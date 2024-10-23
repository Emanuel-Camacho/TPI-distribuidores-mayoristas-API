﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public ProductDbContext() { }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
    }
}