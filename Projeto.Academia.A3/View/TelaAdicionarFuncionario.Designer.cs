namespace Projeto.Academia.A3.View
{
    partial class TelaAdicionarFuncionario
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
            this.labelNOme = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoLogin = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.selecionarCargo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelNOme
            // 
            this.labelNOme.AutoSize = true;
            this.labelNOme.Location = new System.Drawing.Point(301, 118);
            this.labelNOme.Name = "labelNOme";
            this.labelNOme.Size = new System.Drawing.Size(108, 13);
            this.labelNOme.TabIndex = 0;
            this.labelNOme.Text = "Nome do Funcionario";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(301, 251);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Digite o login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite a senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selecione abaixo o cargo do funcionario: ";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(304, 145);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(338, 20);
            this.campoNome.TabIndex = 4;
            // 
            // campoLogin
            // 
            this.campoLogin.Location = new System.Drawing.Point(304, 284);
            this.campoLogin.Name = "campoLogin";
            this.campoLogin.Size = new System.Drawing.Size(156, 20);
            this.campoLogin.TabIndex = 5;
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(500, 284);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.Size = new System.Drawing.Size(142, 20);
            this.campoSenha.TabIndex = 6;
            // 
            // selecionarCargo
            // 
            this.selecionarCargo.FormattingEnabled = true;
            this.selecionarCargo.Items.AddRange(new object[] {
            "Selecione",
            "Gerente",
            "Personal"});
            this.selecionarCargo.Location = new System.Drawing.Point(304, 210);
            this.selecionarCargo.Name = "selecionarCargo";
            this.selecionarCargo.Size = new System.Drawing.Size(156, 21);
            this.selecionarCargo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(386, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastrar Funcionario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.back_arrow_14447;
            this.BtnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.Location = new System.Drawing.Point(12, 6);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(48, 48);
            this.BtnVoltar.TabIndex = 11;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.addusergroup_1251;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(86, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 9;
            // 
            // TelaAdicionarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecionarCargo);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoLogin);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNOme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAdicionarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAdicionarFuncionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaAdicionarFuncionario_FormClosing);
            this.Load += new System.EventHandler(this.TelaAdicionarFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNOme;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoLogin;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.ComboBox selecionarCargo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BtnVoltar;
    }
}