using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    public interface ICostCenterRepository : IGenericRepository<CostCenter>
    {
        Task<List<CostCenter>> GetCostCenterSystemInfos(int id);
       
    }
}
