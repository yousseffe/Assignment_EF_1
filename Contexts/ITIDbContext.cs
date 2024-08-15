using Assignment_EF_1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_1.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .\\SQLEXPRESS ; Database = ITI ; Trusted_Connection = true; trust server certificate = true ;");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }
        public DbSet<Topic> Topic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>().ToTable("Course_Inst").HasKey(PK => new { PK.Inst_ID, PK.Course_ID });

            modelBuilder.Entity<Stud_Course>().ToTable("Stud_Course").HasKey(PK=> new { PK.Stud_ID , PK.Course_ID} );
        }
    }
}
