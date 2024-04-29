using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs.CostCenter;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.DTOs
{
    public class SystemInfoDto
    {
        public int SystemInfoID { get; set; }
        public string SystemName { get; set; }
        public string SystemCode { get; set; }
        public ICollection<CostCenterDto> CostCenters { get; set; }
    }
}
