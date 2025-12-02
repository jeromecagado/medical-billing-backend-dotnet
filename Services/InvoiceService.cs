using AutoMapper;
using BillingAPI.Data;
using BillingAPI.DTOs;
using BillingAPI.Interfaces;
using BillingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BillingAPI.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly BillingContext _context;
        private readonly IMapper _mapper;

        public InvoiceService(BillingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<InvoiceDto>> GetUnpaidInvoicesAsync()
        {
            var invoices = await _context.Invoices
                .Where(i => !i.IsPaid)
                .OrderBy(i => i.DueDate)
                .ToListAsync();

            return _mapper.Map<List<InvoiceDto>>(invoices);
        }

        public async Task<InvoiceDto?> GetInvoiceAsync(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
                return null;

            return _mapper.Map<InvoiceDto>(invoice);
        }

        public async Task<InvoiceDto> CreateInvoiceAsync(CreateInvoiceDto dto)
        {
            var invoice = _mapper.Map<Invoice>(dto);

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            return _mapper.Map<InvoiceDto>(invoice);
        }
    }
}
