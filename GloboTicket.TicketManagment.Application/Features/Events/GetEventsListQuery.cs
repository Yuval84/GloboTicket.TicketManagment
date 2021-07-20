using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GloboTicket.TicketManagment.Application.Features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
