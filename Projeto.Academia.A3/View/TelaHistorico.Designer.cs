namespace Projeto.Academia.A3.View
{
    partial class TelaHistorico
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVoltar = new System.Windows.Forms.Panel();
            this.listaExercicioA = new System.Windows.Forms.ListBox();
            this.listaExercicioB = new System.Windows.Forms.ListBox();
            this.listaExercicioC = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(101, 103);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 20);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Nome";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(24, 73);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(28, 20);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "ID";
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(268, 73);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(466, 140);
            this.dataView.TabIndex = 4;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista De Treinos de:";
            // 
            // panelVoltar
            // 
            this.panelVoltar.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.back_arrow_14447;
            this.panelVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelVoltar.Location = new System.Drawing.Point(12, 12);
            this.panelVoltar.Name = "panelVoltar";
            this.panelVoltar.Size = new System.Drawing.Size(48, 48);
            this.panelVoltar.TabIndex = 6;
            this.panelVoltar.Click += new System.EventHandler(this.panelVoltar_Click);
            // 
            // listaExercicioA
            // 
            this.listaExercicioA.FormattingEnabled = true;
            this.listaExercicioA.Location = new System.Drawing.Point(28, 311);
            this.listaExercicioA.Name = "listaExercicioA";
            this.listaExercicioA.Size = new System.Drawing.Size(219, 95);
            this.listaExercicioA.TabIndex = 7;
            // 
            // listaExercicioB
            // 
            this.listaExercicioB.FormattingEnabled = true;
            this.listaExercicioB.Location = new System.Drawing.Point(285, 311);
            this.listaExercicioB.Name = "listaExercicioB";
            this.listaExercicioB.Size = new System.Drawing.Size(219, 95);
            this.listaExercicioB.TabIndex = 8;
            // 
            // listaExercicioC
            // 
            this.listaExercicioC.FormattingEnabled = true;
            this.listaExercicioC.Location = new System.Drawing.Point(543, 311);
            this.listaExercicioC.Name = "listaExercicioC";
            this.listaExercicioC.Size = new System.Drawing.Size(219, 95);
            this.listaExercicioC.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Treino A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Treino B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Treino C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Detalhes do Treino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Membro:";
            // 
            // TelaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaExercicioC);
            this.Controls.Add(this.listaExercicioB);
            this.Controls.Add(this.listaExercicioA);
            this.Controls.Add(this.panelVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelID);
            this.Name = "TelaHistorico";
            this.Text = "TelaHistorico";
            this.Load += new System.EventHandler(this.TelaHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVoltar;
        private System.Windows.Forms.ListBox listaExercicioA;
        private System.Windows.Forms.ListBox listaExercicioB;
        private System.Windows.Forms.ListBox listaExercicioC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}