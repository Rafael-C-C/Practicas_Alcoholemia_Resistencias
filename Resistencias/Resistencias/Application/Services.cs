using System;
using System.Collections.Generic;
using System.Linq;

namespace Resistencias.Application
{
    public class Services
    {
        public string calcu_resistencia(string color1, string color2, string color3, string color4)
        {
            string valor = "";
            int resis = 0;
            double tole = 0;
            string porcen = "";

            string Color1 = color1.ToLower();
            string Color2 = color2.ToLower();
            string Color3 = color3.ToLower();
            string Color4 = color4.ToLower();

            switch(Color1)
            {
                case "negro":
                    valor = "0";
                    break;
                case "cafe":
                    valor = "1";
                    break;
                case "rojo":
                    valor = "2";
                    break;
                case "naranja":
                    valor = "3";
                    break;
                case "amarillo":
                    valor = "4";
                    break;
                case "verde":
                    valor = "5";
                    break;
                case "azul":
                    valor = "6";
                    break;
                case "violeta":
                    valor = "7";
                    break;
                case "gris":
                    valor = "8";
                    break;
                case "blanco":
                    valor = "9";
                    break;
                default:
                    return "Color No valido Para La Banda 1";
            }

            switch(Color2)
            {
                case "negro":
                    valor += "0";
                    break;
                case "cafe":
                    valor += "1";
                    break;
                case "rojo":
                    valor += "2";
                    break;
                case "naranja":
                    valor += "3";
                    break;
                case "amarillo":
                    valor += "4";
                    break;
                case "verde":
                    valor += "5";
                    break;
                case "azul":
                    valor += "6";
                    break;
                case "violeta":
                    valor += "7";
                    break;
                case "gris":
                    valor += "8";
                    break;
                case "blanco":
                    valor += "9";
                    break;
                default:
                    return "Color No valido Para La Banda 2";
            }
            
            switch(Color3)
            {
                case "negro":
                    resis = Convert.ToInt32(valor) * 1;
                    break;
                case "cafe":
                    resis = Convert.ToInt32(valor) * 10;
                    break;
                case "rojo":
                    resis = Convert.ToInt32(valor) * 100;
                    break;
                case "naranja":
                    resis = Convert.ToInt32(valor) * 1000;
                    break;
                case "amarillo":
                    resis = Convert.ToInt32(valor) * 10000;
                    break;
                case "verde":
                    resis = Convert.ToInt32(valor) * 100000;
                    break;
                case "azul":
                    resis = Convert.ToInt32(valor) * 1000000;
                    break;
                    default:
                    return "Color No valido Para La Banda 3";
            }

            switch(Color4)
            {
                case "rojo":
                    tole = resis * 0.02;
                    porcen= "2%";
                    break;
                case "dorado":
                    tole = resis * 0.05;
                    porcen = "5%";
                    break;
                case "plata":
                    tole = resis * 0.1;
                    porcen = "10%";
                    break;
                default:
                    return "Color No valido Para La Banda 4";
            }

            string result = "La resistencia es de .... " + resis + "Ω y posee una tolerancia del... " + porcen + ", por lo tanto puede soportar valores de... " + (resis + tole) + "Ω y " + (resis - tole) + "Ω";
            return result;
        }
    }
}