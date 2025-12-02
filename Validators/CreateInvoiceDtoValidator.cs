using FluentValidation;
using BillingAPI.DTOs;

namespace BillingAPI.Validators
{
    public class CreateInvoiceDtoValidator : AbstractValidator<CreateInvoiceDto>
    {
        public CreateInvoiceDtoValidator()
        {
            RuleFor(x => x.PatientId)
                .GreaterThan(0);

            RuleFor(x => x.Amount)
                .GreaterThan(0);

            RuleFor(x => x.DueDate)
                .NotEmpty()
                .GreaterThan(DateTime.UtcNow.AddDays(-1))
                .WithMessage("Due date cannot be in the past.");
        }
    }
}
