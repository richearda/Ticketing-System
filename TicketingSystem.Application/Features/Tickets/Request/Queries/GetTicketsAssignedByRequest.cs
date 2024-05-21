using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs.Ticket;

namespace TicketingSystem.Application.Features.Tickets.Request.Queries
{
    public class GetTicketsAssignedByRequest : IRequest<List<GetTicketsByAssignorDto>>
    {
        public int Id { get; set; }
    }
}
