using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.DTOs;
using TicketingSystem.Application.DTOs.Ticket;
using TicketingSystem.Domain;

namespace TicketingSystem.Application.Contracts.Persistence
{
    /// <summary>
    /// Interface repository for Ticket
    /// </summary>
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
         /// <summary>
         /// Returns the tickets that has been assigned by the user
         /// </summary>
         /// <param name="userId">ID of assignor</param>
         /// <returns>List of ticket</returns>
        Task<List<GetTicketsByAssignorDto>> GetTicketsAssignedBy(int userId);
        /// <summary>
        /// Returns the tickets that has been assigned to the user
        /// </summary>
        /// <param name="userId">ID of assignee</param>
        /// <returns>List of ticket</returns>
        Task<List<GetTicketsByAssignee>> GetTicketsAssignedTo(int userId);
        /// <summary>
        /// Returns the tickets by requestor
        /// </summary>
        /// <param name="userId">ID of the requestor</param>
        /// <returns>List of ticket</returns>
        Task<List<GetTicketsByRequestorDto>> GetTicketsRequestedBy(int userId);
        /// <summary>
        /// Returns the tickets by date requested
        /// </summary>
        /// <param name="requestedDate">Date of request</param>
        /// <returns>List of ticket</returns>
        Task<List<GetTicketsByDateDto>> GetTicketsByRequestedDate(DateOnly requestedDate);
        /// <summary>
        /// Returns the tickets by due date
        /// </summary>
        /// <param name="dueDate">Due date</param>
        /// <returns>List of ticket</returns>
        Task<List<GetTicketsByDateDto>> GetTicketsByDueDate(DateOnly dueDate);
        /// <summary>
        /// Returns the ticket with attachement details
        /// </summary>
        /// <param name="ticketId">ID of the ticket</param>
        /// <returns>Returna a ticket</returns>
        Task<TicketDto> GetTicketWithAttachmentDetails(int ticketId);

    }
}
