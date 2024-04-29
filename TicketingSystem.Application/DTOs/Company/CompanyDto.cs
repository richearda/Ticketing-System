using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.DTOs
{
    public class CompanyDto
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<CostCenterDto> CostCenters { get; set; }
    }
}
