using System;
using System.Collections.Generic;
using GloboTicket.TicketManagment.Domain.Common;

namespace GloboTicket.TicketManagment.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
