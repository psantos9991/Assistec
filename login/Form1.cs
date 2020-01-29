using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=backtech;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

            SqlCommand command = new SqlCommand("select * from usuario where logins = @logins and senha = @senha", sql);
            command.Parameters.Add("@logins", SqlDbType.VarChar).Value = txtUser.Text;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtPass.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Usuário ou senha incorretos!");
                }
                drms.Read();
                MessageBox.Show("Login efectuado com sucesso!");
                frmMenu Menu = new frmMenu(/*txtUser.Text*/);//entrar no painel principal
                Menu.Show();
                this.Visible = false;
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
        
    }
}
