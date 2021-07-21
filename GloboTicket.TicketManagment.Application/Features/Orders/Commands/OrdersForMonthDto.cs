using System;

namespace GloboTicket.TicketManagement.Application.Features.Orders.Commands
{
    public class OrdersForMonthDto
    {
        public Guid Id { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}