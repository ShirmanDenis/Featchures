namespace Lab1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TouristDbContext : DbContext
    {
        public TouristDbContext()
            : base("name=TouristDbContext")
        {
        }

        public virtual DbSet<Tourist> Tourist { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
