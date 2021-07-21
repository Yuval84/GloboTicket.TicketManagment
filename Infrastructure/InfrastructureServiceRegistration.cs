using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Application.Models.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GloboTicket.TicketManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection service,
            IConfiguration configuration)
        {
            service.Configure<EmailSettings>(configuration.GetSection("EmailSetting"));
            service.AddTransient<IEmailService, IEmailService>();
            return service;
        }
    }
}
