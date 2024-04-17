using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;

namespace TicketingSystem.Application.Features.Companies.Request.Command
{
    public class UpdateCompanyCommand : IRequest<Unit>
    {
        public CompanyDto Company { get; set; }
    }
}
