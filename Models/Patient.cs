namespace BillingAPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation property
        public List<Invoice> Invoices { get; set; }
    }
}
