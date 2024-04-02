using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        Task<Company> GetCompany(int id);
        Task<List<Company>> GetCompanies();
        Task AddCompany(Company company);
        Task DeleteCompany(int id);
        Task UpdateCompany(Company company);       
    }
}
