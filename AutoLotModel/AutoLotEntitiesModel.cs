using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoLotModel
{
    public partial class AutoLotEntitiesModel : DbContext
    {
        public object Customers;

        public AutoLotEntitiesModel()
            : base("name=AutoLotEntitiesModel")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Contract_value)
                .HasPrecision(6, 2);
        }
    }
}
