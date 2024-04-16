using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;

namespace TicketingSystem.Application.Features.Roles.Request.Command
{
    public class UpdateRoleCommand : IRequest<int>
    {
        public RoleDto Role { get; set; }
    }
}
