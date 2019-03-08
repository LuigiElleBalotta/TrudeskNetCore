using System;
using System.Diagnostics;
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
            HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("accesstoken", Configuration.TrudeskAccessToken);
        }

        public async Task<TicketCreateResponse> CreateTicket(TicketRequest ticket)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/tickets/create", ticket);

            response.EnsureSuccessStatusCode();

            TicketCreateResponse ret = JsonConvert.DeserializeObject<TicketCreateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketCommentResponse> InsertComment(TicketCommentRequest comment)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/tickets/addcomment", comment);

            TicketCommentResponse ret = JsonConvert.DeserializeObject<TicketCommentResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;

        }

        public async Task<TicketGetResponse> GetTicket(string id)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/tickets/" + id);

            response.EnsureSuccessStatusCode();

            TicketGetResponse ret = JsonConvert.DeserializeObject<TicketGetResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketCreateResponse> UpdateTicket(string id, TicketRequest ticket)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("api/v1/tickets/" + id, ticket);

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

        public async Task<TicketSearchResponse> GetMyTickets(string username)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/tickets/search/?search=" + username);

            response.EnsureSuccessStatusCode();

            TicketSearchResponse ret = JsonConvert.DeserializeObject<TicketSearchResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketSearchResponse> SearchTicket(TicketSearchFilter filtro)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/tickets/search/?search=" + filtro.it);

            response.EnsureSuccessStatusCode();

            TicketSearchResponse ret = JsonConvert.DeserializeObject<TicketSearchResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }
    }
}
