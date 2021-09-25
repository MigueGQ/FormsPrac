using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPesoIdeal.Entidades;

namespace WFPesoIdeal.Negocio
{
    class NClsPersona
    {
        public string CalcIMC (ClsPersona clspersona)
        {
            double pro = clspersona.Peso / Math.Pow(clspersona.Altura, 2);
            if (pro <= 20)
            {
                return"Su IMC es de " + pro + " y su peso es normal";
            }
            else
                return "Su IMC es de " + pro + " y tiene sobre peso";
        }

        public string MayorEdad (ClsPersona clsPersona)
        {
            if (clsPersona.Edad >= 18)
            {
                return "Ustes es maayor de edad";
            }

            else
                return "Usted es menor de edad";
        }
    }
}
