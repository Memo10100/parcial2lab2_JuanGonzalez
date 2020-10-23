using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2lab2_JuanGonzalez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCamisa.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = true;
            }
        }

        private void rbpantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbpantalon .Checked == true)
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Precio_Base = 0;
            int Cantidad = 0;
            bool Calidad = false;
            bool esManga_Corta = (checkBox1.Checked);
            bool esBermuda = (checkBox2.Checked);

            
  
            Precio_Base = Convert.ToDouble(textBox1.Text);
            Cantidad = Convert.ToInt32(textBox2.Text);
            Calidad = (radioButton5.Checked);

            Camisa C1 = new Camisa(Cantidad, Calidad, Precio_Base, esManga_Corta);
            Pantalon P1 = new Pantalon(Cantidad, Calidad, Precio_Base, esBermuda);

            if (rbCamisa.Checked == true)
            {
                MessageBox.Show("El Precio es " + C1.Calcular_precio());
            }
            if (rbpantalon.Checked == true)
            {
                MessageBox.Show("El Precio es " + P1.Calcular_precio());
            }

            //Precio_Base, Cantidad, Calidad, esManga_Corta


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
