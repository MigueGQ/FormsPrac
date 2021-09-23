using FormNotas.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormNotas.Negocio
{
    class NClsNotas
    {
        //Funciones y métodos
        public String calcular(ClsNotas notas)
        {
            //Proceso matemático para calcular las notas
            double periodo1 = notas.Laboratorio1 * 0.40 + notas.Parcial1 * 0.60;
            double periodo2 = notas.Laboratorio2 * 0.40 + notas.Parcial2 * 0.60;
            double periodo3 = notas.Laboratorio3 * 0.40 + notas.Parcial3 * 0.60;
            double ciclo1 = (periodo1 + periodo2 + periodo3)/3;

            //Retorno de lós resultados
            return "\nPrimer periodo: " + periodo1 +
                   "\nSegundo periodo: " + periodo2 +
                   "\nTercer periodo: " + periodo3 +
                   "\nPrimer ciclo: " + ciclo1;
        }
    }
}
