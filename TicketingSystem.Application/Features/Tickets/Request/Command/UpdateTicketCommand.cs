using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;

namespace TicketingSystem.Application.Features.Tickets.Request.Command
{
    public class UpdateTicketCommand : IRequest<int>
    {
        public TicketDto Ticket { get; set; }
    }
}
