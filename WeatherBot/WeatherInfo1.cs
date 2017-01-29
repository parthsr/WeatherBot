using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherBot
{


    public class Coord1
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather1
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main1
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
    }

    public class Wind1
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class Clouds1
    {
        public int all { get; set; }
    }

    public class Sys1
    {
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Rootobject1
    {
        public Coord1 coord{ get; set; }
        public List<Weather1> weather { get; set; }
        public string @base { get; set; }
        public Main1 main { get; set; }
        public Wind1 wind { get; set; }
        public Clouds1 clouds { get; set; }
        public int dt { get; set; }
        public Sys1 sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }


}

