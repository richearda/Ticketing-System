using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Features.SystemInfos.Request.Command
{
    public class DeleteSystemInfoCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
