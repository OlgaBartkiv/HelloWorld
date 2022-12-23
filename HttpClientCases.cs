using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HttpClientCases
    {
        string BaseUrl = "https://restful-booker.herokuapp.com/";

        public async Task<string> GetToken()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var data = new Dictionary<string, string>
                    {
                        {"username", "admin"},
                        {"password", "password123"}
                    };
                var response = await client.PostAsync(BaseUrl + "auth", new FormUrlEncodedContent(data));
                response.EnsureSuccessStatusCode();
                var token = await response.Content.ReadAsStringAsync();
                var tokenRaw = token.DeserializeJson<AuthToken>();
                return tokenRaw.Token;
            }
        }

        public async Task GetBookingIDs()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(BaseUrl + "booking");
                    response.EnsureSuccessStatusCode();
                    var bookingIds = await response.Content.ReadAsStringAsync();
                    var bookingIdsRaw = JsonConvert.DeserializeObject<List<BookingID>>(bookingIds);

                    foreach (var bookingId in bookingIdsRaw)
                    {
                        Debug.WriteLine(bookingId.BookingId);
                    }              
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        public async Task GetBookingById(int Id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(BaseUrl + $"booking/{Id}");
                    var bookingInfo = await response.Content.ReadAsStringAsync();
                    var bookingInfoRaw = JsonConvert.DeserializeObject<BookingInfo>(bookingInfo);
                    Debug.WriteLine($" {bookingInfoRaw.FirstName}, {bookingInfoRaw.LastName}, {bookingInfoRaw.TotalPrice}, {bookingInfoRaw.DepositPaid}, {bookingInfoRaw.BookingDates.Checkin}, {bookingInfoRaw.BookingDates.Checkout}, {bookingInfoRaw.AdditionalNeeds}");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }

            }
        }

        public async Task UpdateBookingById(int Id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Cookie", $"token={GetToken().Result}");
                    var data = new Dictionary<string, string>
                    {
                        {"firstname", "Olga"},
                        {"lastname", "Bartkiv"}
                    };
                    var response = await client.PatchAsync(BaseUrl + $"booking/{Id}", new FormUrlEncodedContent(data));
                    response.EnsureSuccessStatusCode();
                    var updatedBooking = await response.Content.ReadAsStringAsync();
                    response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var bookingInfoRaw = JsonConvert.DeserializeObject<BookingInfo>(updatedBooking);
                    Debug.WriteLine($" {bookingInfoRaw.FirstName}, {bookingInfoRaw.LastName}");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        public async Task DeleteBookingById(int Id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Cookie", $"token={GetToken().Result}");
                    var response = await client.DeleteAsync(BaseUrl + $"booking/{Id}");
                    response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    response.EnsureSuccessStatusCode();
                    Debug.WriteLine(response.StatusCode);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        public async Task GetDeletedBookingById(int Id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(BaseUrl + $"booking/{Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine(result);
                    }
                    Debug.WriteLine(response.StatusCode);
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
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
            using (var client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(BaseUrl + "booking", httpContent);
                    response.EnsureSuccessStatusCode();
                    var updatedBooking = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(updatedBooking);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }


    }
}
