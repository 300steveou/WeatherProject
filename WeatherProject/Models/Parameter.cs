using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherProject.Models
{
    /// <summary>
    /// 參數
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// 參數名稱
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// 參數值
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// 參數單位
        /// </summary>
        public string ParameterUnit { get; set; }
    }
}