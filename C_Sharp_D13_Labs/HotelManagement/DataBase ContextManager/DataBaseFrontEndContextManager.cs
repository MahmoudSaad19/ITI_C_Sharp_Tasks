namespace Hotel_Manager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseFrontEndContextManager : DbContext
    {
        public DataBaseFrontEndContextManager()
            : base("name=DataBaseFrontEndContextManager")
        {
        }

        public virtual DbSet<reservation> reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<reservation>()
                .Property(e => e.zip_code)
                .IsFixedLength();

            modelBuilder.Entity<reservation>()
                .Property(e => e.room_type)
                .IsFixedLength();

            modelBuilder.Entity<reservation>()
                .Property(e => e.room_floor)
                .IsFixedLength();

            modelBuilder.Entity<reservation>()
                .Property(e => e.room_number)
                .IsFixedLength();

            modelBuilder.Entity<reservation>()
                .Property(e => e.payment_type)
                .IsFixedLength();

            modelBuilder.Entity<reservation>()
                .Property(e => e.card_type)
                .IsFixedLength();

            modelBuilder.Entity<reservation>()
                .Property(e => e.card_cvc)
                .IsFixedLength();
        }
    }
}
