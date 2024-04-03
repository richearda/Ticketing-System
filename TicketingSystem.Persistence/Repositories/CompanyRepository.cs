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
        public async Task AddCompany(Company company)
        {
            await _dbContext.AddAsync(company);
        }

        public async Task DeleteCompany(int id)
        {
           
          
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task<Company> GetCompany(int id)
        {
            return await _dbContext.Companies.FindAsync(id);
        }

        public async Task UpdateCompany(Company company)
        {
          
            _dbContext.Entry(company).State = EntityState.Modified;
        }
    }
}
