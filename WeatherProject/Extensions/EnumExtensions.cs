using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace WeatherProject.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets an attribute on an enum field value
        /// </summary>
        /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
        /// <param name="enumVal">The enum value</param>
        /// <returns>The attribute of type T that exists on the enum value</returns>
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            Type type = enumVal.GetType();
            MemberInfo[] memInfo = type.GetMember(enumVal.ToString());

            if (memInfo.Length > 0)
            {
                object[] attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
                return (T)attributes.FirstOrDefault();
            }

            return null;
        }
    }
}