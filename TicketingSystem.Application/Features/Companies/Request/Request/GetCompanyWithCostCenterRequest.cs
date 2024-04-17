using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.Companies.Request.Request
{
    public class GetCompanyWithCostCenterRequest : IRequest<List<Company>>
    {
        public int Id { get; set; }
    }
}
