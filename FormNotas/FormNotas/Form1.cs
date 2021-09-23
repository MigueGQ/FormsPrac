using FormNotas.Entidades;
using FormNotas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            //Asignación de valores de las cajitas de txt a una variable local
            double laboratorio1 = Convert.ToDouble(TxtLab1.Text);
            double laboratorio2 = Convert.ToDouble(TxtLab2.Text);
            double laboratorio3 = Convert.ToDouble(TxtLab3.Text);
            double parcial1 = Convert.ToDouble(TxtParcial1.Text);
            double parcial2 = Convert.ToDouble(TxtParcial2.Text);
            double parcial3 = Convert.ToDouble(TxtParcial3.Text);

            //Asignación de las variables locales a los parámetros
            ClsNotas notas = new ClsNotas(laboratorio1, laboratorio2, laboratorio3, parcial1, parcial2, parcial3);
            NClsNotas nclsnotas = new NClsNotas();

            //Validación para que la nota no sobre pase de
            if (laboratorio1 > 10 || parcial1 > 10 || laboratorio2 > 10 || parcial2 > 10 || laboratorio3 > 10 || parcial3 > 10)
            {
                MessageBox.Show("ERROR! La nota no puede ser mayor que 10");
            }

            else
            { 
                //Ejecución de la función
                MessageBox.Show(nclsnotas.calcular(notas));
            }
        }
    }
}
