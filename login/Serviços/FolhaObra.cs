using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login.Serviços
{
    class FolhaObra
    {
        public int Id { get; set; }
        public int Folha_Obra { get; set; }
        public string DescriAvaria { get; set; }
        public string AvariaTecnica { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public Equipamento Equipamento { get; set; } = new Equipamento();
        #region
        //public List<FolhaObra> FolhaObras { get; set; } = new FolhaObra();
        SqlConnection Sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

        public FolhaObra()
        {
        }

        public FolhaObra(string descriAvaria, string avariaTecnica, Cliente cliente)
        {
            DescriAvaria = descriAvaria;
            AvariaTecnica = avariaTecnica;
            Cliente = cliente;
        }
        
        //Criar ficha tecnica*******************************************************************************************
        public void RegistarFichaTecnica(string nome, string telemovel, string nif, string morada, string marca, string modelo,
                            string sernum, string aparelho, string estadoapa, string acessorios, string descriavaria,
                            string avariatecnica)
        {
            SqlCommand command = new SqlCommand("insert into fichaobra(nome, telemovel, nif, morada, marca, modelo, sernum, aparelho," +
                                                "estadoapa, acessorios, descriavaria, avariatecnica)" +
                                                "values(@nome, @telemovel, @nif, @morada, @marca, @modelo, @sernum, @aparelho," +
                                                "@estadoapa, @acessorios, @descriavaria, @avariatecnica)", Sql);
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = Cliente.Nome;
            command.Parameters.Add("@telemovel", SqlDbType.Int).Value = Cliente.Telemovel;
            command.Parameters.Add("@nif", SqlDbType.Int).Value = Cliente.Nif;
            command.Parameters.Add("@morada", SqlDbType.VarChar).Value = Cliente.Morada;
            command.Parameters.Add("@marca", SqlDbType.VarChar).Value = Equipamento.Marca;
            command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = Equipamento.Modelo;
            command.Parameters.Add("@aparelho", SqlDbType.VarChar).Value = Equipamento.TipoAparelho;
            command.Parameters.Add("@estadoapa", SqlDbType.VarChar).Value = Equipamento.EstadoAparelho;
            command.Parameters.Add("@acessorios", SqlDbType.VarChar).Value = Equipamento.Acessorios;
            command.Parameters.Add("@descriavaria", SqlDbType.VarChar).Value = DescriAvaria;
            command.Parameters.Add("@avariatecnica", SqlDbType.VarChar).Value = avariatecnica;
            command.Parameters.Add("@sernum", SqlDbType.VarChar).Value = Equipamento.NumeroSerie;
            if (marca != "" & estadoapa != "" & acessorios != "" & descriavaria != "")
            {
                try
                {
                    Sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados armazenados com sucesso!", "Sucesso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Atenção algo correu mal, por favor verifique todos os campos obrigatorios!" + Environment.NewLine + er
                        ,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Sql.Close();
                }
            }
        }

        //Editar ficha tecnica*******************************************************************************************
        public void EditarFichaTecnica(string nome, string telemovel, string nif, string morada, string marca, string modelo,
                            string sernum, string aparelho, string estadoapa, string acessorios, string descriavaria,
                            string avariatecnica, string folhaobra)
        {
            SqlCommand command = new SqlCommand("update fichaobra set nome=@nome, telemovel=@telemovel, nif=@nif, morada=@morada," +
                                                "marca=@marca, modelo=@modelo, sernum=@sernum, aparelho=@aparelho, estadoapa=@estadoapa, " +
                                                "acessorios=@acessorios, descriavaria=@descriavaria, avariatecnica=@avariatecnica " +
                                                "where folhaobra=@folhaobra", Sql);

            command.Parameters.Add("@folhaobra", SqlDbType.VarChar).Value = folhaobra;//***
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = Cliente.Nome;
            command.Parameters.Add("@telemovel", SqlDbType.Int).Value = Cliente.Telemovel;
            command.Parameters.Add("@nif", SqlDbType.Int).Value = Cliente.Nif;
            command.Parameters.Add("@morada", SqlDbType.VarChar).Value = Cliente.Morada;
            command.Parameters.Add("@marca", SqlDbType.VarChar).Value = Equipamento.Marca;
            command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = Equipamento.Modelo;
            command.Parameters.Add("@aparelho", SqlDbType.VarChar).Value = Equipamento.TipoAparelho;
            command.Parameters.Add("@estadoapa", SqlDbType.VarChar).Value = Equipamento.EstadoAparelho;
            command.Parameters.Add("@acessorios", SqlDbType.VarChar).Value = Equipamento.Acessorios;
            command.Parameters.Add("@descriavaria", SqlDbType.VarChar).Value = DescriAvaria;
            command.Parameters.Add("@avariatecnica", SqlDbType.VarChar).Value = avariatecnica;
            command.Parameters.Add("@sernum", SqlDbType.VarChar).Value = Equipamento.NumeroSerie;

            try
            {
                Sql.Open();
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
                Sql.Close();
            }
        }

        //Apagar ficha tecnica*******************************************************************************************
        public void ApagarFichaTecnica(string folhaobra)
        {//Apagar folha de obra
            SqlCommand command = new SqlCommand("delete from fichaobra where folhaobra = @folhaobra", Sql);
            command.Parameters.Add("@folhaobra", SqlDbType.Int).Value = folhaobra;

            try
            {
                Sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados apagados com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel apagar" + ex.Message,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Sql.Close();
            }
        }

        //Pesquisar ficha tecnica*******************************************************************************************
        public List<FolhaObra> PesquisarFichaTecnica(int folhaObra)
        {

            SqlCommand command = new SqlCommand("select * from fichaobra where folhaobra = @folhaobra", Sql);
            command.Parameters.Add("@folhaobra", SqlDbType.Int).Value = folhaObra;
            var folhaObras = new List<FolhaObra>();
            try
            {
                Sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Esta folha de obra não foi encontrada!");
                }
                drms.Read();
                //txt = Convert.ToString(drms["folhaobra"]);
                #endregion
                foreach (var folha in folhaObras)
                    {
                        folha.Cliente.Nome = Convert.ToString(drms["nome"]);
                        string tel = Convert.ToString(drms["telemovel"]);
                        folha.Cliente.Telemovel = int.Parse(tel);
                        folha.DescriAvaria = Convert.ToString(drms["nif"]);
                        folha.Cliente.Morada = Convert.ToString(drms["morada"]);
                        folha.Equipamento.Marca = Convert.ToString(drms["marca"]);
                        folha.Equipamento.Modelo = Convert.ToString(drms["modelo"]);
                        folha.Equipamento.NumeroSerie = Convert.ToString(drms["sernum"]);
                        folha.Equipamento.TipoAparelho = Convert.ToString(drms["aparelho"]);
                        folha.Equipamento.EstadoAparelho = Convert.ToString(drms["estadoapa"]);
                        folha.Equipamento.Acessorios = Convert.ToString(drms["acessorios"]);
                        folha.AvariaTecnica = Convert.ToString(drms["avariatecnica"]);
                        folha.DescriAvaria = Convert.ToString(drms["descriavaria"]);
                    }
                    return folhaObras;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro com a base de dados" + ex);
            }
            finally
            {
                Sql.Close();
            }
        }

    }
}
    