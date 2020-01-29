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
    public partial class frmMenu : Form
    {

        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

        public frmMenu(/*string user*/)
        {
            InitializeComponent();
            this.Name = "Assistec";
            //Controlo();
            formulario1.Hide();
            lblDataHora2.Show();
            lblDataHora.Hide();
            administracao1.Hide();
            faturaçao1.Hide();
            MostrarAgenda();
            //lblUser.Text = user;
            //****************************************************************************************
            //SqlCommand command = new SqlCommand("select utilizador from funcionario where utilizador = @utilizador", sql);
            //command.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = user;

            //try
            //{
            //    sql.Open();
            //    SqlDataReader drms = command.ExecuteReader();
            //    drms.Read();
            //    user = Convert.ToString(drms["utilizador"]);
                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    sql.Close();
            //}
            //****************************************************************************************
            
        }

        //public void Controlo()
        //{
        //    SqlCommand command = new SqlCommand("select tipoconta from funcionario where utilizador = @utilizador", sql);
        //    command.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = lblUser.Text;
            
        //    try
        //    {
        //        sql.Open();
        //        SqlDataReader drms = command.ExecuteReader();
        //        drms.Read();
        //        lblTipoConta.Text = Convert.ToString(drms["tipoconta"]);

        //       if (lblTipoConta.Text != "Admin")
        //        {
        //            btnAdministracao.Hide();
        //            //}
        //            //else if (lblTipoConta.Text == "Administrador")
        //            //{
        //            //    btnAdministracao.Show();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        sql.Close();
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair do programa?"
                            , "Sair",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question)==DialogResult.Yes)
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dddd, dd MMMM, HH:mm:ss ");
            lblDataHora2.Text = DateTime.Now.ToString("dddd, dd MMMM, HH:mm:ss ");
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            administracao1.Hide();
            faturaçao1.Hide();
            OcultarAgenda();
            lblDataHora2.Hide();
            lblDataHora.Show();
            calculadora1.Hide();
            formulario1.Show();
        }

        private void btnAdministracao_Click(object sender, EventArgs e)
        {
            formulario1.Hide();
            faturaçao1.Hide();
            OcultarAgenda();
            lblDataHora2.Hide();
            lblDataHora.Show();
            calculadora1.Hide();
            administracao1.Show();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            txtAgenda.Text = lstAgenda.Text;
        }

        private void OcultarAgenda()
        {
            lstAgenda.Hide();
            txtAgenda.Hide();
            BtnOk.Hide();
        }

        private void MostrarAgenda()
        {
            lstAgenda.Show();
            txtAgenda.Show();
            BtnOk.Show();
        }

        private void btnfaturaçao_Click(object sender, EventArgs e)
        {
            formulario1.Hide();
            administracao1.Hide();
            faturaçao1.Show();
            MostrarAgenda();
            lblDataHora2.Hide();
            lblDataHora.Show();
            calculadora1.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formulario1.Hide();
            administracao1.Hide();
            faturaçao1.Hide();
            MostrarAgenda();
            calculadora1.Show();
            lblDataHora2.Show();
            lblDataHora.Hide();
        }
        
        private void btnListarDados_Click(object sender, EventArgs e)
        {
            ApresentarDados apresentarDados = new ApresentarDados();
            apresentarDados.ShowDialog();
        }
        
    }
}

//200; 51 Localização