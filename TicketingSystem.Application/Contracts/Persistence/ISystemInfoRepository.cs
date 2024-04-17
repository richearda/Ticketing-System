using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    /// <summary>
    /// Interface repository for System Info
    /// </summary>
    public interface ISystemInfoRepository : IGenericRepository<SystemInfo>
    {
        /// <summary>
        /// Gets the cost centers of system info
        /// </summary>
        /// <param name="id">ID of system info</param>
        /// <returns>List of system info</returns>
        Task<List<SystemInfo>> GetSystemInfoCostCenters(int id);
    }
}
