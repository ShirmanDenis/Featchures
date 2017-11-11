namespace Lab2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TourBaseContext : DbContext
    {
        public TourBaseContext()
            : base("name=TourBaseContext")
        {
        }

        public virtual DbSet<Base> Base { get; set; }
        public virtual DbSet<Tourist> Tourist { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base>()
                .HasMany(e => e.Tourist)
                .WithRequired(e => e.Base)
                .WillCascadeOnDelete(false);
        }
    }
}
