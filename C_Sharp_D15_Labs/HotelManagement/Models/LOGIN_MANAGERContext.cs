using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hotel_Manager.Models
{
    public partial class LOGIN_MANAGERContext : DbContext
    {
        public LOGIN_MANAGERContext()
        {
        }

        public LOGIN_MANAGERContext(DbContextOptions<LOGIN_MANAGERContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Frontend> Frontend { get; set; }
        public virtual DbSet<Kitchen> Kitchen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;initial Catalog=LOGIN_MANAGER;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Frontend>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Table");

                entity.ToTable("frontend");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasColumnName("pass_word")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__kitchen__7628B51D2FDAF8B5");

                entity.ToTable("kitchen");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasColumnName("pass_word")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
