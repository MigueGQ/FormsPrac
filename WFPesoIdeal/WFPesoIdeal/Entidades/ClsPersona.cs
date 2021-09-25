using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPesoIdeal.Entidades
{
    class ClsPersona
    {
        private string nombre;
        private string genero;
        private int edad;
        private double peso;
        private double altura;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public ClsPersona(string nombre, string genero, int edad, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Genero = genero;
            this.Edad = edad;
            this.Peso = peso;
            this.Altura = altura;
        }

        public ClsPersona()
        {

        }

        public override string ToString()
        {
            return "Querido usuario su nombre es " + Nombre + ", usted es del género " + Genero + 
                    ", tiene " + Edad + " años, pesa " + Peso + "kg y mide " + Altura + "m.";
        }

    }
}
