using System.Collections.Generic;

namespace WeatherProject.Models
{
    /// <summary>
    /// 地區
    /// </summary>
    public class Location
    {
        /// <summary>
        /// 臺灣各縣市
        /// </summary>
        public string LocationName { get; set; }
        public List<Weatherelement> WeatherElement { get; set; }
    }
}