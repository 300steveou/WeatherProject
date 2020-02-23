using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WeatherProject.Enums
{
    public enum ApiMethodEnum
    {
        /// <summary>
        /// 一般天氣預報-今明 36 小時天氣預報
        /// </summary>
        [Description("F-C0032-001?&Authorization={0}")]
        General = 0,

        /// <summary>
        /// 鄉鎮天氣預報-臺北市未來1週天氣預報
        /// </summary>
        [Description("F-D0047-063?&Authorization={0}")]
        TaipeiWeek = 1,
    }
}