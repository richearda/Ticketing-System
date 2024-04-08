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

        public async Task<List<Ticket>> GetTicketsAssignedBy(int userId)
        {
            return await _dbContext.Tickets.Where(t => t.AssignedBy == userId).ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketsAssignedTo(int userId)
        {
            return await _dbContext.Tickets.Where(t => t.AssignedTo == userId).ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketsByDueDate(DateOnly dueDate)
        {
            return await _dbContext.Tickets.Where(t => t.DueDate == dueDate).ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketsByRequestedDate(DateOnly requestedDate)
        {
           return await _dbContext.Tickets.Where(t => t.RequestedDate == requestedDate).ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketsRequestedBy(int userId)
        {
            return await _dbContext.Tickets.Where(t => t.RequestedBy == userId).ToListAsync();
        }

        public async Task<Ticket> GetTicketWithAttachmentDetails(int ticketId)
        {
            return await _dbContext.Tickets.Include(t => t.Attachments).Where(t => t.TicketID == ticketId).FirstOrDefaultAsync();
        }
    }
}
