using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Domain
{
    public class SystemInfo
    {
        public int SystemInfoID { get; set; }
        public string SystemName { get; set; }
        public string SystemCode { get; set; }
        public ICollection<CostCenter> CostCenters { get; set; }
    }
}
