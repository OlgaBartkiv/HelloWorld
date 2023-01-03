using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class BookingID : JsonModel
    {
        [JsonProperty("bookingid")]
        public string BookingId { get; set; }

        public BookingID() { }
    }
}
