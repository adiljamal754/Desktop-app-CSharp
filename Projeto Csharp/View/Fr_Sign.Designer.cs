namespace Projeto_Csharp.View
{
    partial class Fr_Sign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Sign));
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.ll_username = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_Satus = new System.Windows.Forms.ComboBox();
            this.btn_Sign = new System.Windows.Forms.Button();
            this.txt_passConf = new System.Windows.Forms.TextBox();
            this.txt_Nuit = new System.Windows.Forms.TextBox();
            this.lbl_passConf = new System.Windows.Forms.Label();
            this.lbl_nuit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numBI = new System.Windows.Forms.TextBox();
            this.lbl_numBI = new System.Windows.Forms.Label();
            this.lbl_workLoc = new System.Windows.Forms.Label();
            this.txt_workLoc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_Gen = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Espec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fullName.Location = new System.Drawing.Point(21, 100);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(124, 20);
            this.lbl_fullName.TabIndex = 0;
            this.lbl_fullName.Text = "Nome Completo:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(21, 123);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(342, 23);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.ll_username);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.lbl_mail);
            this.panel1.Controls.Add(this.txt_adress);
            this.panel1.Controls.Add(this.lbl_Adress);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.lbl_phone);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_fullName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 729);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(21, 495);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(342, 23);
            this.txt_username.TabIndex = 9;
            // 
            // ll_username
            // 
            this.ll_username.AutoSize = true;
            this.ll_username.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ll_username.Location = new System.Drawing.Point(21, 472);
            this.ll_username.Name = "ll_username";
            this.ll_username.Size = new System.Drawing.Size(202, 20);
            this.ll_username.TabIndex = 8;
            this.ll_username.Text = "Introduza o nome do usuario";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(21, 201);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(342, 23);
            this.txt_email.TabIndex = 7;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mail.Location = new System.Drawing.Point(21, 178);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(52, 20);
            this.lbl_mail.TabIndex = 6;
            this.lbl_mail.Text = "E-mail";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(21, 289);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(342, 23);
            this.txt_adress.TabIndex = 5;
            // 
            // lbl_Adress
            // 
            this.lbl_Adress.AutoSize = true;
            this.lbl_Adress.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adress.Location = new System.Drawing.Point(21, 266);
            this.lbl_Adress.Name = "lbl_Adress";
            this.lbl_Adress.Size = new System.Drawing.Size(61, 20);
            this.lbl_Adress.TabIndex = 4;
            this.lbl_Adress.Text = "Morada";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(21, 390);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(342, 23);
            this.txt_phone.TabIndex = 3;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.Location = new System.Drawing.Point(21, 367);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(64, 20);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "Telefone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox_Satus);
            this.panel2.Controls.Add(this.btn_Sign);
            this.panel2.Controls.Add(this.txt_passConf);
            this.panel2.Controls.Add(this.txt_Nuit);
            this.panel2.Controls.Add(this.lbl_passConf);
            this.panel2.Controls.Add(this.lbl_nuit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_numBI);
            this.panel2.Controls.Add(this.lbl_numBI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(895, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 729);
            this.panel2.TabIndex = 3;
            // 
            // comboBox_Satus
            // 
            this.comboBox_Satus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Satus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Satus.FormattingEnabled = true;
            this.comboBox_Satus.Items.AddRange(new object[] {
            "Solteiro",
            "Casado"});
            this.comboBox_Satus.Location = new System.Drawing.Point(83, 289);
            this.comboBox_Satus.Name = "comboBox_Satus";
            this.comboBox_Satus.Size = new System.Drawing.Size(215, 30);
            this.comboBox_Satus.TabIndex = 31;
            this.comboBox_Satus.Text = "Solteiro";
            this.comboBox_Satus.SelectedIndexChanged += new System.EventHandler(this.comboBox_Satus_SelectedIndexChanged);
            // 
            // btn_Sign
            // 
            this.btn_Sign.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sign.FlatAppearance.BorderSize = 0;
            this.btn_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sign.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sign.ForeColor = System.Drawing.Color.Black;
            this.btn_Sign.Image = global::Projeto_Csharp.Properties.Resources.Save_37110;
            this.btn_Sign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sign.Location = new System.Drawing.Point(238, 630);
            this.btn_Sign.Name = "btn_Sign";
            this.btn_Sign.Size = new System.Drawing.Size(171, 59);
            this.btn_Sign.TabIndex = 30;
            this.btn_Sign.Text = "Guardar";
            this.btn_Sign.UseVisualStyleBackColor = false;
            this.btn_Sign.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_passConf
            // 
            this.txt_passConf.Location = new System.Drawing.Point(67, 495);
            this.txt_passConf.Name = "txt_passConf";
            this.txt_passConf.Size = new System.Drawing.Size(342, 23);
            this.txt_passConf.TabIndex = 29;
            this.txt_passConf.UseSystemPasswordChar = true;
            // 
            // txt_Nuit
            // 
            this.txt_Nuit.Location = new System.Drawing.Point(83, 123);
            this.txt_Nuit.Name = "txt_Nuit";
            this.txt_Nuit.Size = new System.Drawing.Size(342, 23);
            this.txt_Nuit.TabIndex = 21;
            // 
            // lbl_passConf
            // 
            this.lbl_passConf.AutoSize = true;
            this.lbl_passConf.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_passConf.Location = new System.Drawing.Point(67, 472);
            this.lbl_passConf.Name = "lbl_passConf";
            this.lbl_passConf.Size = new System.Drawing.Size(151, 20);
            this.lbl_passConf.TabIndex = 28;
            this.lbl_passConf.Text = "Confirma a password";
            // 
            // lbl_nuit
            // 
            this.lbl_nuit.AutoSize = true;
            this.lbl_nuit.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nuit.Location = new System.Drawing.Point(83, 100);
            this.lbl_nuit.Name = "lbl_nuit";
            this.lbl_nuit.Size = new System.Drawing.Size(47, 20);
            this.lbl_nuit.TabIndex = 20;
            this.lbl_nuit.Text = "NUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(83, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado civil";
            // 
            // txt_numBI
            // 
            this.txt_numBI.Location = new System.Drawing.Point(83, 201);
            this.txt_numBI.Name = "txt_numBI";
            this.txt_numBI.Size = new System.Drawing.Size(342, 23);
            this.txt_numBI.TabIndex = 27;
            // 
            // lbl_numBI
            // 
            this.lbl_numBI.AutoSize = true;
            this.lbl_numBI.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numBI.Location = new System.Drawing.Point(83, 178);
            this.lbl_numBI.Name = "lbl_numBI";
            this.lbl_numBI.Size = new System.Drawing.Size(83, 20);
            this.lbl_numBI.TabIndex = 26;
            this.lbl_numBI.Text = "Numero BI";
            // 
            // lbl_workLoc
            // 
            this.lbl_workLoc.AutoSize = true;
            this.lbl_workLoc.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_workLoc.Location = new System.Drawing.Point(58, 365);
            this.lbl_workLoc.Name = "lbl_workLoc";
            this.lbl_workLoc.Size = new System.Drawing.Size(127, 20);
            this.lbl_workLoc.TabIndex = 22;
            this.lbl_workLoc.Text = "Local de Trabalho";
            // 
            // txt_workLoc
            // 
            this.txt_workLoc.Location = new System.Drawing.Point(58, 388);
            this.txt_workLoc.Name = "txt_workLoc";
            this.txt_workLoc.Size = new System.Drawing.Size(342, 23);
            this.txt_workLoc.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox_Gen);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.txt_pass);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_birthday);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Espec);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_workLoc);
            this.panel3.Controls.Add(this.txt_workLoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(455, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 729);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBox_Gen
            // 
            this.comboBox_Gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Gen.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Gen.FormattingEnabled = true;
            this.comboBox_Gen.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.comboBox_Gen.Location = new System.Drawing.Point(58, 204);
            this.comboBox_Gen.Name = "comboBox_Gen";
            this.comboBox_Gen.Size = new System.Drawing.Size(155, 30);
            this.comboBox_Gen.TabIndex = 26;
            this.comboBox_Gen.Text = "Genero";
            this.comboBox_Gen.SelectedIndexChanged += new System.EventHandler(this.comboBox_Gen_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 23);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(58, 493);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(342, 23);
            this.txt_pass.TabIndex = 19;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Introduza a password";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_birthday.ForeColor = System.Drawing.Color.White;
            this.lbl_birthday.Location = new System.Drawing.Point(58, 98);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(143, 20);
            this.lbl_birthday.TabIndex = 10;
            this.lbl_birthday.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Genero";
            // 
            // txt_Espec
            // 
            this.txt_Espec.Location = new System.Drawing.Point(58, 287);
            this.txt_Espec.Name = "txt_Espec";
            this.txt_Espec.Size = new System.Drawing.Size(342, 23);
            this.txt_Espec.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Especialização Medica";
            // 
            // Fr_Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fr_Sign";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_fullName;
        private TextBox txt_name;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txt_email;
        private Label lbl_mail;
        private TextBox txt_adress;
        private Label lbl_Adress;
        private TextBox txt_phone;
        private Label lbl_phone;
        private TextBox txt_username;
        private Label ll_username;
        private Button btn_Sign;
        private TextBox txt_passConf;
        private TextBox txt_Nuit;
        private Label lbl_passConf;
        private Label lbl_nuit;
        private TextBox txt_numBI;
        private Label lbl_workLoc;
        private Label lbl_numBI;
        private TextBox txt_workLoc;
        private TextBox txt_pass;
        private Label label2;
        private Label lbl_birthday;
        private Label label5;
        private Label label3;
        private TextBox txt_Espec;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox_Gen;
        private ComboBox comboBox_Satus;
    }
}