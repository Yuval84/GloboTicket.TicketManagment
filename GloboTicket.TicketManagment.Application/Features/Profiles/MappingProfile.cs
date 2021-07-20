using AutoMapper;
using GloboTicket.TicketManagment.Application.Features.Events;
using GloboTicket.TicketManagment.Domain.Entities;

namespace GloboTicket.TicketManagment.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
        }
    }
}
