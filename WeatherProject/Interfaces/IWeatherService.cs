using System.Collections.Generic;
using WeatherProject.Models.ViewModels;

namespace WeatherProject
{
    /// <summary>
    /// 天氣介面
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// 取得一般天氣
        /// </summary>
        /// <returns>天氣預報列表</returns>
        List<WeatherReportViewModel> GetGeneralWeather();

        /// <summary>
        /// 
        /// </summary>
        void Create();
    }
}
