using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.Features.Tickets.Request.Queries;

namespace TicketingSystem.Application.Features.Tickets.Handler.Queries
{
    public class GetTicketAssignedToHandler : IRequestHandler<GetTicketsAssignedToRequest, List<TicketDto>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;
        public GetTicketAssignedToHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<List<TicketDto>> Handle(GetTicketsAssignedToRequest request, CancellationToken cancellationToken)
        {
            var tickets =  await _ticketRepository.GetTicketsAssignedTo(request.Id);
            return _mapper.Map<List<TicketDto>>(tickets);

        }
    }
}
