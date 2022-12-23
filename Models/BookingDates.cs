using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class BookingDates : JsonModel
    {
        [JsonProperty("checkin")]
        public DateTime Checkin { get; set; }

        [JsonProperty("checkout")]
        public DateTime Checkout { get; set; }

        public BookingDates() { }
    }
}
