using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFromEF.models
{
    [Table("StudentData")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        [Key]
        public int CourseId { get;set; }
        public int CourseName { get; set; }
    }

    public class SchoolContext : DbContext
    {
        /*
        public SchoolContext(DbContextOptions<SchoolContext> Options) : base(Options)
        {
            Database.EnsureCreated();
        }*/
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = KARTHI\\SQLEXPRESS; Initial Catalog = SchoolDB; Integrated Security = True");
        }
    }
}
