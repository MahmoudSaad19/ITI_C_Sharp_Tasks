namespace Hotel_Manager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseLoginContextManager : DbContext
    {
        public DataBaseLoginContextManager()
            : base("name=DataBaseLoginContextManager")
        {
        }

        public virtual DbSet<frontend> frontends { get; set; }
        public virtual DbSet<kitchen> kitchens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
