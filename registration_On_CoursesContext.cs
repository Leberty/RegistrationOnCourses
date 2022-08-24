using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistrationOnCourses
{
    public partial class registration_On_CoursesContext : DbContext
    {
        public registration_On_CoursesContext()
        {
        }

        public registration_On_CoursesContext(DbContextOptions<registration_On_CoursesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoursesSet> CoursesSets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersOnCourse> UsersOnCourses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=registration_On_Courses;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursesSet>(entity =>
            {
                entity.ToTable("Courses_Set");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseCountHours)
                    .HasMaxLength(10)
                    .HasColumnName("courseCountHours")
                    .IsFixedLength();

                entity.Property(e => e.CourseFinish)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("courseFinish");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .HasColumnName("courseName");

                entity.Property(e => e.CourseStart)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("courseStart");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EduLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eduLevel");

                entity.Property(e => e.Midname)
                    .HasMaxLength(50)
                    .HasColumnName("midname");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<UsersOnCourse>(entity =>
            {
                entity.ToTable("Users_On_Courses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseId).HasColumnName("courseId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
