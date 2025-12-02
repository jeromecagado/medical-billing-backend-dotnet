using AutoMapper;
using BillingAPI.Models;
using BillingAPI.DTOs;

namespace BillingAPI.Mappings
{
    public class BillingProfile : Profile
    {
        public BillingProfile()
        {
            // Invoice
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<CreateInvoiceDto, Invoice>();

            // Patient
            CreateMap<CreatePatientDto, Patient>();
            CreateMap<Patient, PatientDto>();

            // Payment
            CreateMap<Payment, PaymentDto>();
            CreateMap<CreatePaymentDto, Payment>();
        }
    }
}
