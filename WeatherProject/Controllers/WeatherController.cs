using System.Collections.Generic;
using System.Web.Mvc;
using WeatherProject.Models.ViewModels;

namespace WeatherProject.Controllers
{
    /// <summary>
    /// 天氣預報控制器
    /// </summary>
    public class WeatherController : Controller
    {
        /// <summary>
        /// 天氣預報服務
        /// </summary>
        private readonly IWeatherService WeatherService;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="weatherService">天氣預報服務</param>
        public WeatherController(IWeatherService weatherService)
        {
            this.WeatherService = weatherService;
        }

        /// <summary>
        /// 氣象首頁
        /// </summary>
        /// <returns>檢視</returns>
        public ActionResult Index()
        {            
            List<WeatherReportViewModel> model = this.WeatherService.GetGeneralWeather();
            return this.View(model);
        }
    }
}