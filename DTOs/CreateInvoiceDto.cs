namespace BillingAPI.DTOs
{
    public class CreateInvoiceDto
    {
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }

    }
}
