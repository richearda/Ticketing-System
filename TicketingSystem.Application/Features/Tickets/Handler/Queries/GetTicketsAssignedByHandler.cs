using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.DTOs.Ticket;
using TicketingSystem.Application.Features.Tickets.Request.Queries;

namespace TicketingSystem.Application.Features.Tickets.Handler.Queries
{
    public class GetTicketsAssignedByHandler : IRequestHandler<GetTicketsAssignedByRequest, List<TicketDto>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;
        public GetTicketsAssignedByHandler(ITicketRepository ticketRepository, IMapper mapper)
        {          
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<List<TicketDto>> Handle(GetTicketsAssignedByRequest request, CancellationToken cancellationToken)
        {
            var tickets = await _ticketRepository.GetTicketsAssignedBy(request.Id);
            return _mapper.Map<List<TicketDto>>(tickets);
        }
    }
}
