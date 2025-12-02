using AutoMapper;
using BillingAPI.Data;
using BillingAPI.DTOs;
using BillingAPI.Interfaces;
using BillingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BillingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        // Constructor injection
        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        // GET: api/Invoices
        [HttpGet("unpaid")]
        public async Task<IActionResult> GetUnpaidInvoices()
        {
           var result = await _invoiceService.GetUnpaidInvoicesAsync();
           return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoice(int id)
        {
            var invoice = await _invoiceService.GetInvoiceAsync(id);
            if (invoice == null)
                return NotFound();

            return Ok(invoice);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInvoice(CreateInvoiceDto dto)
        {
            var result = await _invoiceService.CreateInvoiceAsync(dto);

            return CreatedAtAction(nameof(GetInvoice),
                new { id = result.InvoiceId },
                    result);
        }
    }
}
