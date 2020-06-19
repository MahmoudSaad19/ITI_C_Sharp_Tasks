using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hotel_Manager.Models
{
    public partial class FRONTEND_RESERVATIONContext : DbContext
    {
        public FRONTEND_RESERVATIONContext()
        {
        }

        public FRONTEND_RESERVATIONContext(DbContextOptions<FRONTEND_RESERVATIONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reservation> Reservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;initial Catalog=FRONTEND_RESERVATION;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("reservation");

                entity.Property(e => e.AptSuite)
                    .IsRequired()
                    .HasColumnName("apt_suite")
                    .HasMaxLength(50);

                entity.Property(e => e.ArrivalTime)
                    .HasColumnName("arrival_time")
                    .HasColumnType("date");

                entity.Property(e => e.BirthDay)
                    .IsRequired()
                    .HasColumnName("birth_day")
                    .HasMaxLength(50);

                entity.Property(e => e.BreakFast).HasColumnName("break_fast");

                entity.Property(e => e.CardCvc)
                    .IsRequired()
                    .HasColumnName("card_cvc")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CardExp)
                    .IsRequired()
                    .HasColumnName("card_exp")
                    .HasMaxLength(50);

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasColumnName("card_number")
                    .HasMaxLength(50);

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("card_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CheckIn).HasColumnName("check_in");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city");

                entity.Property(e => e.Cleaning).HasColumnName("cleaning");

                entity.Property(e => e.Dinner).HasColumnName("dinner");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FoodBill).HasColumnName("food_bill");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(50);

                entity.Property(e => e.LeavingTime)
                    .HasColumnName("leaving_time")
                    .HasColumnType("date");

                entity.Property(e => e.Lunch).HasColumnName("lunch");

                entity.Property(e => e.NumberGuest).HasColumnName("number_guest");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("payment_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasMaxLength(50);

                entity.Property(e => e.RoomFloor)
                    .IsRequired()
                    .HasColumnName("room_floor")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasColumnName("room_number")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("room_type")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SSurprise).HasColumnName("s_surprise");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasColumnName("street_address");

                entity.Property(e => e.SupplyStatus).HasColumnName("supply_status");

                entity.Property(e => e.TotalBill).HasColumnName("total_bill");

                entity.Property(e => e.Towel).HasColumnName("towel");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasColumnName("zip_code")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
