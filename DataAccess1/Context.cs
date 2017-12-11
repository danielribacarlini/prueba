namespace DataAccess1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.userCreate)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.userModif)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.News)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.userCreate);

            modelBuilder.Entity<users>()
                .HasMany(e => e.News1)
                .WithRequired(e => e.users1)
                .HasForeignKey(e => e.userModif)
                .WillCascadeOnDelete(false);
        }
    }
}
