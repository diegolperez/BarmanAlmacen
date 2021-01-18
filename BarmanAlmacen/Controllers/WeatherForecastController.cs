using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarmanAlmacen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            //A = 0, B = 1, C = 2
            //0 = Vino, 1 = Ginebra, 2 = Jugo de Limon

            int[,] baldes = new int[3, 3]; //No se si sobrepasamos el tamaño?
            int[] precios = new int[3];
            int[] baldesq = new int[3];
            baldes[0,0] = 20;
            baldes[0,1] = 30;
            baldes[0,2] = 50;
            baldes[1,0] = 30;
            baldes[1,1] = 20;
            baldes[1,2] = 60;
            baldes[2,0] = 30;
            baldes[2,1] = 30;
            baldes[2,2] = 32;

            precios[0] = 5;
            precios[1] = 45;
            precios[2] = 10;

            //Para segunda respuesta
            baldesq[0] = 10;
            baldesq[1] = 4;
            baldesq[2] = 5;

            int[] baldexConst = new int[3]; 
            int[] totalBalde = new int[3];
            int totalFinBalde = 0;

            for (int f = 0; f < 3; f++)
            {
                baldexConst[f] = 0;
                totalBalde[f] = 0;
                for (int c = 0; c < 3; c++)
                {
                    totalBalde[f] += baldes[f, c] * precios[f]; 
                }
                baldexConst[f] = totalBalde[f] * baldesq[f];
                totalFinBalde += baldexConst[f];
            }

            return totalFinBalde;
        }
    }
}
