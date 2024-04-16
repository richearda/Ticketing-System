using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Features.Tickets.Request.Command
{
    public class DeleteTicketCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
