using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    public interface ISystemInfoRepository : IGenericRepository<SystemInfo>
    {
        
        Task<List<SystemInfo>> GetSystemInfoCostCenters(int id);
 
    }
}
