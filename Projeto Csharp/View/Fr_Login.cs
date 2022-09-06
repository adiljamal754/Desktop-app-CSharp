using Emergencia;
using Projeto_Csharp.Model;
using Projeto_Csharp.View;
using System.Data.SqlClient;


namespace Projeto_Csharp
{
    public partial class Fr_Login : Form
    {
        ConexaoBD conexao = new ConexaoBD();
        validacao validacao = new validacao();
        SqlCommand cmd = new SqlCommand();
        public Fr_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picBox_log_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validacao.validar(txt_user, "Introduza o username");
            validacao.validar(txt_pass, "Introduza a password");

           cmd.CommandText = "SELECT * FROM dbo.Funcionario WHERE username = @username AND CONVERT(VARCHAR(MAX), dbo.DECRIPTA_SENHA(SENHA)) = @senha;";
            cmd.Parameters.AddWithValue("@username", txt_user.Text);
            cmd.Parameters.AddWithValue("@senha", txt_pass.Text);



            SqlDataReader dr;

            try
            {
                cmd.Connection = conexao.connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    Mainform main = new Mainform();
                    this.Hide();
                    main.ShowDialog();
                    conexao.disconnect();

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Usuario ou password incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_user.Focus();
            }
            conexao.disconnect();

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
          Fr_Sign fr_Sign =new Fr_Sign();
            fr_Sign.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txt_user_Validating(object sender, System.ComponentModel.CancelEventArgs e) { }

        private void txt_pass_Validating(object sender, System.ComponentModel.CancelEventArgs e) { }
    }
}