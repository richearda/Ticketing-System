﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.DTOs.Ticket;

namespace TicketingSystem.Application.Features.Tickets.Request.Queries
{
    public class GetTicketsRequestedByRequest : IRequest<List<TicketDto>>
    {
        public int Id { get; set; }
    }
}
