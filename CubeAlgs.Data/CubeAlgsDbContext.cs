using CubeAlgs.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CubeAlgs.Data
{
    public class CubeAlgsDbContext : DbContext
    {
        public DbSet<Set> Sets { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Algorithm> Algorithms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Configure one-to-many relationship between Case and Algorithm
            modelBuilder.Entity<Algorithm>()
                .HasRequired(a => a.Case)
                .WithMany(c => c.Algorithms)
                .HasForeignKey(a => a.CaseId);

            // Configure one-to-many relationship between Set and Group
            modelBuilder.Entity<Group>()
                .HasOptional(g => g.Set)
                .WithMany(s => s.Groups)
                .HasForeignKey(g => g.SetId);

            // Configure one-to-many relationship between Set and Case
            modelBuilder.Entity<Case>()
                .HasRequired(c => c.Set)
                .WithMany(s => s.Cases)
                .HasForeignKey(c => c.SetId);

            // Configure one-to-many relationship between Group and Case
            modelBuilder.Entity<Case>()
                .HasOptional(c => c.Group)
                .WithMany(s => s.Cases)
                .HasForeignKey(c => c.GroupId);
        }
    }
}
