using Microsoft.Data.Entity;
using System;
using Microsoft.Data.Entity.Metadata;
using EventWebsite.Models;
using Microsoft.Data.Entity.Infrastructure;

namespace EventWebsite.Migrations
{
    public class RegistrationContext : DbContext
    {
        private static bool _created = false;

        public DbSet<Registration> Registrations { get; set; }

        public RegistrationContext()
        {
            if (!_created)
            {
                Database.EnsureCreated();
                _created = true;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
        }
    }
}
