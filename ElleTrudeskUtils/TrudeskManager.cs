using System;
using System.Net;
using System.Net.Http;
using ElleTrudeskUtils.Configuration;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ElleTrudeskUtils.Entities;
using Newtonsoft.Json;

namespace ElleTrudeskUtils
{
    public class TrudeskManager
    {
        private Config Configuration { get; set; }
        private static HttpClient HttpClient { get; set; }

        public TrudeskManager()
        {
            Configuration = ConfigReader.GetConfig();
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(Configuration.TrudeskUrl);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "accesstoken", Configuration.TrudeskAccessToken);
        }

        public async Task<TicketCreateResponse> CreateTicket(TicketRequest ticket)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/tickets/create", ticket);

            response.EnsureSuccessStatusCode();

            TicketCreateResponse ret = JsonConvert.DeserializeObject<TicketCreateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketCreateResponse> GetTicket(string id)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/tickets/" + id);

            response.EnsureSuccessStatusCode();

            TicketCreateResponse ret = JsonConvert.DeserializeObject<TicketCreateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketCreateResponse> UpdateTicket(string id, TicketRequest ticket)
        {
            HttpContent content = new MultipartFormDataContent();

            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("api/v1/tickets/" + id, content);

            response.EnsureSuccessStatusCode();

            TicketCreateResponse ret = JsonConvert.DeserializeObject<TicketCreateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketDeleteResponse> DeleteTicket(string id)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync("api/v1/tickets/" + id);

            response.EnsureSuccessStatusCode();

            TicketDeleteResponse ret = JsonConvert.DeserializeObject<TicketDeleteResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }
    }
}
