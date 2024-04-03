using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Persistence
{
    public class TicketingSystemDBContext : DbContext
    {
        public TicketingSystemDBContext(DbContextOptions<TicketingSystemDBContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
        }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SystemInfo> SystemInfos { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
