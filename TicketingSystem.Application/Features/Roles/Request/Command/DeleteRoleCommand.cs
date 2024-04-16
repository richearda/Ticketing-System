using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Features.Roles.Request.Command
{
    public class DeleteRoleCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
