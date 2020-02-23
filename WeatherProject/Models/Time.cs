using System;

namespace WeatherProject.Models
{
    /// <summary>
    /// 時間因子
    /// </summary>
    public class Time
    {
        /// <summary>
        /// 開始時間
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 結束時間
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 參數
        /// </summary>
        public Parameter Parameter { get; set; }
    }
}