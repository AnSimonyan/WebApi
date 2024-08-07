﻿using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Entities;

namespace WebApi.Domain
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        

    }
}
