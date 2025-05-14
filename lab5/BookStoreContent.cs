
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab5.Form1;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors {get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Define the connection string here
            optionsBuilder.UseSqlServer("Server=your_server_name;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}