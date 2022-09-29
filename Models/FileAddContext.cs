using System;
using DguDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace DguSite
{
    public partial class FileAddContext : DbContext
    {
        public FileAddContext()
        {
        }

        public FileAddContext(DbContextOptions<FileAddContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataNews> DataNews { get; set; }
        public virtual DbSet<DataNewsSlider> DataNewsSliders { get; set; }
        public virtual DbSet<SprNewsType> SprNewsTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=WIN-I7820DTPAF1\\SQLEXPRESS;Database=FileAdd;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataNews>(entity =>
            {
                entity.ToTable("data_news");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(50)
                    .HasColumnName("avatar");

                entity.Property(e => e.AvatarExtension)
                    .HasMaxLength(8)
                    .HasColumnName("avatar_extension");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.DateAdd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_add");

                entity.Property(e => e.SprNewsTypeId).HasColumnName("spr_news_type_id");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<DataNewsSlider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_news_slider");

                entity.Property(e => e.DataNewsId).HasColumnName("data_news_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.ImageExtension)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("image_extension");
            });

            modelBuilder.Entity<SprNewsType>(entity =>
            {
                entity.ToTable("spr_news_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
