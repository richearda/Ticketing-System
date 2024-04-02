using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Domain
{
    public class CostCenter
    {
        public int CostCenterID { get; set; }
        public string CostCenterName { get; set; }
        public string Description { get; set; }
        public ICollection<SystemInfo> Systems { get; set; }
    }
}
