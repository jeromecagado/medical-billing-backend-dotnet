using AutoMapper;
using BillingAPI.DTOs;
using BillingAPI.Data;
using BillingAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using BillingAPI.Models;


namespace BillingAPI.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly BillingContext _context;
        private readonly IMapper _mapper;

        public PaymentService(BillingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaymentDto> PostPaymentAsync(CreatePaymentDto dto)
        {
            var invoice = await _context.Invoices.FindAsync(dto.InvoiceId);
            if (invoice == null)
                throw new Exception($"Invoice {dto.InvoiceId} not found.");

            if (dto.Amount <= 0)
                throw new Exception("Payment amount must be greater than zero.");

            var payment = _mapper.Map<Payment>(dto);
            payment.DatePosted = DateTime.UtcNow;

            _context.Payments.Add(payment);

            if (dto.Amount >= invoice.Amount)
                invoice.IsPaid = true;

            await _context.SaveChangesAsync();
            return _mapper.Map<PaymentDto>(payment);
        }

        public async Task<List<PaymentDto>> GetPaymentsForInvoiceAsync(int invoiceId)
        {
            var payments = await _context.Payments
                .Where(p => p.InvoiceId == invoiceId)
                .ToListAsync();
            return _mapper.Map<List<PaymentDto>>(payments);
        }
    }
}
