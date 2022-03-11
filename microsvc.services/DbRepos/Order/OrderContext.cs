using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace microsvc.services.DbRepos.Order
{
    public partial class orderContext : DbContext
    {
        public orderContext()
        {
        }

        public orderContext(DbContextOptions<orderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderEntity> OrderEntity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("DataSource=C:\\sources\\repos\\microsvc\\microsvc.services\\SqLiteDBs\\order.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserId).HasColumnType("int");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
