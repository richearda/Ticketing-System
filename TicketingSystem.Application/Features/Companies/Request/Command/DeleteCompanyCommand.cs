using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Features.Companies.Request.Command
{
    public class DeleteCompanyCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
