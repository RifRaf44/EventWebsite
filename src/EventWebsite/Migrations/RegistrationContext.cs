using Microsoft.Data.Entity;
using System;
using Microsoft.Data.Entity.Metadata;
using EventWebsite.Models;
using Microsoft.Data.Entity.Infrastructure;

namespace EventWebsite.Migrations
{
    public class RegistrationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
        }
    }
}
