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
        
    }
}
