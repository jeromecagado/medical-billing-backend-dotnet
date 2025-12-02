namespace BillingAPI.DTOs
{
    public class InvoiceDto
    {
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }

        // Optional
        public string? PatientName { get; set; }
    }
}

