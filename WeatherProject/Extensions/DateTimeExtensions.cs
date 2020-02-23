using System;
using System.Globalization;

namespace WeatherProject.Extensions
{
    /// <summary>
    /// 時間擴充方法
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 字串轉時間
        /// </summary>
        /// <param name="content">字串</param>
        /// <param name="format">格式</param>
        /// <param name="culture">地區設定</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTime(this string content, string format, CultureInfo culture)
        {
            try
            {
                DateTime result = DateTime.ParseExact(s: content, format: format, provider: culture);
                return result;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (CultureNotFoundException)
            {
                throw; 
            }
        }
    }
}