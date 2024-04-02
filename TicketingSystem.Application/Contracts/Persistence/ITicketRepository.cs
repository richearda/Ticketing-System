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
        Task<Ticket> GetTicket(int id);
        Task<List<Ticket>> GetTickets();
        Task AddTicket(Ticket ticket);
        Task DeleteTicket(int id);
        Task UpdateTicket(Ticket ticket);
        Task<List<Ticket>> GetTicketsAssignedBy(int userId);
        Task<List<Ticket>> GetTicketsRequestedBy(int userId);

    }
}
