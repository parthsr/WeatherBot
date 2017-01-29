using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;

namespace WeatherBot
{
    class WeatherThings
    {
        public static String[] Weather(String location)
        {
            String desc="", temp="";String ImageUrl="";
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=680aaaa5258e15d43253263b8c9da7f3",
                location);
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                if (json.Contains("visibility"))
                {

                    Rootobject weatherInfo = (new JavaScriptSerializer()).Deserialize<Rootobject>(json);
                    desc = weatherInfo.weather[0].description;
                    ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png",
                         weatherInfo.weather[0].icon);
                    temp = weatherInfo.main.temp.ToString();
                }
                else {
                    Rootobject1 weatherInfo = (new JavaScriptSerializer()).Deserialize<Rootobject1>(json);
                    desc = weatherInfo.weather[0].description;
                    ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png",
                         weatherInfo.weather[0].icon);
                    temp = weatherInfo.main.temp.ToString();

                }
            }
            string[] final = new string[2];

            final[0] = "TEMP: " + temp + " DESCRIPTION: " + desc;
            final[1] = ImageUrl;
            return final;
        }
    }
}