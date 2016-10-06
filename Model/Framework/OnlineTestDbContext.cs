namespace Model.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineTestDbContext : DbContext
    {
        public OnlineTestDbContext()
            : base("name=OnlineTestDbContext")
        {
        }

        public virtual DbSet<admin> admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
