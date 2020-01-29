using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    class Pesquisar
    {
        //conexao com a base de dados
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

        public void PesquisarForm(string numobra, string nome, string telemovel, string nif, string morada, string marca, string modelo,
                            string sernum, string aparelho, string estadoapa, string acessorios, string descriavaria)
        {
            SqlCommand command = new SqlCommand("select * from fichaobra where folhaobra = @folhaobra", sql);
            command.Parameters.Add("@folhaobra", SqlDbType.Int).Value = numobra;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Esta folha de obra não foi encontrada!");
                }
                drms.Read();
                numobra = Convert.ToString(drms["folhaobra"]);
                nome = Convert.ToString(drms["nome"]);
                telemovel = Convert.ToString(drms["telemovel"]);
                nif = Convert.ToString(drms["nif"]);
                morada = Convert.ToString(drms["morada"]);
                marca = Convert.ToString(drms["marca"]);
                modelo = Convert.ToString(drms["modelo"]);
                sernum = Convert.ToString(drms["sernum"]);
                aparelho = Convert.ToString(drms["aparelho"]);
                estadoapa = Convert.ToString(drms["estadoapa"]);
                acessorios = Convert.ToString(drms["acessorios"]);
                descriavaria = Convert.ToString(drms["descriavaria"]);


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

        public void PesquisarFuncionario(string userControl, string nome, string utilizador,
                                         string palavrapasse, string tipoconta)
        {
            SqlCommand command = new SqlCommand("select * from funcionario where utilizador = @utilizador", sql);
            command.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = userControl;
 
            
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
                nome = Convert.ToString(drms["nome"]);
                utilizador = Convert.ToString(drms["utilizador"]);
                palavrapasse = Convert.ToString(drms["palavrapasse"]);
                tipoconta = Convert.ToString(drms["tipoconta"]);

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
