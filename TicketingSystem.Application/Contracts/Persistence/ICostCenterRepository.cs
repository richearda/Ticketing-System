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
        Task<CostCenter> GetCostCenter(int id);
        Task<List<CostCenter>> GetCostCenters();
        Task AddCostCenter(CostCenter costcenter);
        Task DeleteCostCenter(int id);
        Task UpdateCostCenter(CostCenter costcenter);
    }
}
