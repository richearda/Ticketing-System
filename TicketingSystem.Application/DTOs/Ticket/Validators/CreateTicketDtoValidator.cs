using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.DTOs.Ticket.Validators
{
    public class CreateTicketDtoValidator:AbstractValidator<CreateTicketDto>
    {
        public CreateTicketDtoValidator()
        {
            RuleFor(p => p.TicketNo).NotEmpty().WithMessage("{PropertyName} must contain a value.")
                                    .NotNull()
                                    .MaximumLength(15);

            RuleFor(p => p.RequestedBy).NotEmpty()
                                       .WithMessage("{PropertyName} must have a requestor.")
                                       .NotNull();

            RuleFor(p => p.RequestedDate).NotEmpty()
                                         .WithMessage("Requested Date cannot be empty.")
                                         .NotNull()
                                         .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now))
                                         .WithMessage("Requested Date cannot be less than the current date");

            RuleFor(p => p.Title).NotEmpty()
                                 .NotNull()
                                 .WithMessage("The {PropertyName} must have a title");

            RuleFor(p => p.ProblemDescription).NotEmpty()
                                              .NotNull()
                                              .WithMessage("Please provide a description of the problem");

            RuleFor(p => p.Severity).NotEmpty()
                                    .NotNull()
                                    .WithMessage("Select severity");
        }
    }
}
