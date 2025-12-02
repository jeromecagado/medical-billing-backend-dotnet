namespace BillingAPI.DTOs
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
