using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    // EF Core Getting started
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
    public class StudentContext : DbContext // had to do using Microsoft.Entity...by clicking lightbulb
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is included with VS
            // Trusted_Connection  - indicates that our windows account should be used
            // connection string needs to be good to connect to database
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;"); // sets up connection string
        }

        // Tell EF Core to track Students in the database
        public DbSet<Student> Students { get; set; }
    }
}
