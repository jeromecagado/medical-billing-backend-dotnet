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
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // POST: api/Payments
        [HttpPost]
        public async Task<IActionResult> PostPayment(CreatePaymentDto dto)
        {
            var result = await _paymentService.PostPaymentAsync(dto);
            return Ok(result);
        }

        [HttpGet("invoice/{invoiceId}")]
        public async Task<IActionResult> GetPaymentsForInvoice(int invoiceId)
        {
            var result = await _paymentService.GetPaymentsForInvoiceAsync(invoiceId);
            return Ok(result);
        }
        

    }
}
