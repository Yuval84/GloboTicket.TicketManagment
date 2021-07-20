using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagment.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool IncludePassedEvents);
    }
}
