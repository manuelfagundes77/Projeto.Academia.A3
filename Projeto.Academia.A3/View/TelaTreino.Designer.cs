namespace Projeto.Academia.A3.View
{
    partial class TelaTreino
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
            this.labelNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selecionarTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campoDescricao = new System.Windows.Forms.TextBox();
            this.pegaData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataDuracao = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdicionarTreino = new System.Windows.Forms.Button();
            this.selecionaExercicio = new System.Windows.Forms.ComboBox();
            this.selecionaSerie = new System.Windows.Forms.ComboBox();
            this.selecionaRepeticoes = new System.Windows.Forms.ComboBox();
            this.btnAddExercicio = new System.Windows.Forms.Button();
            this.listaExercicios = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.selecionaSubtreino = new System.Windows.Forms.ComboBox();
            this.listaExerciciosB = new System.Windows.Forms.ListBox();
            this.listaExerciciosC = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Treino  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Membro: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(294, 65);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 18);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecione o Foco do Treino:";
            // 
            // selecionarTipo
            // 
            this.selecionarTipo.FormattingEnabled = true;
            this.selecionarTipo.Items.AddRange(new object[] {
            "Hipertrofia",
            "Emagrecimento",
            "Força",
            "Condicionamento",
            "Físico geral"});
            this.selecionarTipo.Location = new System.Drawing.Point(357, 90);
            this.selecionarTipo.Name = "selecionarTipo";
            this.selecionarTipo.Size = new System.Drawing.Size(160, 21);
            this.selecionarTipo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição Do Treino:";
            // 
            // campoDescricao
            // 
            this.campoDescricao.Location = new System.Drawing.Point(357, 122);
            this.campoDescricao.Multiline = true;
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(374, 24);
            this.campoDescricao.TabIndex = 6;
            // 
            // pegaData
            // 
            this.pegaData.Location = new System.Drawing.Point(286, 378);
            this.pegaData.Name = "pegaData";
            this.pegaData.Size = new System.Drawing.Size(218, 20);
            this.pegaData.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Escolha a data de inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duração do treino até:";
            // 
            // dataDuracao
            // 
            this.dataDuracao.Location = new System.Drawing.Point(286, 412);
            this.dataDuracao.Name = "dataDuracao";
            this.dataDuracao.Size = new System.Drawing.Size(218, 20);
            this.dataDuracao.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.treino;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(91, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 110);
            this.panel1.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.back_arrow_14447;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 9);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(48, 48);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdicionarTreino
            // 
            this.btnAdicionarTreino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarTreino.Image = global::Projeto.Academia.A3.Properties.Resources.iconadd;
            this.btnAdicionarTreino.Location = new System.Drawing.Point(608, 385);
            this.btnAdicionarTreino.Name = "btnAdicionarTreino";
            this.btnAdicionarTreino.Size = new System.Drawing.Size(144, 47);
            this.btnAdicionarTreino.TabIndex = 11;
            this.btnAdicionarTreino.Text = "Adicionar Treino";
            this.btnAdicionarTreino.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdicionarTreino.UseVisualStyleBackColor = true;
            this.btnAdicionarTreino.Click += new System.EventHandler(this.btnAdicionarTreino_Click);
            // 
            // selecionaExercicio
            // 
            this.selecionaExercicio.FormattingEnabled = true;
            this.selecionaExercicio.Items.AddRange(new object[] {
            "Supino Reto",
            "Supino Inclinado",
            "Crucifixo com Halteres",
            "Tríceps Testa",
            "Tríceps Pulley",
            "Puxada Frontal",
            "Remada Curvada",
            "Levantamento Terra",
            "Rosca Direta",
            "Rosca Martelo"});
            this.selecionaExercicio.Location = new System.Drawing.Point(100, 199);
            this.selecionaExercicio.Name = "selecionaExercicio";
            this.selecionaExercicio.Size = new System.Drawing.Size(138, 21);
            this.selecionaExercicio.TabIndex = 14;
            // 
            // selecionaSerie
            // 
            this.selecionaSerie.FormattingEnabled = true;
            this.selecionaSerie.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.selecionaSerie.Location = new System.Drawing.Point(284, 199);
            this.selecionaSerie.Name = "selecionaSerie";
            this.selecionaSerie.Size = new System.Drawing.Size(58, 21);
            this.selecionaSerie.TabIndex = 15;
            // 
            // selecionaRepeticoes
            // 
            this.selecionaRepeticoes.FormattingEnabled = true;
            this.selecionaRepeticoes.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14"});
            this.selecionaRepeticoes.Location = new System.Drawing.Point(416, 199);
            this.selecionaRepeticoes.Name = "selecionaRepeticoes";
            this.selecionaRepeticoes.Size = new System.Drawing.Size(58, 21);
            this.selecionaRepeticoes.TabIndex = 16;
            // 
            // btnAddExercicio
            // 
            this.btnAddExercicio.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.iconadd;
            this.btnAddExercicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddExercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddExercicio.Location = new System.Drawing.Point(703, 197);
            this.btnAddExercicio.Name = "btnAddExercicio";
            this.btnAddExercicio.Size = new System.Drawing.Size(28, 23);
            this.btnAddExercicio.TabIndex = 17;
            this.btnAddExercicio.UseVisualStyleBackColor = true;
            this.btnAddExercicio.Click += new System.EventHandler(this.btnAddExercicio_Click);
            // 
            // listaExercicios
            // 
            this.listaExercicios.FormattingEnabled = true;
            this.listaExercicios.Location = new System.Drawing.Point(39, 251);
            this.listaExercicios.Name = "listaExercicios";
            this.listaExercicios.Size = new System.Drawing.Size(219, 95);
            this.listaExercicios.TabIndex = 18;
            this.listaExercicios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaExercicios_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Adicione os Exercicios:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Exercicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Serie:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Repetiçoes:";
            // 
            // selecionaSubtreino
            // 
            this.selecionaSubtreino.FormattingEnabled = true;
            this.selecionaSubtreino.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B",
            "Tipo C"});
            this.selecionaSubtreino.Location = new System.Drawing.Point(598, 199);
            this.selecionaSubtreino.Name = "selecionaSubtreino";
            this.selecionaSubtreino.Size = new System.Drawing.Size(92, 21);
            this.selecionaSubtreino.TabIndex = 23;
            // 
            // listaExerciciosB
            // 
            this.listaExerciciosB.FormattingEnabled = true;
            this.listaExerciciosB.Location = new System.Drawing.Point(289, 251);
            this.listaExerciciosB.Name = "listaExerciciosB";
            this.listaExerciciosB.Size = new System.Drawing.Size(220, 95);
            this.listaExerciciosB.TabIndex = 24;
            this.listaExerciciosB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaExerciciosB_MouseDoubleClick);
            // 
            // listaExerciciosC
            // 
            this.listaExerciciosC.FormattingEnabled = true;
            this.listaExerciciosC.Location = new System.Drawing.Point(533, 251);
            this.listaExerciciosC.Name = "listaExerciciosC";
            this.listaExerciciosC.Size = new System.Drawing.Size(219, 95);
            this.listaExerciciosC.TabIndex = 25;
            this.listaExerciciosC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaExerciciosC_MouseDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(113, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Treino A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Treino B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(616, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Treino C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(587, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "label14";
            // 
            // TelaTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listaExerciciosC);
            this.Controls.Add(this.listaExerciciosB);
            this.Controls.Add(this.selecionaSubtreino);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listaExercicios);
            this.Controls.Add(this.btnAddExercicio);
            this.Controls.Add(this.selecionaRepeticoes);
            this.Controls.Add(this.selecionaSerie);
            this.Controls.Add(this.selecionaExercicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAdicionarTreino);
            this.Controls.Add(this.dataDuracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pegaData);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selecionarTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaTreino";
            this.Text = "TelaTreino";
            this.Load += new System.EventHandler(this.TelaTreino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selecionarTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoDescricao;
        private System.Windows.Forms.DateTimePicker pegaData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataDuracao;
        private System.Windows.Forms.Button btnAdicionarTreino;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox selecionaExercicio;
        private System.Windows.Forms.ComboBox selecionaSerie;
        private System.Windows.Forms.ComboBox selecionaRepeticoes;
        private System.Windows.Forms.Button btnAddExercicio;
        private System.Windows.Forms.ListBox listaExercicios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox selecionaSubtreino;
        private System.Windows.Forms.ListBox listaExerciciosB;
        private System.Windows.Forms.ListBox listaExerciciosC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}