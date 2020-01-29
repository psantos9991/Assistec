using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Apagar
    {


        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                Persist Security Info=False;
                                                Initial Catalog=exiscomDatabase;
                                                Data Source=DESKTOP-PJRBTKS\SQLSERVER");
        
        public void ApagarForm(string folhaobra)
        {//Apagar folha de obra
            SqlCommand command = new SqlCommand("delete from fichaobra where folhaobra = @folhaobra", sql);
            command.Parameters.Add("@folhaobra", SqlDbType.Int).Value = folhaobra;
            
            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados apagados com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                sql.Close();
            }

        }

        public void ApagarUser(string user)
        {//Apagar utilizador
            SqlCommand command = new SqlCommand("delete from funcionario where utilizador = @user", sql);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            
            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados apagados com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
                                "Erro!",
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
