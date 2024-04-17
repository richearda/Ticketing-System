using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Features.CostCenter.Request.Command
{
    public class DeleteCostCenterCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
