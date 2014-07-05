using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ProjectX.Business.GooglePlacesAPI
{
    public class GooglePlacesAPI
    {
        private string key = "AIzaSyAkUFML8LL4ofXmhgLhGuEmjyZUIuQY8J0";
        
        public GooglePlacesAPIRootObject GetPlaceDetail(string reference)
        {
            var url = "https://maps.googleapis.com/maps/api/place/details/json?reference={0}&sensor=false&key={1}";

            url = string.Format(url, reference, key);

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

           // Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader loResponseStream = new StreamReader(response.GetResponseStream());

            string result = loResponseStream.ReadToEnd();

            loResponseStream.Close();
            response.Close();

           GooglePlacesAPIRootObject rootObj =  new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<GooglePlacesAPIRootObject>(result);

           return rootObj;
        }
    }
}