using System.Collections.Generic;

namespace WeatherProject.Models.ViewModels
{
    /// <summary>
    /// 天氣預報Json物件
    /// </summary>
    public class WeatherViewModel
    {
        /// <summary>
        /// 狀態
        /// </summary>
        public string Success { get; set; }
        
        /// <summary>
        /// 結果
        /// </summary>
        public Result Result { get; set; }
        
        /// <summary>
        /// 紀錄
        /// </summary>
        public Records Records { get; set; }
    }
}