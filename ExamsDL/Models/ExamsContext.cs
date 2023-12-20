using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExamsDL.Models
{
    public partial class ExamsContext : DbContext
    {
        public ExamsContext()
        {
        }

        public ExamsContext(DbContextOptions<ExamsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamsUser> ExamsUsers { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PersonalDetaile> PersonalDetailes { get; set; }
        public virtual DbSet<ReliefReason> ReliefReasons { get; set; }
        public virtual DbSet<ReliefType> ReliefTypes { get; set; }
        public virtual DbSet<ReliefUser> ReliefUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GGJUHG9;Database=Exams;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdPermissions).HasColumnName("Id_Permissions");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdPermissionsNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdPermissions)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employees__Id_Pe__31EC6D26");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.IdExam);

                entity.Property(e => e.IdExam).HasColumnName("Id_exam");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Subjects)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ExamsUser>(entity =>
            {
                entity.HasKey(e => e.IdExamUser);

                entity.ToTable("Exams_Users");

                entity.Property(e => e.IdExamUser).HasColumnName("Id_examUser");

                entity.Property(e => e.Class).HasMaxLength(30);

                entity.Property(e => e.Grade).HasMaxLength(30);

                entity.Property(e => e.IdExam).HasColumnName("Id_Exam");

                entity.Property(e => e.IdFileStudy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Id_file_study");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.NotesOffice).HasMaxLength(30);

                entity.Property(e => e.NotesUser).HasMaxLength(30);

                entity.HasOne(d => d.IdExamNavigation)
                    .WithMany(p => p.ExamsUsers)
                    .HasForeignKey(d => d.IdExam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Exams_Use__Id_Ex__52593CB8");

                //entity.HasOne(d => d.IdUserNavigation)
                //    .WithMany(p => p.ExamsUsers)
                //    .HasForeignKey(d => d.IdUser)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Exams_Use__Id_Us__5165187F");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.IdPermissions)
                    .HasName("PK_Permissions");

                entity.ToTable("Permission");

                entity.Property(e => e.IdPermissions).HasColumnName("Id_Permissions");

                entity.Property(e => e.PermissionsName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PersonalDetaile>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IdentityNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UrlFilesId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Url_Files_id");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ReliefReason>(entity =>
            {
                entity.HasKey(e => e.IdReliefReasons);

                entity.Property(e => e.IdReliefReasons).HasColumnName("Id_ReliefReasons");

                entity.Property(e => e.Reasons).HasMaxLength(50);
            });

            modelBuilder.Entity<ReliefType>(entity =>
            {
                entity.HasKey(e => e.IdRelifeTypes);

                entity.Property(e => e.IdRelifeTypes).HasColumnName("Id_RelifeTypes");

                entity.Property(e => e.ReliefTypes)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ReliefUser>(entity =>
            {
                entity.HasKey(e => e.IdReliefUser)
                    .HasName("PK_Relief_users");

                entity.ToTable("Relief_Users");

                entity.Property(e => e.IdReliefUser).HasColumnName("Id_reliefUser");

                entity.Property(e => e.IdReliefReasons).HasColumnName("Id_ReliefReasons");

                entity.Property(e => e.IdReliefTypes).HasColumnName("Id_ReliefTypes");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.ReliefExplanation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReliefFile)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Relief_File");

                entity.HasOne(d => d.IdReliefReasonsNavigation)
                    .WithMany(p => p.ReliefUsers)
                    .HasForeignKey(d => d.IdReliefReasons)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Relief_Us__Id_Re__35BCFE0A");

                entity.HasOne(d => d.IdReliefTypesNavigation)
                    .WithMany(p => p.ReliefUsers)
                    .HasForeignKey(d => d.IdReliefTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Relief_Us__Id_Re__34C8D9D1");

                //entity.HasOne(d => d.IdUserNavigation)
                //    .WithMany(p => p.ReliefUsers)
                //    .HasForeignKey(d => d.IdUser)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Relief_Us__Id_Us__534D60F1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
