using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs.CostCenter;

namespace TicketingSystem.Application.Features.CostCenter.Request.Queries
{
    public class GetCostCenterSystemInfosRequest : IRequest<List<CostCenterDto>>
    {
        public int Id { get; set; }
    }
}