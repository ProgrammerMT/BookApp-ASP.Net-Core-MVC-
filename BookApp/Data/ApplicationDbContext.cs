using Microsoft.EntityFrameworkCore;
using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
