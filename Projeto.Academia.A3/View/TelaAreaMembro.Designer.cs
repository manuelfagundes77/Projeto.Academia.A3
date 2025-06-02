namespace Projeto.Academia.A3.View
{
    partial class TelaAreaMembro
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
            this.campoBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCPF = new System.Windows.Forms.TextBox();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAbrirNovotreino = new System.Windows.Forms.Button();
            this.btnAbrirHistoricoDeTreino = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Membro por CPF;";
            // 
            // campoBusca
            // 
            this.campoBusca.Location = new System.Drawing.Point(310, 119);
            this.campoBusca.Name = "campoBusca";
            this.campoBusca.Size = new System.Drawing.Size(119, 20);
            this.campoBusca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(446, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF:";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(269, 224);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(309, 20);
            this.campoNome.TabIndex = 9;
            // 
            // campoCPF
            // 
            this.campoCPF.Location = new System.Drawing.Point(269, 263);
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(131, 20);
            this.campoCPF.TabIndex = 10;
            // 
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(269, 350);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(309, 20);
            this.campoEndereco.TabIndex = 11;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(269, 306);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(131, 20);
            this.campoTelefone.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(269, 189);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(17, 13);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data do Cadastro:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(481, 189);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(28, 13);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Area do Membro";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.membro;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 95);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btnAbrirNovotreino
            // 
            this.btnAbrirNovotreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirNovotreino.Image = global::Projeto.Academia.A3.Properties.Resources.iconadd;
            this.btnAbrirNovotreino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirNovotreino.Location = new System.Drawing.Point(604, 103);
            this.btnAbrirNovotreino.Name = "btnAbrirNovotreino";
            this.btnAbrirNovotreino.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAbrirNovotreino.Size = new System.Drawing.Size(140, 51);
            this.btnAbrirNovotreino.TabIndex = 18;
            this.btnAbrirNovotreino.Text = " Novo Treino";
            this.btnAbrirNovotreino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirNovotreino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirNovotreino.UseVisualStyleBackColor = true;
            this.btnAbrirNovotreino.Click += new System.EventHandler(this.btnAbrirNovotreino_Click);
            // 
            // btnAbrirHistoricoDeTreino
            // 
            this.btnAbrirHistoricoDeTreino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirHistoricoDeTreino.Image = global::Projeto.Academia.A3.Properties.Resources.historico24x24;
            this.btnAbrirHistoricoDeTreino.Location = new System.Drawing.Point(604, 170);
            this.btnAbrirHistoricoDeTreino.Name = "btnAbrirHistoricoDeTreino";
            this.btnAbrirHistoricoDeTreino.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAbrirHistoricoDeTreino.Size = new System.Drawing.Size(140, 51);
            this.btnAbrirHistoricoDeTreino.TabIndex = 17;
            this.btnAbrirHistoricoDeTreino.Text = "  Historico de treino";
            this.btnAbrirHistoricoDeTreino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirHistoricoDeTreino.UseVisualStyleBackColor = true;
            this.btnAbrirHistoricoDeTreino.Click += new System.EventHandler(this.btnAbrirHistoricoDeTreino_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Image = global::Projeto.Academia.A3.Properties.Resources.iconDeltetebranco;
            this.btnExcluir.Location = new System.Drawing.Point(616, 399);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 48);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir Membro";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Image = global::Projeto.Academia.A3.Properties.Resources.iconedit3;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(182, 399);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 48);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Membro";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TelaAdicionarTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAbrirNovotreino);
            this.Controls.Add(this.btnAbrirHistoricoDeTreino);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.campoCPF);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.campoBusca);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TelaAdicionarTreino";
            this.Text = "TelaAdicionarTreino";
            this.Load += new System.EventHandler(this.TelaAdicionarTreino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoCPF;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button btnAbrirHistoricoDeTreino;
        private System.Windows.Forms.Button btnAbrirNovotreino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}