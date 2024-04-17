using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.Companies.Request.Command
{
    public class CreateCompanyCommand : IRequest<Company>
    {
        public CompanyDto Company { get; set; }
    }
}
