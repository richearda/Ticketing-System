using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.Features.Tickets.Request.Command;

namespace TicketingSystem.Application.Features.Tickets.Handler.Command
{
    public class DeleteTicketCommandHandler : IRequestHandler<DeleteTicketCommand, int>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public DeleteTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

       

        public async Task<int> Handle(DeleteTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketRepository.Get(request.Id);
            if (ticket != null)
            {
                await _ticketRepository.Delete(ticket);               
            }
            return ticket.TicketID;
        }
    }
}
