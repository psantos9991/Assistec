using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Calculadora : UserControl
    {
        string operador;
        int a = 0;
        bool validar = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNumerador(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (validar==true)
            {
                a = a + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a);
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btnMais.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
             }



        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a);
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btnMenos.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }

        }

        private void btnvezes_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar == true)
                {
                    a = a * Convert.ToInt32(txtValor.Text);
                    label1.Text = Convert.ToString(a);
                    txtValor.Text = "*";
                    operador = "*";
                }
                else
                {
                    label1.Text = txtValor.Text + btnvezes.Text;
                    a = Convert.ToInt32(txtValor.Text);
                    txtValor.Text = "";
                    operador = "*";
                    validar = true;
                }

            }
            catch (Exception h)
            {
                MessageBox.Show(Environment.NewLine + h);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar == true)
                {
                    a = a / Convert.ToInt32(txtValor.Text);
                    label1.Text = Convert.ToString(a);
                    txtValor.Text = "";
                    operador = "/";
                }
                else
                {
                    label1.Text = txtValor.Text + btnDividir.Text;
                    a = Convert.ToInt32(txtValor.Text);
                    txtValor.Text = "";
                    operador = "/";
                    validar = true;
                }
            }
            catch (Exception h)
            {
                MessageBox.Show(Environment.NewLine + h);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (operador == "+")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a + Convert.ToInt32(txtValor.Text));
                }
                if (operador == "-")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a - Convert.ToInt32(txtValor.Text));
                }
                if (operador == "*")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a * Convert.ToInt32(txtValor.Text));
                }
                if (operador == "/")
                {
                    label1.Text = label1.Text + txtValor.Text + "=";
                    txtValor.Text = Convert.ToString(a / Convert.ToInt32(txtValor.Text));
                }
            }
            catch (Exception h)
            {
                MessageBox.Show(Environment.NewLine + h);
            }
        }
    }
}
