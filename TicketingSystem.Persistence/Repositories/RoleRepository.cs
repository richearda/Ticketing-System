using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Domain;

namespace TicketingSystem.Persistence.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly TicketingSystemDBContext _dbContext;
        public RoleRepository(TicketingSystemDBContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task AddRole(Role role)
        {
            await _dbContext.Roles.AddAsync(role);
        }

        public Task DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Role> GetRole(int id)
        {
            return await _dbContext.Roles.FindAsync(id);
        }

        public async Task<List<Role>> GetRoles()
        {
            return await _dbContext.Roles.ToListAsync();
        }

        public async Task UpdateRole(Role role)
        {
            _dbContext.Entry(role).State = EntityState.Modified;
        }
    }
}
