using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    class Guardar
    {//conexao com a base de dados
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

        //ficha de inscrição*******************************************************************************************
        public void Ficha(string nome, string telemovel, string nif, string morada, string marca, string modelo,
                            string sernum, string aparelho, string estadoapa, string acessorios, string descriavaria,
                            string avariatecnica)
        {
            SqlCommand command = new SqlCommand("insert into fichaobra(nome, telemovel, nif, morada, marca, modelo, sernum, aparelho," +
                                                "estadoapa, acessorios, descriavaria, avariatecnica)" +
                                                "values(@nome, @telemovel, @nif, @morada, @marca, @modelo, @sernum, @aparelho," +
                                                "@estadoapa, @acessorios, @descriavaria, @avariatecnica)", sql);
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

            if (marca != "" & estadoapa != "" & acessorios != "" & descriavaria != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados armazenados com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Por favor digite todos os dados dos campos obrigatorios!" + Environment.NewLine + er);
                }
                finally
                {
                    sql.Close();
                }
            }
        }

        public void Funcionario(string nome, string utilizador, string palavrapasse, string tipoconta)
        {
            SqlCommand command = new SqlCommand("insert into funcionario(nome, utilizador, palavrapasse, tipoconta)" +
                                                "values(@nome, @utilizador, @palavrapasse, @tipoconta)", sql);
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@utilizador", SqlDbType.VarChar).Value = utilizador;
            command.Parameters.Add("@palavrapasse", SqlDbType.VarChar).Value = palavrapasse;
            command.Parameters.Add("@tipoconta", SqlDbType.VarChar).Value = tipoconta;


            if (nome != "" & utilizador != "" & palavrapasse != "" & tipoconta != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados armazenados com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Por favor digite todos os dados dos campos obrigatorios!" + Environment.NewLine + er);
                }
                finally
                {
                    sql.Close();
                }
            }


        }
    }
}
