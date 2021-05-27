using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DocFinder.Data.Models;

namespace DocFinder.Data.Context
{
    public class DocFinderContext : DbContext
    {
        public DbSet<FileDoc> FileDocs { get; set; }

        public DocFinderContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DocFinderDB;Trusted_Connection=True;");
        }
    }
}
