using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.DTOs
{
   public class CostCenterDto
    {
        public int CostCenterID { get; set; }
        public string CostCenterName { get; set; }
        public string Description { get; set; }
        public ICollection<SystemInfoDto> Systems { get; set; }
    }
}
