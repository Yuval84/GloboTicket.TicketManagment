﻿using System;
using System.Collections.Generic;

namespace GloboTicket.TicketManagment.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}