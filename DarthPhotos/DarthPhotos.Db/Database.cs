using DarthPhotos.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DarthPhotos.Db
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options)
            : base(options)
        {
            
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PhotoEntity> Photos { get; set; }
        public DbSet<ScannedEntity> Scanned { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Rename the inherited Id property for UserEntity
            modelBuilder.Entity<UserEntity>()
                .Property(e => e.Id)
                .HasColumnName("USR_ID");

            modelBuilder.Entity<PhotoEntity>()
                .Property(e => e.Id)
                .HasColumnName("PHT_ID");

            modelBuilder.Entity<ScannedEntity>()
                .Property(e => e.Id)
                .HasColumnName("SCN_ID");
        }
    }
}
