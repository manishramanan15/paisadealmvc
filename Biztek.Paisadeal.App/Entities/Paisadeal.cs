namespace Biztek.Paisadeal.App.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PaisadealContext : DbContext
    {
        public PaisadealContext()
            : base("name=Paisadeal")
        {
        }

        public virtual DbSet<CreditInformation> CreditInformations { get; set; }
        public virtual DbSet<TypeOFLoan> TypeOFLoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeOFLoan>()
                .Property(e => e.NetSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TypeOFLoan>()
                .Property(e => e.AnnualSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TypeOFLoan>()
                .Property(e => e.PinCode)
                .IsFixedLength();
        }
    }
}
