using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaDeLasSemanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);

            string diadelaSemana = "";

            switch (numero)
            {
                case 1:
                    diadelaSemana = "Lunes";
                    break;
                case 2:
                    diadelaSemana = "Martes";
                    break;
                case 3:
                    diadelaSemana = "Miércoles";
                    break;
                case 4:
                    diadelaSemana = "Jueves";
                    break;
                case 5:
                    diadelaSemana = "Viernes";
                    break;
                case 6:
                    diadelaSemana = "Sábado";
                    break;
                case 7:
                    diadelaSemana = "Domingo";
                    break;
                default:
                    MessageBox.Show("Número no válido.");
                    return;
            }

            MessageBox.Show("El número " + numero + " es " + diadelaSemana + ".");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void diaslabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
