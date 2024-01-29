#nullable disable

using EF_HW2.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_HW2.Contexts;

public class MyAcademy : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string ConStr = "Data Source=DESKTOP-0MEGVK7\\SQLEXPRESS01;Initial Catalog=MyAcademy;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(ConStr);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .HasIndex(d => d.Name)
            .IsUnique();

        modelBuilder.Entity<Faculty>()
            .HasIndex(f => f.Name)
            .IsUnique();

        modelBuilder.Entity<Group>()
            .HasIndex(g => g.Name)
            .IsUnique();

        //modelBuilder.Entity<Lecture>()
        //    .Property(l => l.Date)
        //    .HasCheckConstraint("CK_Lecture_Date", "Date <= GETDATE()");

        modelBuilder.Entity<Subject>()
            .HasIndex(s => s.Name)
            .IsUnique();


        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}