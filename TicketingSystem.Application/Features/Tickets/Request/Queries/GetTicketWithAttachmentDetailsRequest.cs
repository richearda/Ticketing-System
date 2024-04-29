using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs.Ticket;

namespace TicketingSystem.Application.Features.Tickets.Request.Queries
{
    public class GetTicketWithAttachmentDetailsRequest : IRequest<List<TicketDto>>
    {
        public int Id { get; set; }
    }
}
