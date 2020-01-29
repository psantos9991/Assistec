using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Administracao : UserControl
    {
        //conexao com a base de dados
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

        public Administracao()
        {
            InitializeComponent();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar guardar = new Guardar();
            guardar.Funcionario(txtNome.Text.Trim(), txtUser.Text.Trim(), txtPassword.Text.Trim(), comboConta.Text.Trim());

            txtNome.Text = txtUser.Text = txtPassword.Text = comboConta.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Pesquisar pesquisar = new Pesquisar();
            //pesquisar.PesquisarFuncionario(txtUserControl.Text, txtNome.Text, txtUser.Text, txtPassword.Text, comboConta.Text);


           


            SqlCommand command = new SqlCommand("select * from funcionario where utilizador = @utilizador", sql);
            command.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = txtUserControl.Text;


            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Utilizador não encontrado!");
                }
                drms.Read();
                //userControl = Convert.ToString(drms["utilizador"]);
                txtNome.Text = Convert.ToString(drms["nome"]);
                txtUser.Text = Convert.ToString(drms["utilizador"]);
                txtPassword.Text = Convert.ToString(drms["palavrapasse"]);
                comboConta.Text = Convert.ToString(drms["tipoconta"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            Alterar alterar = new Alterar();
            alterar.AlterarFunc(txtNome.Text.Trim(), txtUser.Text.Trim(),
                                txtPassword.Text, comboConta.Text, txtUserControl.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Apagar apagar = new Apagar();

            apagar.ApagarUser(txtUserControl.Text);
            Limpar();
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtPassword.Text = "";
            txtUser.Text = "";
            txtUserControl.Text = "";
            comboConta.Text = "";


        }
        
    }
}
