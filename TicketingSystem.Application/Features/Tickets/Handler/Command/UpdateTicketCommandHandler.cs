using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.Tickets.Request.Command;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.Tickets.Handler.Command
{
    public class UpdateTicketCommandHandler : IRequestHandler<UpdateTicketCommand, int>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public UpdateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = _ticketRepository.Exists(request.Ticket.TicketID);
            if (ticket == null)
            {
                var t = _mapper.Map<Ticket>(ticket);
                await _ticketRepository.Update(t);
            }
            return request.Ticket.TicketID;
        }
    }
}
