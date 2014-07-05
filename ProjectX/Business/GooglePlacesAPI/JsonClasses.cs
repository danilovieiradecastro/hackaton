using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Business.GooglePlacesAPI
{
    public class AddressComponent
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<string> types { get; set; }
    }

    public class Event
    {
        public string event_id { get; set; }
        public int start_time { get; set; }
        public string summary { get; set; }
        public string url { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Geometry
    {
        public Location location { get; set; }
    }

    public class Aspect
    {
        public int rating { get; set; }
        public string type { get; set; }
    }

    public class Review
    {
        public List<Aspect> aspects { get; set; }
        public string author_name { get; set; }
        public string author_url { get; set; }
        public string text { get; set; }
        public object time { get; set; }
    }

    public class Result
    {
        public List<AddressComponent> address_components { get; set; }
        public List<Event> events { get; set; }
        public string formatted_address { get; set; }
        public string formatted_phone_number { get; set; }
        public Geometry geometry { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public string international_phone_number { get; set; }
        public string name { get; set; }
        public double rating { get; set; }
        public string reference { get; set; }
        public List<Review> reviews { get; set; }
        public List<string> types { get; set; }
        public string url { get; set; }
        public string vicinity { get; set; }
        public string website { get; set; }
    }

    public class GooglePlacesAPIRootObject
    {
        public List<object> html_attributions { get; set; }
        public Result result { get; set; }
        public string status { get; set; }
    }
}