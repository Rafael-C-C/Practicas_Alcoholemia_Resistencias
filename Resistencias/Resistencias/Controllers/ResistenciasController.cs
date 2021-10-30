using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Resistencias.Application;
using System.Collections.Generic;

namespace Resistencias.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResistenciasController : ControllerBase
    {
        [HttpPost]
        [Route("Calcular/")]

        public string calcular(string color1, string color2, string color3, string color4)
        {
            var services = new Services();
            var result = services.calcu_resistencia(color1, color2, color3, color4);
            return result;
        }
    }
}