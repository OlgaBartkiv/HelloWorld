using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace HelloWorld
{
    public class RestSharpCases
    {
        string BaseUrl = "https://restful-booker.herokuapp.com/";

        public async Task<string> GetToken()
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("auth", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var data = new Dictionary<string, string>
            {
                {"username", "admin"},
                {"password", "password123"}
            };
            request.AddBody(data);
            RestResponse response = await client.ExecuteAsync(request);
            var token = response.Content.DeserializeJson<AuthToken>();
            return token.Token;
        }

        public async Task GetBookingIDs()
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("booking", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            var bookingIds = response.Content;
            var bookingIdsRaw = JsonConvert.DeserializeObject<List<BookingID>>(bookingIds);
            foreach (var bookingId in bookingIdsRaw)
            {
                Debug.WriteLine(bookingId.BookingId);
            }
        }

        public async Task GetBookingById(int Id)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"booking/{Id}", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = await client.ExecuteAsync(request);
            var bookingInfo = response.Content;
            var bookingInfoRaw = JsonConvert.DeserializeObject<BookingInfo>(bookingInfo);
            Debug.WriteLine($" {bookingInfoRaw.FirstName}, {bookingInfoRaw.LastName}, {bookingInfoRaw.TotalPrice}, {bookingInfoRaw.DepositPaid}, {bookingInfoRaw.BookingDates.Checkin}, {bookingInfoRaw.BookingDates.Checkout}, {bookingInfoRaw.AdditionalNeeds}");
        }

        public async Task UpdateBookingById(int Id)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"booking/{Id}", Method.Patch);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Cookie", $"token={GetToken().Result}");
            var data = new Dictionary<string, string>
            {
                {"firstname", "Olga"},
                {"lastname", "Bartkiv"}
            };
            request.AddBody(data);
            RestResponse response = await client.ExecuteAsync(request);
            var updatedBooking = response.Content;
            var bookingInfoRaw = JsonConvert.DeserializeObject<BookingInfo>(updatedBooking);
            Debug.WriteLine($" {bookingInfoRaw.FirstName}, {bookingInfoRaw.LastName}");
        }

        public async Task DeleteBookingById(int Id)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"booking/{Id}", Method.Delete);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", $"token={GetToken().Result}");
            RestResponse response = await client.ExecuteAsync(request);
            Debug.WriteLine(response.StatusCode);

        }

        public async Task GetDeletedBookingById(int Id)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest($"booking/{Id}", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content;
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
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("booking", Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddBody(stringNewBooking);
            RestResponse response = await client.ExecuteAsync(request);
            Debug.WriteLine(response.Content);
        }
    }
}
