using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.Features.Tickets.Request.Command;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Features.Tickets.Handler.Command
{

    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand,int>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;
        public CreateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = _mapper.Map<Ticket>(request.Ticket);
            if (ticket != null) { 
             await _ticketRepository.Add(ticket);
            }
            return ticket.TicketID;
        }
    }
}
