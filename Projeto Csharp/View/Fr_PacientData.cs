using Projeto_Csharp.Model;
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

namespace Projeto_Csharp.View
{
    public partial class Fr_PacientData : Form
    {
      /*  ConexaoBD con = new ConexaoBD();
        SqlCommand cmd = new SqlCommand();

        string BI = "";
        public Fr_PacientData()
        {
            InitializeComponent();
        }
        public Fr_PacientData(string BI)
        {
            this.BI = BI;
            InitializeComponent();

            cmd.CommandText = "SELECT * FROM dbo.[dados_do_paciente] WHERE N_BI = " + BI +";";
          



            SqlDataReader dr;

            try
            {
                cmd.Connection = con.connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {

                    lbl_nome.Text = dr["nome_completo"].ToString();
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Não existe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            con.disconnect();

        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
