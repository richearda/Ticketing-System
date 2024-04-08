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
    public class SystemInfoRepository : GenericRepository<SystemInfo>, ISystemInfoRepository
    {
        private readonly TicketingSystemDBContext _dbContext;
        public SystemInfoRepository(TicketingSystemDBContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<SystemInfo>> GetSystemInfoCostCenters(int id)
        {
            return await _dbContext.SystemInfos.Include(s => s.CostCenters).Where(s => s.SystemInfoID == id).ToListAsync();
        }
    }
}
