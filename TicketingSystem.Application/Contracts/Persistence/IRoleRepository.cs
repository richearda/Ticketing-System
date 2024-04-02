using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role> GetRole(int id);
        Task<List<Role>> GetRoles();
        Task AddRole(Role role);
        Task DeleteRole(int id);
        Task UpdateRole(Role role);
    }
}
