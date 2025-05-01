namespace Projeto.Academia.A3.View
{
    partial class TelaFuncionarioTreinos
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
            this.tabelaTreinos = new System.Windows.Forms.DataGridView();
            this.comboBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTreinos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaTreinos
            // 
            this.tabelaTreinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTreinos.Location = new System.Drawing.Point(109, 187);
            this.tabelaTreinos.Name = "tabelaTreinos";
            this.tabelaTreinos.Size = new System.Drawing.Size(588, 150);
            this.tabelaTreinos.TabIndex = 0;
            this.tabelaTreinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaTreinos_CellContentClick);
            // 
            // comboBoxFuncionarios
            // 
            this.comboBoxFuncionarios.FormattingEnabled = true;
            this.comboBoxFuncionarios.Location = new System.Drawing.Point(338, 131);
            this.comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            this.comboBoxFuncionarios.Size = new System.Drawing.Size(159, 21);
            this.comboBoxFuncionarios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Treinos Cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione o professor para buscar:";
            // 
            // TelaFuncionarioTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFuncionarios);
            this.Controls.Add(this.tabelaTreinos);
            this.Name = "TelaFuncionarioTreinos";
            this.Text = "TelaFuncionarioTreinos";
            this.Load += new System.EventHandler(this.TelaFuncionarioTreinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTreinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaTreinos;
        private System.Windows.Forms.ComboBox comboBoxFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}