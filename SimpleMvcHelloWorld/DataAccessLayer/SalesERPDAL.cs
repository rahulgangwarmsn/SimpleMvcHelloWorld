using SimpleMvcHelloWorld.Models;
using System.Data.Entity;
namespace SimpleMvcHelloWorld.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
  
        public DbSet<Employee>? Employees
        {
            get; set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}
