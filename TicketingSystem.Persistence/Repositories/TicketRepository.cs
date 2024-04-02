using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Domain;

namespace TicketingSystem.Persistence.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        private readonly TicketingSystemDBContext _dbContext;
        public TicketRepository(TicketingSystemDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddTicket(Ticket ticket)
        {
            await _dbContext.AddAsync(ticket);
        }

        public async Task DeleteTicket(int id)
        {
            //await _dbContext.Set<T>().RemoveAsync(id);
        }

        public async Task<Ticket> GetTicket(int id)
        {
           return await _dbContext.Tickets.FindAsync(id);
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _dbContext.Tickets.ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketsAssignedBy(int userId)
        {
            return await _dbContext.Tickets.Where(t => t.AssignedBy == userId).ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketsRequestedBy(int userId)
        {
            return await _dbContext.Tickets.Where(t => t.RequestedBy == userId).ToListAsync();
        }

        public async Task UpdateTicket(Ticket ticket)
        {
              _dbContext.Entry(ticket).State = EntityState.Modified;
        }
    }
}
