using Microsoft.EntityFrameworkCore;
using MyContact.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base(GetOptions("Server = .; Initial Catalog = ContactDb ; Integrated Security = true; Trusted_Connection = true; Encrypt = false;"))
        {
            
        }
        private static DbContextOptions GetOptions(string connectionStrings)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionStrings).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Number>().HasKey(x => new { x.UserId, x.ContactId });
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Number> Numbers{ get; set; }

    }
}
