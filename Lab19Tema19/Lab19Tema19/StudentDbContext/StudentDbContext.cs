using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Collections.Generic;

// populati DB
namespace Lab19Tema19.StudentDbContext
{
    internal class StudentDbContext:StudentDbContext
    {
        
        public DbSet<Student> Students { get; set; }
        public StudentDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\Lab17Ex1\Lab17Ex1\ProductDb.mdf;Integrated Security=True");
        }
    }
}
