using C44_G00_EF02.Configurations;
using C44_G00_EF02.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace C44_G00_EF02.Data
{
    internal class SystemDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database= Assignment02; Trusted_Connection=true; trustservercertificate=true ");
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Course> Courses { get; set; }
       public DbSet<Student> Students { get; set; }
       public DbSet<Topic> Topics { get; set; }
       public DbSet<Department> Departments { get; set; }
       public DbSet<Instructor> Instructors { get; set; }
       public DbSet<Course_Inst> Course_Insts { get; set; }
       public DbSet<Stud_Course> Stud_Courses { get; set; }
        

    }
}
