using System.Collections.Generic;

namespace WeatherProject.Models
{
    /// <summary>
    /// 紀錄
    /// </summary>
    public class Records
    {
        /// <summary>
        /// 查詢名稱
        /// </summary>
        public string DatasetDescription { get; set; }
        
        /// <summary>
        /// 地區
        /// </summary>
        public List<Location> Location { get; set; }
    }
}