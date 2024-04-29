using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs.CostCenter;

namespace TicketingSystem.Application.Features.CostCenter.Request.Command
{
    public class UpdateCostCenterCommand : IRequest<Unit>
    {
        public CostCenterDto CostCenter { get; set; }
    }
}
