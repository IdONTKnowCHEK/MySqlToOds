using Microsoft.EntityFrameworkCore;
namespace MySqlToOds.Models;


public partial class StudentDataContext : DbContext
{
    public StudentDataContext()
    {
    }

    public StudentDataContext(DbContextOptions<StudentDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentDatum> StudentData { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentDatum>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");

            entity.ToTable("student_data");

            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Absences).HasColumnName("absences");
            entity.Property(e => e.Activities)
                .HasMaxLength(10)
                .HasColumnName("activities");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Failures).HasColumnName("failures");
            entity.Property(e => e.Famrel).HasColumnName("famrel");
            entity.Property(e => e.Famsize)
                .HasMaxLength(10)
                .HasColumnName("famsize");
            entity.Property(e => e.Famsup)
                .HasMaxLength(10)
                .HasColumnName("famsup");
            entity.Property(e => e.Fjob).HasMaxLength(50);
            entity.Property(e => e.Freetime).HasColumnName("freetime");
            entity.Property(e => e.Goout).HasColumnName("goout");
            entity.Property(e => e.Guardian)
                .HasMaxLength(50)
                .HasColumnName("guardian");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.Higher)
                .HasMaxLength(10)
                .HasColumnName("higher");
            entity.Property(e => e.Internet)
                .HasMaxLength(10)
                .HasColumnName("internet");
            entity.Property(e => e.Mjob).HasMaxLength(50);
            entity.Property(e => e.Nursery)
                .HasMaxLength(10)
                .HasColumnName("nursery");
            entity.Property(e => e.Paid)
                .HasMaxLength(10)
                .HasColumnName("paid");
            entity.Property(e => e.Pstatus).HasMaxLength(10);
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.Romantic)
                .HasMaxLength(10)
                .HasColumnName("romantic");
            entity.Property(e => e.School)
                .HasMaxLength(10)
                .HasColumnName("school");
            entity.Property(e => e.Schoolsup)
                .HasMaxLength(10)
                .HasColumnName("schoolsup");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .HasColumnName("sex");
            entity.Property(e => e.Studytime).HasColumnName("studytime");
            entity.Property(e => e.Traveltime).HasColumnName("traveltime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
