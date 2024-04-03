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
        public async Task AddSystemInfo(SystemInfo systeminfo)
        {
            await _dbContext.SystemInfos.AddAsync(systeminfo);
        }

        public Task DeleteSystemInfo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SystemInfo> GetSystemInfo(int id)
        {
            return await _dbContext.SystemInfos.FindAsync(id);
        }

        public async Task<List<SystemInfo>> GetSystemInfos()
        {
            return await _dbContext.SystemInfos.ToListAsync();
        }

        public async Task UpdateSystemInfo(SystemInfo systeminfo)
        {
            _dbContext.Entry(systeminfo).State = EntityState.Modified;
        }
    }
}
