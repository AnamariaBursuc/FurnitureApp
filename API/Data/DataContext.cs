using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users {get;set;}
         public DbSet<Client> Clients {get;set;}
          public DbSet<Invoice> Invoices {get;set;}
           public DbSet<InvoiceItem> InvoiceItems {get;set;}
    }
}