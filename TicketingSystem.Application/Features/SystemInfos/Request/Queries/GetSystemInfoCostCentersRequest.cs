using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;

namespace TicketingSystem.Application.Features.SystemInfos.Request.Queries
{
    public class GetSystemInfoCostCentersRequest : IRequest<List<SystemInfoDto>>
    {
        public int Id { get; set; }
    }
}
