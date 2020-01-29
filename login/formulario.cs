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
    public partial class formulario : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");
        public formulario()
        {
            InitializeComponent();
            //**********************************************************************
            ConectarSe();
            //**********************************************************************
            SqlCommand command = new SqlCommand("select * from fichaobra where folhaobra = @folhaobra", sql);
            command.Parameters.Add("@folhaobra", SqlDbType.VarChar).Value = txtNumObra.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                drms.Read();
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
        //**********************************************************************************************
        public void ConectarSe()
        {
            SqlCommand command = new SqlCommand("SELECT MAX(folhaobra) AS MAXIMO from fichaobra", sql);
            try
            {
                int folhaObra;
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                drms.Read();
                folhaObra = Convert.ToInt32(drms["MAXIMO"]);
                lblFolhaObra.Text = Convert.ToString(folhaObra + 1);
            }
            catch (Exception v)
            {
                MessageBox.Show(Environment.NewLine + v);
            }
            finally
            {
                sql.Close();
            }
        }
        //**********************************************************************************************
        //Fechar form
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Guardar dados na base de dados
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar guardar = new Guardar();
            guardar.Ficha(txtNome.Text.Trim(), txtTelemovel.Text.Trim(), txtNif.Text.Trim(), txtMorada.Text.Trim(), 
                          txtMarca.Text.Trim(), txtModelo.Text.Trim(), txtSerNum.Text.Trim(), comboAparelho.Text.Trim(), comboEstado.Text.Trim(), 
                          comboAcessorios.Text.Trim(), txtDescricao.Text.Trim(), comboEstadoCor.Text.Trim());
            ConectarSe();
        }
        
        //Pesquisar dados da base de dados
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Pesquisar pesquisar = new Pesquisar();
            //pesquisar.PesquisarForm(txtNumObra.Text, txtNome.Text, txtTelemovel.Text, txtNif.Text, txtMorada.Text,
            //              txtMarca.Text, txtModelo.Text, txtSerNum.Text, comboAparelho.Text, comboEstado.Text,
            //              comboAcessorios.Text, txtDescricao.Text);
            //conexao com a base de dados
            SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

            {
                SqlCommand command = new SqlCommand("select * from fichaobra where folhaobra = @folhaobra", sql);
                command.Parameters.Add("@folhaobra", SqlDbType.Int).Value = txtNumObra.Text;

                try
                {
                    sql.Open();
                    SqlDataReader drms = command.ExecuteReader();
                    if (drms.HasRows == false)
                    {
                        throw new Exception("Esta folha de obra não foi encontrada!");
                    }
                    drms.Read();
                    //txt = Convert.ToString(drms["folhaobra"]);
                    txtNome.Text = Convert.ToString(drms["nome"]);
                    txtTelemovel.Text = Convert.ToString(drms["telemovel"]);
                    txtNif.Text = Convert.ToString(drms["nif"]);
                    txtMorada.Text = Convert.ToString(drms["morada"]);
                    txtMarca.Text = Convert.ToString(drms["marca"]);
                    txtModelo.Text = Convert.ToString(drms["modelo"]);
                    txtSerNum.Text = Convert.ToString(drms["sernum"]);
                    comboAparelho.Text = Convert.ToString(drms["aparelho"]);
                    comboAparelho.Text = Convert.ToString(drms["estadoapa"]);
                    comboAparelho.Text = Convert.ToString(drms["acessorios"]);
                    comboEstadoCor.Text = Convert.ToString(drms["avariatecnica"]);
                    txtDescricao.Text = Convert.ToString(drms["descriavaria"]);
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

        private void comboEstadoCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEstadoCor.Text == "Recebido mas não visto")
            {
                lblColor.BackColor = Color.Red;
            }
            else if (comboEstadoCor.Text=="Visto a aguardar peças")
            {
                lblColor.BackColor = Color.Orange;
            }
            else if (comboEstadoCor.Text=="Sem reparo")
            {
                lblColor.BackColor = Color.Yellow;
            }
            else if (comboEstadoCor.Text== "Reparado")
            {
                lblColor.BackColor = Color.YellowGreen;
            }
            else if(comboEstadoCor.Text== "Reparado e entregue")
            {
                lblColor.BackColor = Color.Green;
            }
            else if (comboEstadoCor.Text=="Sem reparo e entregue")
            {
                lblColor.BackColor = Color.GreenYellow;
            }
            else if (comboEstadoCor.Text=="")
            {
                lblColor.BackColor = Color.Gray;
            }
        }
        
        public void Limpar()
        {
            txtDescricao.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtMorada.Clear();
            txtNif.Clear();
            txtNome.Clear();
            txtNumObra.Clear();
            txtSerNum.Clear();
            txtTelemovel.Clear();
            txtServiços.Clear();
            comboEstadoCor.Text = "";
            comboAcessorios.Text = "";
            comboAparelho.Text = "";
            comboEstado.Text = "";
            comboEstadoCor.Text = "";
        }

        //Alterar dados da base de dados
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.AlterarForm(txtNome.Text.Trim(), txtTelemovel.Text.Trim(), txtNif.Text.Trim(), txtMorada.Text.Trim(),
                          txtMarca.Text.Trim(), txtModelo.Text.Trim(), txtSerNum.Text.Trim(), comboAparelho.Text.Trim(), comboEstado.Text.Trim(),
                          comboAcessorios.Text.Trim(), txtDescricao.Text.Trim(), comboEstadoCor.Text.Trim(), txtNumObra.Text.Trim());
        }

        //Apagar dados da base de dados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Apagar apagar = new Apagar();
            apagar.ApagarForm(txtNumObra.Text);
            Limpar();
           
        }
        
        //Imprimir***********************************************************************************************
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {//Desenhar a folha de impressã
            //int largura = documento.DefaultPageSettings.Bounds.Width;
            //Desenhar a impressão
            //DESENHAR O TITULO 
            var fonte = new Font("Arial", 18, GraphicsUnit.Pixel);
            Point ponto = new Point(150, 100);
            var fon = new Point(100, 100);
            Font letra = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle(50, 100, 75, 30);
            StringFormat alinhamento = new StringFormat();

            //Desenhar a assinatura da empresa*****************************************************
            int x = 30;
            alinhamento.Alignment = StringAlignment.Near;
            alinhamento.LineAlignment = StringAlignment.Near;
            string assinatura = "Exiscom, Lda. " + Environment.NewLine +
                            "TEL.: 210990817" + Environment.NewLine +
                            "geral@exiscom.pt" + Environment.NewLine +
                            "www.exiscom.pt" + Environment.NewLine +
                            "Rua da Paz, Nº 6a," + Environment.NewLine + "2735-480";
            e.Graphics.DrawString(assinatura, letra, cor,
                                  new Rectangle(100, x, 200, 100), alinhamento);
            //e.Graphics.DrawRectangle(new Pen(Color.DarkBlue, 2), new Rectangle(100, x, 200, 100));
            e.Graphics.DrawLine(new Pen(Color.Black, 2),
                                new Point(235, 30),
                                new Point(235, 123));
            //************************************************************************************
            string emissao = "Número de Obra: " + lblFolhaObra.Text + Environment.NewLine +
                              "Emitido a: " + DateTime.Now.ToString("dd/MM/yyyy");
            e.Graphics.DrawString(emissao, letra, cor,
                                  new Rectangle(550, x, 200, 100));
            //************************************************************************************
      
            //Dados do cliente********************************************************************
            alinhamento.Alignment = StringAlignment.Center;
            alinhamento.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("CLIENTE", fonte, cor,
                                  new Rectangle(100, 180, 600, 50), alinhamento);
            //Desenhar linha horizontal
            e.Graphics.DrawLine(new Pen(Color.Black, 1),
                                new Point(200, 216),
                                new Point(600, 216));
            //***Listar dados do cliente
            List<string> lista = new List<string>()
            {
                "Nome: " + txtNome.Text + Environment.NewLine +
                "NIF: " + txtNif.Text + Environment.NewLine +
                "Morada: " + txtMorada.Text + Environment.NewLine +
                "Telemovel: " + txtTelemovel.Text 
            };
            int y = 245;
            alinhamento.Alignment = StringAlignment.Near;
            alinhamento.LineAlignment = StringAlignment.Near;
            foreach (var frase in lista)
            {
                e.Graphics.DrawString(frase, fonte, cor,
                                      new Rectangle(105, y, 600, 200), alinhamento);
                y += 25;
            }
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     new Rectangle(100, 178, 650, 158));

            //************************************************************************************
            //Dados do equipamento****************************************************************
            alinhamento.Alignment = StringAlignment.Center;
            alinhamento.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Equipamento".ToUpper(), fonte, cor,
                                  new Rectangle(100, 402, 600, 50), alinhamento);
            //Desenhar linha horizontal
            e.Graphics.DrawLine(new Pen(Color.Black, 1),
                                new Point(185, 438),
                                new Point(600, 438));
            //***

            List<string> Lista = new List<string>()
            {
                "Aparelho: "+ comboAparelho.Text+Environment.NewLine+
                "Marca: " + txtMarca.Text + Environment.NewLine +
                "Modelo: " + txtModelo.Text + Environment.NewLine +
                "Serial Number: " + txtSerNum.Text + Environment.NewLine+
                "Estado do aparelho: " + comboEstado.Text + Environment.NewLine+
                "Acessórios: " + comboAcessorios.Text
            };
            y += 175;
            alinhamento.Alignment = StringAlignment.Near;
            alinhamento.LineAlignment = StringAlignment.Near;
            foreach (var frase in Lista)
            {
                e.Graphics.DrawString(frase, fonte, cor,
                                      new Rectangle(105, y, 600, 200), alinhamento);
                y += 20;
            }
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(100, 400, 650, 180));
            //Assinatura********************************************************************
            e.Graphics.DrawString("Assinatura: ", fonte, cor,
                       new Rectangle(408, 970, 600, 50), alinhamento);
            e.Graphics.DrawLine(new Pen(Color.Black, 1),
                                new Point(500, 990),
                                new Point(750, 990));

            //****************
            //*Avaria****************************************************************************
            y += 170;
            alinhamento.Alignment = StringAlignment.Near;
            alinhamento.LineAlignment = StringAlignment.Near;
            string descri = Environment.NewLine + "                             Avaria reportada pelo cliente ".ToUpper() +
                            Environment.NewLine +
                            Environment.NewLine + txtDescricao.Text;
            e.Graphics.DrawString(descri, fonte, cor,
                                  new Rectangle(105, y, 650, 200), alinhamento);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                    new Rectangle(100, y, 650, 200));
            //Desenhar linha horizontal
            e.Graphics.DrawLine(new Pen(Color.Black, 1),
                                new Point(200, y + 44),
                                new Point(600, y + 44));
            //Rodape///************************************************************************
            e.Graphics.DrawLine(new Pen(Color.Black, 1),
                                new Point(100, 1100),
                                new Point(780, 1100));
            Font Rodape = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Orçamento 100% GRATUITO, o tempo médio de respostas é" +
                " de 2 dias, salvo algumas exeções poderá prolonga-se até um periodo máximo de 7 dias.", Rodape, cor,
                                  new Rectangle(105, 1100, 745, 200), alinhamento);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {//Iniciar o processo de impressão
            
            try
            {
                documento.Print();
                Limpar();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Não foi possivel imprimir! "+Environment.NewLine + ec,
                                "Erro!", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
