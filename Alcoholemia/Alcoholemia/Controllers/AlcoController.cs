using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Alcoholemia.Application;
using System.Collections.Generic;

namespace Alcoholemia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlcoController : ControllerBase
    {
        [HttpPost]
        [Route("Calcular/")]

        public string calcular(string bebida, int cantidad, double peso)
        {
            var services = new Services();
            var result = services.calcular_alcoholemia(bebida, cantidad, peso);
            return result;
        }
    }
}