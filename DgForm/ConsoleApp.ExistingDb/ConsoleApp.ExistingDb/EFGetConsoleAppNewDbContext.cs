using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp.ExistingDb
{
    public partial class EFGetConsoleAppNewDbContext : DbContext
    {
        public EFGetConsoleAppNewDbContext()
        {
        }

        public EFGetConsoleAppNewDbContext(DbContextOptions<EFGetConsoleAppNewDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        /// <summary>
        /// #warning To protect potentially sensitive information in your connection string, 
        //you should move it out of source code.See http://go.microsoft.com/fwlink/?LinkId=723263 
        //        for guidance on storing connection strings.

        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {


                optionsBuilder.UseNpgsql("User ID=postgres;Password=wsx1001;Host=localhost;Port=5432;Database=EFGetConsoleApp.NewDb;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.HasIndex(e => e.BlogId);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId);
            });
        }
    }
}
