using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String Datos;
            a=int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r=a+b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String Datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a - b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String Datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            r = a * b;
            Datos = "Resultado: " + r.ToString();
            label1.Text = Datos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, r;
            String Datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if (b == 0)
            {
                MessageBox.Show("Error no se Puede Dividir entre 0","Error");
            }
            else
            {
                r = a / b;
                Datos = "Resultado: " + r.ToString();
                label1.Text = Datos;
            }
        }

      }
}
