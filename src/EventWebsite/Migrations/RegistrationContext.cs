using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventWebsite.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace EventWebsite.Migrations
{
    public class RegistrationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}
