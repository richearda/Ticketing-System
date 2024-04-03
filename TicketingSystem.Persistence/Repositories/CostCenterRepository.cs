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
        public async Task AddCostCenter(CostCenter costcenter)
        {
            await _dbContext.CostCenters.AddAsync(costcenter);
        }

        public Task DeleteCostCenter(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CostCenter> GetCostCenter(int id)
        {
            return await _dbContext.CostCenters.FindAsync(id);
        }

        public async Task<List<CostCenter>> GetCostCenters()
        {
            return await _dbContext.CostCenters.ToListAsync();
        }

        public async Task UpdateCostCenter(CostCenter costcenter)
        {
           _dbContext.Entry(costcenter).State = EntityState.Modified;
        }
    }
}
