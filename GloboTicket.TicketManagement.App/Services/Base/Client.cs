using System.Net.Http;

namespace GloboTicket.TicketManagement.App.Services.Base
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient => _httpClient;
    }
}
