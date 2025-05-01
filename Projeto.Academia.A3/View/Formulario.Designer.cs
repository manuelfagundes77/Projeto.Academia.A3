namespace Projeto.Academia.A3.View
{
    partial class Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCPF = new System.Windows.Forms.TextBox();
            this.CampoEndereço = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionarMembro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(243, 138);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(145, 20);
            this.campoNome.TabIndex = 3;
            // 
            // campoCPF
            // 
            this.campoCPF.Location = new System.Drawing.Point(243, 226);
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(100, 20);
            this.campoCPF.TabIndex = 4;
            // 
            // CampoEndereço
            // 
            this.CampoEndereço.Location = new System.Drawing.Point(243, 303);
            this.CampoEndereço.Name = "CampoEndereço";
            this.CampoEndereço.Size = new System.Drawing.Size(361, 20);
            this.CampoEndereço.TabIndex = 5;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(462, 138);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(142, 20);
            this.campoTelefone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnAdicionarMembro
            // 
            this.btnAdicionarMembro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarMembro.Location = new System.Drawing.Point(243, 367);
            this.btnAdicionarMembro.Name = "btnAdicionarMembro";
            this.btnAdicionarMembro.Size = new System.Drawing.Size(113, 34);
            this.btnAdicionarMembro.TabIndex = 11;
            this.btnAdicionarMembro.Text = "Cadastrar Membro";
            this.btnAdicionarMembro.UseVisualStyleBackColor = true;
            this.btnAdicionarMembro.Click += new System.EventHandler(this.btnAdicionarMembro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cadastrar Membro";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.cadastrarmembro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(36, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 101);
            this.panel1.TabIndex = 13;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdicionarMembro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.CampoEndereço);
            this.Controls.Add(this.campoCPF);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulario_FormClosing);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoCPF;
        private System.Windows.Forms.TextBox CampoEndereço;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdicionarMembro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}