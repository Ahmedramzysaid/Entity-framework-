using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominLayer.Models;
using Microsoft.EntityFrameworkCore; // FIX: Use correct namespace for DbContext

namespace DominLayer.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS04;Database=BookStore;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        DbSet<Book>Books { get; set; }
        DbSet<Author>Authors { get; set; }
        DbSet<Category> Categories { get ; set; }   
    }
}
