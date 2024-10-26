using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MultiScreen_Dotnet8.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Infrastructure.DBContexts
{
    public class MultiScreenDBContext : DbContext
    {
        public MultiScreenDBContext(DbContextOptions<MultiScreenDBContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Subject>()
            .HasIndex(s => new { s.StudentId, s.TeacherId })
            .IsUnique();

        }
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;

    }
}
