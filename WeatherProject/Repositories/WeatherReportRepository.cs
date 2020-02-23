using System.Collections.Generic;
using System.Linq;
using WeatherProject.Interfaces.Repositories;
using WeatherProject.Models.Entities;

namespace WeatherProject.Repositories
{
    /// <summary>
    /// 天氣預報儲存庫
    /// </summary>
    public class WeatherReportRepository : IWeatherReportRepository
    {
        /// <summary>
        /// DB儲存庫
        /// </summary>
        private readonly WeatherDBEntities WeatherDBEntities;

        /// <summary>
        /// 建構子
        /// </summary>
        public WeatherReportRepository()
        {
            this.WeatherDBEntities = new WeatherDBEntities();
        }

        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns>天氣預報列表</returns>
        public IEnumerable<WeatherReportTable> GetAll()
        {
            return this.WeatherDBEntities.WeatherReportTables.ToList();
        }

        /// <summary>
        /// 取得該編號資料
        /// </summary>
        /// <param name="id">編號</param>
        /// <returns>天氣預報模型</returns>
        public WeatherReportTable Get(int id)
        {
            return this.WeatherDBEntities.WeatherReportTables.Find(id);
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="obj">天氣預報模型</param>
        public void Add(WeatherReportTable obj)
        {
            this.WeatherDBEntities.WeatherReportTables.Add(obj);
            this.Save();
        }

        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id">欲刪除編號</param>
        public void Delete(int id)
        {
            WeatherReportTable value = this.WeatherDBEntities
                                      .WeatherReportTables.Where(i => i.WeatherReportId == id)
                                      .FirstOrDefault();

            this.WeatherDBEntities.WeatherReportTables.Remove(value);

            this.Save();
        }

        /// <summary>
        /// 儲存
        /// </summary>
        public void Save()
        {
            this.WeatherDBEntities.SaveChanges();
        }
    }
}