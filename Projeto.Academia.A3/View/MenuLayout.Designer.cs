﻿namespace Projeto.Academia.A3.View
{
    partial class MenuLayout
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscarTreinoFunc = new System.Windows.Forms.Button();
            this.panelLuzVerde = new System.Windows.Forms.Panel();
            this.labelLogado = new System.Windows.Forms.Label();
            this.pagamentos = new System.Windows.Forms.Button();
            this.adicionarTreino = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.areaBranca = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrincipal.Location = new System.Drawing.Point(154, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(761, 450);
            this.panelPrincipal.TabIndex = 2;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buscarTreinoFunc);
            this.panel1.Controls.Add(this.panelLuzVerde);
            this.panel1.Controls.Add(this.labelLogado);
            this.panel1.Controls.Add(this.pagamentos);
            this.panel1.Controls.Add(this.adicionarTreino);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.areaBranca);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 450);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buscarTreinoFunc
            // 
            this.buscarTreinoFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buscarTreinoFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarTreinoFunc.FlatAppearance.BorderSize = 0;
            this.buscarTreinoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarTreinoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTreinoFunc.ForeColor = System.Drawing.Color.Black;
            this.buscarTreinoFunc.Image = global::Projeto.Academia.A3.Properties.Resources.iconlistaTreinosss;
            this.buscarTreinoFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarTreinoFunc.Location = new System.Drawing.Point(-2, 261);
            this.buscarTreinoFunc.Name = "buscarTreinoFunc";
            this.buscarTreinoFunc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buscarTreinoFunc.Size = new System.Drawing.Size(156, 48);
            this.buscarTreinoFunc.TabIndex = 10;
            this.buscarTreinoFunc.Text = "Treinos do Funcionario:";
            this.buscarTreinoFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarTreinoFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buscarTreinoFunc.UseVisualStyleBackColor = false;
            this.buscarTreinoFunc.Click += new System.EventHandler(this.buscarTreinoFunc_Click);
            // 
            // panelLuzVerde
            // 
            this.panelLuzVerde.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.iconluzVerde;
            this.panelLuzVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLuzVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLuzVerde.Location = new System.Drawing.Point(117, 428);
            this.panelLuzVerde.Name = "panelLuzVerde";
            this.panelLuzVerde.Size = new System.Drawing.Size(21, 19);
            this.panelLuzVerde.TabIndex = 9;
            this.panelLuzVerde.Click += new System.EventHandler(this.panelLuzVerde_Click);
            this.panelLuzVerde.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLuzVerde_Paint);
            // 
            // labelLogado
            // 
            this.labelLogado.AutoSize = true;
            this.labelLogado.Location = new System.Drawing.Point(3, 428);
            this.labelLogado.Name = "labelLogado";
            this.labelLogado.Size = new System.Drawing.Size(35, 13);
            this.labelLogado.TabIndex = 8;
            this.labelLogado.Text = "label2";
            this.labelLogado.Click += new System.EventHandler(this.labelLogado_Click);
            // 
            // pagamentos
            // 
            this.pagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pagamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagamentos.FlatAppearance.BorderSize = 0;
            this.pagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagamentos.ForeColor = System.Drawing.Color.Black;
            this.pagamentos.Image = global::Projeto.Academia.A3.Properties.Resources.pagamentos;
            this.pagamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pagamentos.Location = new System.Drawing.Point(0, 216);
            this.pagamentos.Name = "pagamentos";
            this.pagamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pagamentos.Size = new System.Drawing.Size(156, 48);
            this.pagamentos.TabIndex = 6;
            this.pagamentos.Text = "Pagamentos";
            this.pagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.pagamentos.UseVisualStyleBackColor = false;
            this.pagamentos.Click += new System.EventHandler(this.pagamentos_Click);
            // 
            // adicionarTreino
            // 
            this.adicionarTreino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.adicionarTreino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionarTreino.FlatAppearance.BorderSize = 0;
            this.adicionarTreino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarTreino.ForeColor = System.Drawing.Color.Black;
            this.adicionarTreino.Image = global::Projeto.Academia.A3.Properties.Resources.IconTreino;
            this.adicionarTreino.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adicionarTreino.Location = new System.Drawing.Point(0, 171);
            this.adicionarTreino.Name = "adicionarTreino";
            this.adicionarTreino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adicionarTreino.Size = new System.Drawing.Size(156, 48);
            this.adicionarTreino.TabIndex = 5;
            this.adicionarTreino.Text = "Area do Membro";
            this.adicionarTreino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adicionarTreino.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.adicionarTreino.UseVisualStyleBackColor = false;
            this.adicionarTreino.Click += new System.EventHandler(this.adicionarTreino_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Projeto.Academia.A3.Properties.Resources.iconMembroadd;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastrar Membro";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // areaBranca
            // 
            this.areaBranca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.areaBranca.BackgroundImage = global::Projeto.Academia.A3.Properties.Resources.iconACAEMIA;
            this.areaBranca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.areaBranca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.areaBranca.Dock = System.Windows.Forms.DockStyle.Top;
            this.areaBranca.Location = new System.Drawing.Point(0, 0);
            this.areaBranca.Name = "areaBranca";
            this.areaBranca.Size = new System.Drawing.Size(154, 85);
            this.areaBranca.TabIndex = 4;
            this.areaBranca.Click += new System.EventHandler(this.areaBranca_Click);
            this.areaBranca.Paint += new System.Windows.Forms.PaintEventHandler(this.areaBranca_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto.Academia.A3.Properties.Resources.iconFuncionario;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar Funcionario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuLayout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuLayout_FormClosing);
            this.Load += new System.EventHandler(this.MenuLayout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel areaBranca;
        private System.Windows.Forms.Button adicionarTreino;
        private System.Windows.Forms.Button pagamentos;
        private System.Windows.Forms.Label labelLogado;
        private System.Windows.Forms.Panel panelLuzVerde;
        private System.Windows.Forms.Button buscarTreinoFunc;
    }
}