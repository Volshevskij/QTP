using System.Data.Entity;

namespace QTProj.Models
{
    public class CustomersContext : DbContext
    {
        public DbSet<Call> Calls { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public  CustomersContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Call>()
                .HasRequired<Customer>(b => b.Customer)
                .WithMany(a => a.Calls)
                .HasForeignKey<int>(b => b.CustomerId);
        }
    }
}