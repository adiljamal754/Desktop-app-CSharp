
using Projeto_Csharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Csharp.View
{
    public partial class Fr_PacientSign : Form
    {
        

    string blodType = ""; 

        validacao val = new validacao();

        public Fr_PacientSign()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grbBox_status_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Sign_Click(object sender, EventArgs e)
        {

            //validações dos campos que não podem ser nulos
            val.validar(txt_name, "Introduza um nome");
            val.validar(txt_Natur, "Preencha o campo");
            val.validar(txt_Height, "Informa a altura");
            val.validar(txt_Weight, "Informe o peso");
            val.validar(txt_numBI, "Preencha o campo");
            val.validar(txt_adress, "Informa o endereço");
            val.validar(txt_alergics, "Preencha o campo");
            val.validar(txt_chronicDisease, "Preencha o campo");
            val.validar(txt_restrict, "Preencha o campo");
           


            //variaveis para armazenar os valores dos radio buttons
            string doador;
            string vacinado;
            string status;
            string sexo;

            vacinado = grpBox_vacinetted.Controls.OfType<RadioButton>().FirstOrDefault(RadioButton => RadioButton.Checked).Text;
            doador = grpBox_Donator.Controls.OfType<RadioButton>().FirstOrDefault(RadioButton => RadioButton.Checked).Text;
            status = grpBox_status.Controls.OfType<RadioButton>().FirstOrDefault(RadioButton => RadioButton.Checked).Text;
            sexo = grpBox_gender.Controls.OfType<RadioButton>().FirstOrDefault(RadioButton => RadioButton.Checked).Text;


            //novo paciente
            Paciente p = new Paciente(txt_name.Text, dt_Birthday.Text, txt_Natur.Text, status, txt_Height.Text, sexo, txt_Weight.Text,txt_numBI.Text,
                txt_language.Text, txt_email.Text, txt_contact.Text, txt_adress.Text, txt_prof.Text, txt_worlPlace.Text, txt_alergics.Text,doador,
                blodType, txt_chronicDisease.Text, txt_emergecyContact.Text, txt_restrict.Text, vacinado, txt_vaccineType.Text);

            //
            MessageBox.Show(p.message);

        }

        private void comBox_bloodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            blodType = comBox_bloodType.Text;
        }
    }
}
