using System;
using System.Collections.Generic;
using System.Linq;

namespace Alcoholemia.Application
{
    public class Services
    {
        public string calcular_alcoholemia(string bebida, int cantidad, double peso)
        {
            int ml = 0;
            double gradodealco = 0;
            double alcosan = 0;
            double volSan = 0;
            string mensage = "";

        switch(bebida.ToLower())
            {
                case "cerveza":
                ml = 330;
                gradodealco = 5;
                break;

                case "vino":
                ml = 100;
                gradodealco = 12;
                break;

                case "cava":
                ml = 100;
                gradodealco = 12;
                break;

                case "vermu":
                ml = 70;
                gradodealco = 17;
                break;

                case "licor":
                ml = 45;
                gradodealco = 23;
                break;

                case "brandy":
                ml = 45;
                gradodealco = 38;
                break;

                case "combinado":
                ml = 50;
                gradodealco = 38;
                break;

                default:
                return "Bebida No Valida";
            }

            alcosan = cantidad * ml;
            alcosan = (gradodealco / 100) * alcosan;
            alcosan = 0.15 * alcosan;
            alcosan = 0.789 * alcosan;
            volSan = 0.08 * peso;
            alcosan = alcosan / volSan;
            alcosan = Math.Round(alcosan, 3);

            if (0.8 < alcosan)
            {
                mensage = "Quien hizo la prueba no es apto/a para manejar";
            }
            else
            {
                mensage = "Tenga un excelente viaje";
            }

            string result = "El nivel de alcohol en la sangre es: " + alcosan + "g/l" + mensage;
            return result;
        }
    }
}