using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherProject.Models
{
    /// <summary>
    /// 天氣因子
    /// </summary>
    public class Weatherelement
    {
        /// <summary>
        /// 
        /// </summary>
        public string ElementName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public List<Time> Time { get; set; }
    }
}