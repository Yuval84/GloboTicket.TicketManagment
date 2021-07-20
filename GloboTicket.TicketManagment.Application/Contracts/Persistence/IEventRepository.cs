﻿using System;
using System.Threading.Tasks;
using GloboTicket.TicketManagment.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventAndDateUnique(string name, DateTime date);
    }
}
