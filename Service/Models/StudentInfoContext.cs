using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Service.Models
{
    public partial class StudentInfoContext : DbContext
    {
        public StudentInfoContext()
        {
        }

        public StudentInfoContext(DbContextOptions<StudentInfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= BARD\\SQLEXPRESS;uid=sa;pwd=12345;database=StudentInfo;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__Account__A9D10535182BADAB");

                entity.ToTable("Account");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(10)
                    .HasColumnName("AdminID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(8)
                    .HasColumnName("ApplicationID");

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AdminID");

                entity.Property(e => e.ApproveDate).HasColumnType("date");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("StudentID");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Applicati__Admin__35BCFE0A");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Applicati__Stude__34C8D9D1");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(6)
                    .HasColumnName("ClassID");

                entity.Property(e => e.MajorId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("MajorID");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Class__MajorID__2A4B4B5E");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.MajorId)
                    .HasMaxLength(2)
                    .HasColumnName("MajorID");

                entity.Property(e => e.MajorDesc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(8)
                    .HasColumnName("StudentID");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("ClassID");

                entity.Property(e => e.MajorId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("MajorID");

                entity.Property(e => e.StudentEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student__ClassID__2F10007B");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student__MajorID__2E1BDC42");

                entity.HasOne(d => d.StudentEmailNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StudentEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student__Student__2D27B809");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(6)
                    .HasColumnName("SubjectID");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("ClassID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Subject__ClassID__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
