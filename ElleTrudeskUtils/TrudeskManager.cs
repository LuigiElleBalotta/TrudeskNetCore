using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using ElleTrudeskUtils.Configuration;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ElleTrudeskUtils.Entities;
using ElleTrudeskUtils.Entities.GroupApi;
using ElleTrudeskUtils.Entities.TicketApi;
using ElleTrudeskUtils.Entities.UserApi;
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

        public TrudeskManager(string accesstoken)
        {
            Configuration = ConfigReader.GetConfig();
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(Configuration.TrudeskUrl);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("accesstoken", accesstoken);
        }

        public async Task<TicketCreateResponse> CreateTicket(TicketCreateRequest ticket)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/tickets/create", (TicketCreateRequest)ticket);

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

        public async Task<TicketCreateResponse> UpdateTicket(string id, TicketUpdateRequest ticket)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("api/v1/tickets/" + id, ticket);

            response.EnsureSuccessStatusCode();

            TicketCreateResponse ret = JsonConvert.DeserializeObject<TicketCreateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async void UpdateTicketGroupStatus(string id, TicketUpdateGroupStatus ticket)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("api/v1/tickets/" + id, ticket);

            response.EnsureSuccessStatusCode();
        }

        public async Task<TicketDeleteResponse> DeleteTicket(string id)
        {
            HttpResponseMessage response = await HttpClient.DeleteAsync("api/v1/tickets/" + id);

            response.EnsureSuccessStatusCode();

            TicketDeleteResponse ret = JsonConvert.DeserializeObject<TicketDeleteResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketSearchResponse> GetTicketsByString(string stringa)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/tickets/search/?search=" + stringa);

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

        public async Task<GetUserResponse> GetUser(string username)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/users/" + username);

            response.EnsureSuccessStatusCode();

            GetUserResponse ret = JsonConvert.DeserializeObject<GetUserResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<TicketSearchResponse> GetTicketsMyTickets()
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/tickets");

            response.EnsureSuccessStatusCode();

            TicketSearchResponse ret = new TicketSearchResponse();
            ret.success = true;
            Ticket[] tickets = JsonConvert.DeserializeObject<Ticket[]>(response.Content.ReadAsStringAsync().Result);
            ret.tickets = tickets;
            ret.count = tickets.Length;

            return ret;
        }

        public async Task<InsertUserResponse[]> InsertNewUser(UserInsertRequest[] users)
        {
            List<InsertUserResponse> responses = new List<InsertUserResponse>();
            foreach (UserInsertRequest user in users)
            {
                HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/users/create", user);

                response.EnsureSuccessStatusCode();

                InsertUserResponse ret = JsonConvert.DeserializeObject<InsertUserResponse>(response.Content.ReadAsStringAsync().Result);
                responses.Add(ret);
            }
            return responses.ToArray();
        }

        public async Task<GroupCreateResponse> CreateGroup(GroupCreateRequest request)
        {
            HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/v1/groups/create", request);

            GroupCreateResponse ret = JsonConvert.DeserializeObject<GroupCreateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<GroupGetSingleResponse> GetGroup(string idGroup)
        {
            HttpResponseMessage response = await HttpClient.GetAsync("api/v1/groups/" + idGroup);

            GroupGetSingleResponse ret = JsonConvert.DeserializeObject<GroupGetSingleResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }

        public async Task<GroupUpdateResponse> UpdateGroup(GroupUpdateRequest request, string idGroup)
        {
            HttpResponseMessage response = await HttpClient.PutAsJsonAsync("api/v1/groups/" + idGroup, request);

            GroupUpdateResponse ret = JsonConvert.DeserializeObject<GroupUpdateResponse>(response.Content.ReadAsStringAsync().Result);

            return ret;
        }
    }
}
