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
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly TicketingSystemDBContext _dbContext;
        public CompanyRepository(TicketingSystemDBContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<Company>> GetCompanyWithCostCenters(int id)
        {
           return await _dbContext.Companies.Include(c => c.CostCenters).Where(c => c.CompanyID == id).ToListAsync();
        }
    }
}
