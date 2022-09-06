using Emergencia;
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
    public partial class Fr_Sign : Form
    {
        validacao validacao = new validacao();
        ErrorProvider error = new ErrorProvider();
        string gender = "";
        string status = "";
        
        public Fr_Sign()
        {
            InitializeComponent();
        }

        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            //validação do nome
            validacao.validar(txt_name, "Introduza o seu nome");

              //validação do email
              validacao.validar(txt_email, "Introduza o seu e-mail");

              //validação morada
              validacao.validar(txt_adress, "Introduza o seu endereço");

              //validação da especialização do trabalho
              validacao.validar(txt_Espec, "Indique a sua especialização na medicina");

              //validação do numero de bi
              validacao.validar(txt_numBI, "Introduza o seu número de BI");


              //validação do numero de telefone
              validacao.validar(txt_phone, "Introduza o seu numero de telefone");

              //validação do nome do usuario
              validacao.validar(txt_username, "Indique o seu nome de usuario");

              //validação da localização de trabalho
              validacao.validar(txt_workLoc, "Introduza a localização de trabalho");

              //validação do nuit
              validacao.validar(txt_Nuit, "Introduza o seu nuit");

              //validação da password
              validacao.validar(txt_pass, "Introduza uma palavra-passe");

              //validação da password confirmação
              validacao.validar(txt_passConf, "Introduza uma palavra-passe");

              if (txt_passConf.Text != txt_pass.Text)
              {
                  txt_passConf.Focus();
                  error.SetError(txt_passConf, "As palavras-passes são diferentes");
              }
            
                funcionario func = new funcionario(txt_name.Text, txt_email.Text, txt_adress.Text, txt_phone.Text,
                    txt_username.Text, dateTimePicker1.Text, gender, txt_Espec.Text, txt_workLoc.Text, txt_pass.Text, txt_Nuit.Text, txt_numBI.Text, status);


                MessageBox.Show(func.message);

            if(func.message == "Usuário cadastrado com sucesso!!!"p)
            {
                Mainform main = new Mainform();
                this.Close();
                main.ShowDialog();

            }


        }
        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Gen_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = comboBox_Gen.Text;
            
        }

        private void comboBox_Satus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = comboBox_Satus.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
