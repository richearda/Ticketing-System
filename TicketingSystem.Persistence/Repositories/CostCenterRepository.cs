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
    public class CostCenterRepository : GenericRepository<CostCenter>, ICostCenterRepository
    {
        private readonly TicketingSystemDBContext _dbContext;
        public CostCenterRepository(TicketingSystemDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CostCenter>> GetCostCenterSystemInfos(int id)
        {
            return await _dbContext.CostCenters.Include(c => c.Systems).Where(c => c.CostCenterID == id).ToListAsync();
        }
    }
}
