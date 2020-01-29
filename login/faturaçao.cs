using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace login
{
    public partial class faturaçao : UserControl
    {
        public faturaçao()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;
            credenciais.UserName = "";//user name do email
            credenciais.Password = "AgualvaCacem";//password do email

            cliente.Credentials = credenciais;

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("");//email do sistema
            msg.Subject = txtAssunto.Text;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Body = "Sr(a). < strong > " + txtNome.Text+ " </ strong > viemos por este meio informa-lo que o seu aparelho " + txtMarca.Text + " com o número de série " + txtSerNum.Text + " ja se emcontra reparado<br>< br > " + 
            "O preço total é: " + labelPrecoTotal.Text + " </strong>";
            msg.To.Add(txtPara.Text.Trim());

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Email enviado com sucesso", "Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel enviar o email!" +
                                Environment.NewLine + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void checkIva_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ClassIva Iva = new ClassIva();
                double preco_inicial = Convert.ToDouble(txtPreco.Text);
                if (checkIva.Checked)
                {
                    labelPrecoTotal.Text = Iva.CalcularPrecoFinal(preco_inicial).ToString() + " €";
                }
                else labelPrecoTotal.Text = txtPreco.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Não informou o preço", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtNif.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtSerNum.Text = "";
            labelPrecoTotal.Text = "0 €";
            labelPreco.Text = "";
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            labelPrecoTotal.Text = txtPreco.Text + " €";
        }
        
    }
}
