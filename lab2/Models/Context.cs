using Microsoft.EntityFrameworkCore;
using System;

namespace lab2.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Training;Integrated Security=True;Encrypt=False");
        //    }
        //}
    }
}
