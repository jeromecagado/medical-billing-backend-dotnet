namespace BillingAPI.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePosted { get; set; }

        // Navigation property
        public Invoice Invoice { get; set; }
    }
}
