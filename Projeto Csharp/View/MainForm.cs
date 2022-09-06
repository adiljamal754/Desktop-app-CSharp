
using Emergencia.View;
using Projeto_Csharp;
using Projeto_Csharp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergencia
{
    public partial class Mainform : Form
    {
      
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(180, 14, 16);

            formHome home = new formHome();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            home.Parent = mainPanel;

            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(home);
            home.Show();
        }
        private void btnPaciente_Click(object sender, EventArgs e)
        {

            Fr_Home home = new Fr_Home();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            home.Parent = mainPanel;

            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(home);
            home.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            formHome home = new formHome();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            home.Parent = mainPanel;

            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(home);
            home.Show();
        }

    

        private void btnSobre_Click(object sender, EventArgs e)
        {Fr_sobre telasobre = new Fr_sobre();
            telasobre.TopLevel = false;
            telasobre.Dock = DockStyle.Fill;
            telasobre.Parent = mainPanel;

            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(telasobre);
            telasobre.Show();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Fr_PacientSign frp = new Fr_PacientSign();
            frp.TopLevel = false;
            frp.Dock = DockStyle.Fill;
            frp.Parent = mainPanel;

            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(frp);
            frp.Show();
        }
    }
    }

