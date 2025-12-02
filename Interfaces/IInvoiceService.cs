using BillingAPI.DTOs;
using BillingAPI.Models;

namespace BillingAPI.Interfaces
{
    public interface IInvoiceService
    {
        Task<List<InvoiceDto>> GetUnpaidInvoicesAsync();
        Task<InvoiceDto?> GetInvoiceAsync(int id);
        Task<InvoiceDto> CreateInvoiceAsync(CreateInvoiceDto dto);
    }
}
