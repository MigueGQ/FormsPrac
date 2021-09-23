using System;
using System.Collections.Generic;
using System.Text;

namespace FormNotas.Entidades
{
    class ClsNotas
    {
        //Atributos
        private double laboratorio1;
        private double laboratorio2;
        private double laboratorio3;
        private double parcial1;
        private double parcial2;
        private double parcial3;

        //Encapsulamiento
        public double Laboratorio1 { get => laboratorio1; set => laboratorio1 = value; }
        public double Laboratorio2 { get => laboratorio2; set => laboratorio2 = value; }
        public double Laboratorio3 { get => laboratorio3; set => laboratorio3 = value; }
        public double Parcial1 { get => parcial1; set => parcial1 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }

        //Constructores
        public ClsNotas(double laboratorio1, double laboratorio2, double laboratorio3, double parcial1, double parcial2, double parcial3)
        {
            this.Laboratorio1 = laboratorio1;
            this.Laboratorio2 = laboratorio2;
            this.Laboratorio3 = laboratorio3;
            this.Parcial1 = parcial1;
            this.Parcial2 = parcial2;
            this.Parcial3 = parcial3;
        }

        public ClsNotas()
        {
        }
    }
}
