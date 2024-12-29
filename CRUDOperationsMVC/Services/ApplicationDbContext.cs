﻿using CRUDOperationsMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperationsMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
