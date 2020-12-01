using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServerAppWebAPI.Models;

namespace ServerAppWebAPI.Controllers
{
    public class WeatherController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, WeatherDataStorage.GetAll());
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPost]
        public HttpResponseMessage GetByCityName([FromBody] string cityName)
        {
            try
            {
                WeatherDataStorage.GetByCityName(cityName);
                return Request.CreateResponse(HttpStatusCode.OK, WeatherDataStorage.GetByCityName(cityName));
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
           
        }

        [HttpPost]
        public HttpResponseMessage AddCity([FromBody] WeatherData weatherData)
        {
            try
            {
                WeatherDataStorage.AddCity(weatherData);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage DeleteCityByName([FromBody] string cityName)
        {
            try
            {
              
                if (WeatherDataStorage.DeleteCityByName(cityName))
                { 
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Такого города не существует");
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage GetException([FromBody] bool isExp)
        {
            if (isExp == true)
            {
                return Request.CreateResponse(
                    HttpStatusCode.BadRequest, "sample error"
                    );
            }
            else
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK, new WeatherData() { CityName = "AAA", Temperature = 111 }
                    );
            }
        }

    }
}
