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
    public partial class ApresentarDados : Form
    {
        public ApresentarDados()
        {
            InitializeComponent();
            //******************************************************
            DataSet mdataSet = new DataSet();
            SqlDataAdapter mAdapter;

            SqlConnection sqlConnection = new SqlConnection(@"Integrated Security=SSPI;
                                                    Persist Security Info=False;
                                                    Initial Catalog=exiscomDatabase;
                                                    Data Source=DESKTOP-PJRBTKS\SQLSERVER");

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                mAdapter = new SqlDataAdapter("SELECT * from fichaobra ORDER BY folhaobra", sqlConnection);
                //****
                mAdapter.Fill(mdataSet, "fichaobra");
                dataGridView1.DataSource = mdataSet;
                dataGridView1.DataMember = "fichaobra";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApresentarDados_Load(object sender, EventArgs e)
        {

        }
    }
}
