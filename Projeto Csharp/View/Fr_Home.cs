using Projeto_Csharp.Model;
using Projeto_Csharp.View;
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

namespace Projeto_Csharp
{
    public partial class Fr_Home : Form
    {
        ConexaoBD con = new ConexaoBD();
        SqlCommand command = new SqlCommand();
       
        DataTable data = new DataTable();

        int index;


        public Fr_Home()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


            //conectar a BD
            try
            {
                command.Connection = con.connect();
                //  
                command.CommandText = "Select * From dbo.Paciente ORDER BY nome_completo";
                SqlDataAdapter dp = new SqlDataAdapter(command);
                dp.Fill(data);

                dataGridView1.DataSource = data;

                con.disconnect();
              
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao conectar com a base de dados");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          


        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
      
            //conectar a BD
            try
            {
                command.Connection = con.connect();
                //  
                
                command.CommandText = "Select * From dbo.Paciente WHERE nome_completo like '%" + txt_pesquisar.Text + "%' ORDER BY nome_completo";
                SqlDataAdapter dp = new SqlDataAdapter(command);

                DataTable dataSearch = new DataTable();
                dp.Fill(dataSearch);

             
   

                dataGridView1.DataSource = dataSearch;

                con.disconnect();

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao conectar com a base de dados");

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            var bi = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString());


           // Fr_PacientData fr_Pacient = new Fr_PacientData(bi);
           // fr_Pacient.Show(); 
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Fr_Login fr_Login = new Fr_Login();
            fr_Login.ShowDialog();
            this.Close();
        }
    }
}
