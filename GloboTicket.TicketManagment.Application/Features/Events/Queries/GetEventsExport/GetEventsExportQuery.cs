﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery : IRequest<EventExportVm>
    {
    }
}
