using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Newtonsoft.Json;
using RestSharp;

namespace HelloWorld.Helpers
{
    public class HttpClientWrapper
    {
        private readonly HttpClient _client;

        private readonly string _token;

        public HttpClientWrapper(string baseUrl)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseUrl);
            _token = GetToken().Result;
        }

        public async Task<string> GetToken()
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var data = new Dictionary<string, string>
            {
                {"username", "admin"},
                {"password", "password123"}
            };
            var response = await _client.PostAsync("auth", new FormUrlEncodedContent(data));
            response.EnsureSuccessStatusCode();
            var token = await response.Content.ReadAsStringAsync();
            var tokenRaw = token.DeserializeJson<AuthToken>();
            return tokenRaw.Token;

        }

        public async Task GetBookingIDs()
        {
            var response = await _client.GetAsync("booking");
            response.EnsureSuccessStatusCode();
            var bookingIds = await response.Content.ReadAsStringAsync();
            var bookingIdsRaw = JsonConvert.DeserializeObject<List<BookingID>>(bookingIds);

            foreach (var bookingId in bookingIdsRaw)
            {
                Debug.WriteLine(bookingId.BookingId);
            }
        }

        public async Task GetBookingById(int Id)
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _client.GetAsync($"booking/{Id}");
            var bookingInfo = await response.Content.ReadAsStringAsync();
            var bookingInfoRaw = JsonConvert.DeserializeObject<BookingInfo>(bookingInfo);
            Debug.WriteLine($" {bookingInfoRaw.FirstName}, {bookingInfoRaw.LastName}, {bookingInfoRaw.TotalPrice}, {bookingInfoRaw.DepositPaid}, {bookingInfoRaw.BookingDates.Checkin}, {bookingInfoRaw.BookingDates.Checkout}, {bookingInfoRaw.AdditionalNeeds}");
        }

        public async Task UpdateBookingById(int Id)
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Cookie", $"token={_token}");
            var data = new Dictionary<string, string>
            {
                {"firstname", "Olga"},
                {"lastname", "Bartkiv"}
            };
            var response = await _client.PatchAsync($"booking/{Id}", new FormUrlEncodedContent(data));
            response.EnsureSuccessStatusCode();
            var updatedBooking = await response.Content.ReadAsStringAsync();
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var bookingInfoRaw = JsonConvert.DeserializeObject<BookingInfo>(updatedBooking);
            Debug.WriteLine($" {bookingInfoRaw.FirstName}, {bookingInfoRaw.LastName}");
        }

        public async Task DeleteBookingById(int Id)
        {
            _client.DefaultRequestHeaders.Add("Cookie", $"token={_token}");
            var response = await _client.DeleteAsync($"booking/{Id}");
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            response.EnsureSuccessStatusCode();
            Debug.WriteLine(response.StatusCode);
        }

        public async Task GetDeletedBookingById(int Id)
        {
            var response = await _client.GetAsync($"booking/{Id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(result);
            }
            Debug.WriteLine(response.StatusCode);
        }

        public async Task AddNewBooking()
        {
            var newBooking = new BookingInfo
            {
                FirstName = "Santa",
                LastName = "Claus",
                TotalPrice = 2500,
                DepositPaid = true,
                BookingDates = new BookingDates
                {
                    Checkin = DateTime.Parse("2022-12-30"),
                    Checkout = DateTime.Parse("2023-01-01")
                },
                AdditionalNeeds = "Parking for reindeers"
            };
            var stringNewBooking = JsonConvert.SerializeObject(newBooking);
            var httpContent = new StringContent(stringNewBooking, Encoding.UTF8, "application/json");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _client.PostAsync("booking", httpContent);
            response.EnsureSuccessStatusCode();
            var updatedBooking = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(updatedBooking);
        }
    }
}
