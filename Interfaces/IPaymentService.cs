using BillingAPI.DTOs;


namespace BillingAPI.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentDto> PostPaymentAsync(CreatePaymentDto dto);
        Task<List<PaymentDto>> GetPaymentsForInvoiceAsync(int invoiceId);
    }
}
