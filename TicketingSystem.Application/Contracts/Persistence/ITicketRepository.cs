using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
     
        Task<List<Ticket>> GetTicketsAssignedBy(int userId);
        Task<List<Ticket>> GetTicketsAssignedTo(int userId);
        Task<List<Ticket>> GetTicketsRequestedBy(int userId);
        Task<List<Ticket>> GetTicketsByRequestedDate(DateOnly requestedDate);
        Task<List<Ticket>> GetTicketsByDueDate(DateOnly dueDate);
        Task<Ticket> GetTicketWithAttachmentDetails(int ticketId);

    }
}
