using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{//Actualizar dados na base de dados
    class Alterar
    {//Connection string
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                Persist Security Info=False;
                                                Initial Catalog=exiscomDatabase;
                                                Data Source=DESKTOP-PJRBTKS\SQLSERVER");

        public void AlterarForm(string nome, string telemovel, string nif, string morada, string marca, string modelo,
                            string sernum, string aparelho, string estadoapa, string acessorios, string descriavaria,
                            string avariatecnica, string folhaobra)
        {
            SqlCommand command = new SqlCommand("update fichaobra set nome=@nome, telemovel=@telemovel, nif=@nif, morada=@morada," +
                                                "marca=@marca, modelo=@modelo, sernum=@sernum, aparelho=@aparelho, estadoapa=@estadoapa, " +
                                                "acessorios=@acessorios, descriavaria=@descriavaria, avariatecnica=@avariatecnica " +
                                                "where folhaobra=@folhaobra", sql);

            command.Parameters.Add("@folhaobra", SqlDbType.VarChar).Value = folhaobra;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@telemovel", SqlDbType.Int).Value = telemovel;
            command.Parameters.Add("@nif", SqlDbType.Int).Value = nif;
            command.Parameters.Add("@morada", SqlDbType.VarChar).Value = morada;
            command.Parameters.Add("@marca", SqlDbType.VarChar).Value = marca;
            command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
            command.Parameters.Add("@sernum", SqlDbType.VarChar).Value = sernum;
            command.Parameters.Add("@aparelho", SqlDbType.VarChar).Value = aparelho;
            command.Parameters.Add("@estadoapa", SqlDbType.VarChar).Value = estadoapa;
            command.Parameters.Add("@acessorios", SqlDbType.VarChar).Value = acessorios;
            command.Parameters.Add("@descriavaria", SqlDbType.VarChar).Value = descriavaria;
            command.Parameters.Add("@avariatecnica", SqlDbType.VarChar).Value = avariatecnica;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso!", 
                                "Sucesso", 
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Não foi possivel atualizar os dados, confirme se inseriu os dados corretamente!"
                                + Environment.NewLine + er,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                sql.Close();
            }
            
        }

        public void AlterarFunc(string nome, string utilizador, string palavrapasse, string tipoconta, string user)
        {
            SqlCommand command= new SqlCommand(" update funcionario set nome=@nome, utilizador=@utilizador, " +
                                                  "palavrapasse=@palavrapasse, tipoconta=@tipoconta " +
                                                  " where utilizador=@user", sql);

            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = utilizador;
            command.Parameters.Add("@palavrapasse", SqlDbType.VarChar).Value = palavrapasse;
            command.Parameters.Add("@tipoconta", SqlDbType.VarChar).Value = tipoconta;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso!",
                                "Sucesso",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Não foi possivel atualizar os dados, confirme se inseriu os dados corretamente!"
                                + Environment.NewLine + er,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                sql.Close();
            }
        }

    }
}
