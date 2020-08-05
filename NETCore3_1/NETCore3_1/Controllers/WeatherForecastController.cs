using Microsoft.AspNetCore.Mvc;
using NETCore3_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NETCore3_1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public int GetService([FromServices]ISingletonService singleton1,
                              [FromServices]ISingletonService singleton2,
                              [FromServices]IScopedService scoped1,
                              [FromServices]IScopedService scoped2,
                              [FromServices]ITransientService transient1,
                              [FromServices]ITransientService transient2)
        {
            Console.WriteLine($"singleton1:{singleton1.GetHashCode()}");
            Console.WriteLine($"singleton2:{singleton2.GetHashCode()}");

            Console.WriteLine($"scoped1:{scoped1.GetHashCode()}");
            Console.WriteLine($"scoped2:{scoped2.GetHashCode()}");

            Console.WriteLine($"transient1:{transient1.GetHashCode()}");
            Console.WriteLine($"transient2:{transient2.GetHashCode()}");
            Console.WriteLine($"===================请求结束=========================");

            return 1;
        }
    }
}
