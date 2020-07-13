using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Students { get; set; }
        public DbSet<ContosoUniversity.Models.Enrollment> Enrollments { get; set; }
        public DbSet<ContosoUniversity.Models.Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollent");
            modelBuilder.Entity<Course>().ToTable("Course");
        }
    }
}
