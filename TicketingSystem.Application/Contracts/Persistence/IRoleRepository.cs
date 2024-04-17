using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    /// <summary>
    /// Interface repository for Role
    /// </summary>
    public interface IRoleRepository : IGenericRepository<Role>
    {
       
    }
}
