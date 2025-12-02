using BillingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BillingAPI.Data
{
    public class BillingContext : DbContext
    {
        public BillingContext(DbContextOptions<BillingContext> options) :
            base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
