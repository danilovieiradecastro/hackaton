using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Models
{

    public class PlacesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Img { get; set; }
    }
    public class MainPageViewModel
    {
        public List<PlacesViewModel> Places { get; set; } 
    }
}