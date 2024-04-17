using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    /// <summary>
    /// Interface repository for company
    /// </summary>
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        /// <summary>
        /// Gets the company with cost centers
        /// </summary>
        /// <param name="id">ID of the company</param>
        /// <returns>List of company</returns>
        Task<List<Company>> GetCompanyWithCostCenters(int id);
            
    }
}
