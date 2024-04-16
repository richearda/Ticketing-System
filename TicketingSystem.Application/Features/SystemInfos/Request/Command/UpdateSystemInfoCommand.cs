using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;

namespace TicketingSystem.Application.Features.SystemInfos.Request.Command
{
    public class UpdateSystemInfoCommand : IRequest<int>
    {
        public SystemInfoDto SystemInfo { get; set; }
    }
}
