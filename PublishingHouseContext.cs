using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PublishingHousedop2;
namespace PublishingHousedop2
{
    public class PublishingHouseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-4PCU5RA\\SQLEXPRESS;Database=Publishing;Trusted_Connection=True;TrustServerCertificate=True;");
                optionsBuilder.LogTo(e => Debug.WriteLine(e), new[] { RelationalEventId.CommandExecuted });
            }
        }

    }


    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
