namespace BillingAPI.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }

        // Navigation property (links invoice -> patient)
        public Patient Patient { get; set; }
    }
}
