using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPesoIdeal.Entidades;
using WFPesoIdeal.Negocio;

namespace WFPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string genero = TxtGenero.Text;
            int edad = Convert.ToInt32(TxtEdad.Text);
            double peso = Convert.ToDouble(TxtPeso.Text);
            double altura = Convert.ToDouble(TxtAltura.Text);

            ClsPersona clspersona = new ClsPersona(nombre, genero, edad, peso, altura);
            NClsPersona nclspersona = new NClsPersona();

            MessageBox.Show(nclspersona.CalcIMC(clspersona));
            MessageBox.Show(nclspersona.MayorEdad(clspersona));
            MessageBox.Show(clspersona.ToString());
        }
    }
}
