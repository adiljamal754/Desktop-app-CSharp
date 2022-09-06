namespace Projeto_Csharp
{
    partial class Fr_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Login));
            this.panel_pic = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_form = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_sign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.panel_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_pic
            // 
            this.panel_pic.Controls.Add(this.pictureBox1);
            this.panel_pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_pic.Location = new System.Drawing.Point(0, 0);
            this.panel_pic.Name = "panel_pic";
            this.panel_pic.Size = new System.Drawing.Size(400, 441);
            this.panel_pic.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Projeto_Csharp.Properties.Resources.img_Login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel_form.Controls.Add(this.pictureBox2);
            this.panel_form.Controls.Add(this.btn_sign);
            this.panel_form.Controls.Add(this.label1);
            this.panel_form.Controls.Add(this.txt_pass);
            this.panel_form.Controls.Add(this.lbl_pass);
            this.panel_form.Controls.Add(this.txt_user);
            this.panel_form.Controls.Add(this.btn_Login);
            this.panel_form.Controls.Add(this.lbl_User);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_form.Location = new System.Drawing.Point(400, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(400, 441);
            this.panel_form.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_Csharp.Properties.Resources.Icon_Login;
            this.pictureBox2.Location = new System.Drawing.Point(106, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_sign
            // 
            this.btn_sign.BackColor = System.Drawing.Color.Transparent;
            this.btn_sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sign.FlatAppearance.BorderSize = 0;
            this.btn_sign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sign.Location = new System.Drawing.Point(300, 3);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(97, 27);
            this.btn_sign.TabIndex = 2;
            this.btn_sign.Text = "Cadastrar";
            this.btn_sign.UseVisualStyleBackColor = false;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(348, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sair";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pass.Location = new System.Drawing.Point(62, 271);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(254, 26);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.Validating += new System.ComponentModel.CancelEventHandler(this.txt_pass_Validating);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pass.Location = new System.Drawing.Point(53, 246);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(106, 22);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Palavra-pase:";
            this.lbl_pass.UseMnemonic = false;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_user.Location = new System.Drawing.Point(62, 200);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(254, 26);
            this.txt_user.TabIndex = 2;
            this.txt_user.Validating += new System.ComponentModel.CancelEventHandler(this.txt_user_Validating);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(78, 337);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(216, 43);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Entrar";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_User.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_User.Location = new System.Drawing.Point(53, 175);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(72, 22);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Usuário:";
            this.lbl_User.UseMnemonic = false;
            // 
            // Fr_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_pic;
        private Panel panel_form;
        private PictureBox pictureBox1;
        private TextBox txt_pass;
        private Label lbl_pass;
        private TextBox txt_user;
        private Button btn_Login;
        private Label lbl_User;
        private Button btn_sign;
        private Label label1;
        private PictureBox pictureBox2;
    }
}