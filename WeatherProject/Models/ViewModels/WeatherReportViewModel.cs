using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WeatherProject.Models.ViewModels
{
    /// <summary>
    /// 天氣預報ViewModel
    /// </summary>
    public class WeatherReportViewModel
    {
        /// <summary>
        /// 項次
        /// </summary>
        [DisplayName("項次")]
        public int ItemId { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [DisplayName("城市")]
        public string City { get; set; }

        /// <summary>
        /// 天氣
        /// </summary>
        [DisplayName("天氣")]
        public string Weather { get; set; }

        /// <summary>
        /// 最高溫度
        /// </summary>
        [DisplayName("最高溫度")]
        public string MaxTemperature { get; set; }

        /// <summary>
        /// 最低溫度
        /// </summary>
        [DisplayName("最低溫度")]
        public string MinTemperature { get; set; }

        /// <summary>
        /// 降雨機率
        /// </summary>
        [DisplayName("降雨機率")]
        public string RainRate { get; set; }

        /// <summary>
        /// 開始時間
        /// </summary>
        [DisplayName("開始時間")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 結束時間
        /// </summary>
        [DisplayName("結束時間")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime EndDate { get; set; }
    }
}