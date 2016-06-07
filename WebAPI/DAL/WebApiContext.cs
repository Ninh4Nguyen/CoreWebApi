namespace DAL
{
    using DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebApiContext : DbContext
    {
        public WebApiContext()
            : base("name=WebApiContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebApiContext, DAL.Migrations.Configuration>());
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
