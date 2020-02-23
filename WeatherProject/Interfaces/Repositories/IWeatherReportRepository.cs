using System.Collections.Generic;
using WeatherProject.Models.Entities;

namespace WeatherProject.Interfaces.Repositories
{
    /// <summary>
    /// 天氣預報儲存庫介面
    /// </summary>
    public interface IWeatherReportRepository
    {
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns>天氣預報列表</returns>
        IEnumerable<WeatherReportTable> GetAll();

        /// <summary>
        /// 取得該編號資料
        /// </summary>
        /// <param name="id">編號</param>
        /// <returns>天氣預報模型</returns>
        WeatherReportTable Get(int id);

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="obj">天氣預報模型</param>
        void Add(WeatherReportTable obj);

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">欲刪除編號</param>
        void Delete(int id);

        /// <summary>
        /// 儲存
        /// </summary>
        void Save();
    } 
}