using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employee { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CHIRATH\\SQLEXPRESS;Initial Catalog=EMPLOYEEMgt;Integrated Security=True;TrustServerCertificate=True");
        }

       





    }


    }

