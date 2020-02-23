using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using WeatherProject.Enums;
using WeatherProject.Extensions;
using WeatherProject.Interfaces.Repositories;
using WeatherProject.Models;
using WeatherProject.Models.Entities;
using WeatherProject.Models.ViewModels;

namespace WeatherProject.Services
{
    /// <summary>
    /// 天氣服務
    /// </summary>
    public class WeatherService : IWeatherService
    {
        /// <summary>
        /// 驗證碼
        /// </summary>
        private static readonly string AuthKey = ConfigurationManager.AppSettings["WeatherAuthCode"];

        /// <summary>
        /// api路徑
        /// </summary>
        private static readonly string WeatherApi = ConfigurationManager.AppSettings["WeatherApi"];

        /// <summary>
        /// 天氣服務儲存庫
        /// </summary>
        private readonly IWeatherReportRepository WeatherReportRepository;

        /// <summary>
        /// 天氣服務
        /// </summary>
        /// <param name="weatherReportRepository">天氣預報儲存庫</param>
        public WeatherService(IWeatherReportRepository weatherReportRepository)
        {
            this.WeatherReportRepository = weatherReportRepository;
        }

        /// <summary>
        /// 一般天氣預報
        /// </summary>
        /// <returns>檢視</returns>
        public List<WeatherReportViewModel> GetGeneralWeather()
        {
            string url = WeatherApi + string.Format(ApiMethodEnum.General.GetAttributeOfType<DescriptionAttribute>().Description, AuthKey);
            WeatherViewModel weatherViewModel = this.GetData(url);
            List<WeatherReportViewModel> result = this.MappingModel(weatherViewModel);

            return result;
        }



        public void Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 取得api回傳資料
        /// </summary>
        /// <returns></returns>
        private WeatherViewModel GetData(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.Timeout = 10000;
            httpWebRequest.Method = nameof(HttpMethodEnum.Get);

            using (HttpWebResponse respone = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (StreamReader streamReader = new StreamReader(respone.GetResponseStream(), Encoding.UTF8))
                {
                    string outputData = streamReader.ReadToEnd();
                    WeatherViewModel result = JsonConvert.DeserializeObject<WeatherViewModel>(outputData);

                    return result;
                }
            }
        }

        /// <summary>
        /// mapping模型
        /// </summary>
        /// <param name="model">模型</param>
        /// <returns>天氣預報列表</returns>
        private List<WeatherReportViewModel> MappingModel(WeatherViewModel model)
        {
            List<WeatherReportViewModel> result = new List<WeatherReportViewModel>();

            int index = 1;
            foreach (Location item in model.Records.Location)
            {
                WeatherReportViewModel weatherReportViewModel = new WeatherReportViewModel
                {
                    ItemId = index,
                    City = item.LocationName,
                    Weather = item.WeatherElement[0].Time[0].Parameter.ParameterName,
                    RainRate = item.WeatherElement[1].Time[0].Parameter.ParameterName,
                    MaxTemperature = item.WeatherElement[2].Time[0].Parameter.ParameterName,
                    MinTemperature = item.WeatherElement[4].Time[0].Parameter.ParameterName,
                    StartDate = item.WeatherElement[4].Time[0].StartTime,
                    EndDate = item.WeatherElement[4].Time[0].EndTime,
                };

                result.Add(weatherReportViewModel);
                index++;
            }
             
            return result;
        }
    }
}