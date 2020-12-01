using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ServerAppWebAPI.Models
{
    public class WeatherDataStorage
    {
        private static List<WeatherData> dataList = new List<WeatherData>()
        {
            new WeatherData()
            {
                CityName = "Брянск",
                Temperature = 1
            },
            new WeatherData()
            {
                CityName = "Москва",
                Temperature = 2
            },
            new WeatherData()
            {
                CityName = "Волгоград",
                Temperature = 2
            }
        };

        public static bool DeleteCityByName(string cityName)
        {
            try
            {
               return dataList.Remove(GetByCityName(cityName));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void AddCity(WeatherData weatherData)
        {
            try
            {
                dataList.Add(weatherData);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<WeatherData> GetAll()
        {
            try
            {
                return dataList;
            }
            catch (Exception e)
            {
                throw e;
            }
          
        }

        public static WeatherData GetByCityName(string cityName)
        {
            try
            {
                return dataList.FirstOrDefault(item => item.CityName == cityName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}