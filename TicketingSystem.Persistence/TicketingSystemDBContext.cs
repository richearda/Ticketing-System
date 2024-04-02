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

        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
        }
        
    }
}
