using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    /// <summary>
    /// Interface repository for Cost Center
    /// </summary>
    public interface ICostCenterRepository : IGenericRepository<CostCenter>
    {
        /// <summary>
        /// Gets the system infos for a cost center
        /// </summary>
        /// <param name="id">ID of the cost center</param>
        /// <returns>List of cost center</returns>
        Task<List<CostCenter>> GetCostCenterSystemInfos(int id);
       
    }
}
