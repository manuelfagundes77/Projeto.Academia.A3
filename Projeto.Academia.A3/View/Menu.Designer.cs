namespace Projeto.Academia.A3.View
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.irTelaAddFuncionario = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::Projeto.Academia.A3.Properties.Resources.addusergroup_1251;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(52, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 149);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Membro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adicionar Funcionario";
            // 
            // irTelaAddFuncionario
            // 
            this.irTelaAddFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.irTelaAddFuncionario.Image = global::Projeto.Academia.A3.Properties.Resources.addusergroup_1251;
            this.irTelaAddFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.irTelaAddFuncionario.Location = new System.Drawing.Point(52, 264);
            this.irTelaAddFuncionario.Name = "irTelaAddFuncionario";
            this.irTelaAddFuncionario.Size = new System.Drawing.Size(146, 149);
            this.irTelaAddFuncionario.TabIndex = 2;
            this.irTelaAddFuncionario.UseVisualStyleBackColor = true;
            this.irTelaAddFuncionario.Click += new System.EventHandler(this.irTelaAddFuncionario_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.Windows_Turn_Off_22528;
            this.BtnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.Location = new System.Drawing.Point(740, 12);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(48, 48);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.irTelaAddFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button irTelaAddFuncionario;
        private System.Windows.Forms.Panel BtnVoltar;
    }
}