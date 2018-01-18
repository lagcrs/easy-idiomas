namespace Easy_Idiomas
{
    partial class Gerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciamento));
            this.bRelatorio = new System.Windows.Forms.Button();
            this.tsInferior = new System.Windows.Forms.ToolStrip();
            this.bFuncionario = new System.Windows.Forms.Button();
            this.bTurma = new System.Windows.Forms.Button();
            this.bAluno = new System.Windows.Forms.Button();
            this.bFinanceiro = new System.Windows.Forms.Button();
            this.tsGerenciamento = new System.Windows.Forms.ToolStrip();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.tslNome = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tsGerenciamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bRelatorio
            // 
            this.bRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelatorio.Image = global::Easy_Idiomas.Properties.Resources.RELATORIO;
            this.bRelatorio.Location = new System.Drawing.Point(325, 202);
            this.bRelatorio.Name = "bRelatorio";
            this.bRelatorio.Size = new System.Drawing.Size(116, 130);
            this.bRelatorio.TabIndex = 4;
            this.bRelatorio.Text = "Relatório";
            this.bRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bRelatorio.UseVisualStyleBackColor = true;
            this.bRelatorio.Click += new System.EventHandler(this.bRelatorio_Click);
            // 
            // tsInferior
            // 
            this.tsInferior.BackColor = System.Drawing.Color.MidnightBlue;
            this.tsInferior.BackgroundImage = global::Easy_Idiomas.Properties.Resources.EASYYYYY3;
            this.tsInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInferior.Location = new System.Drawing.Point(0, 537);
            this.tsInferior.Name = "tsInferior";
            this.tsInferior.Size = new System.Drawing.Size(784, 25);
            this.tsInferior.TabIndex = 2;
            this.tsInferior.Text = "Barra Inferior";
            // 
            // bFuncionario
            // 
            this.bFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFuncionario.Image = global::Easy_Idiomas.Properties.Resources.ICONE_FUNC;
            this.bFuncionario.Location = new System.Drawing.Point(73, 46);
            this.bFuncionario.Name = "bFuncionario";
            this.bFuncionario.Size = new System.Drawing.Size(116, 130);
            this.bFuncionario.TabIndex = 0;
            this.bFuncionario.Text = "Funcionário";
            this.bFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bFuncionario.UseVisualStyleBackColor = true;
            this.bFuncionario.Click += new System.EventHandler(this.bFuncionario_Click);
            // 
            // bTurma
            // 
            this.bTurma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTurma.Image = global::Easy_Idiomas.Properties.Resources.icone_turmas_reduzidas;
            this.bTurma.Location = new System.Drawing.Point(145, 202);
            this.bTurma.Name = "bTurma";
            this.bTurma.Size = new System.Drawing.Size(116, 130);
            this.bTurma.TabIndex = 3;
            this.bTurma.Text = "Turma";
            this.bTurma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bTurma.UseVisualStyleBackColor = true;
            this.bTurma.Click += new System.EventHandler(this.bTurma_Click);
            // 
            // bAluno
            // 
            this.bAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAluno.Image = global::Easy_Idiomas.Properties.Resources.alunos;
            this.bAluno.Location = new System.Drawing.Point(235, 46);
            this.bAluno.Name = "bAluno";
            this.bAluno.Size = new System.Drawing.Size(116, 130);
            this.bAluno.TabIndex = 1;
            this.bAluno.Text = "Aluno";
            this.bAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bAluno.UseVisualStyleBackColor = true;
            this.bAluno.Click += new System.EventHandler(this.bAluno_Click);
            // 
            // bFinanceiro
            // 
            this.bFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinanceiro.Image = global::Easy_Idiomas.Properties.Resources.icon_capi;
            this.bFinanceiro.Location = new System.Drawing.Point(393, 46);
            this.bFinanceiro.Name = "bFinanceiro";
            this.bFinanceiro.Size = new System.Drawing.Size(116, 130);
            this.bFinanceiro.TabIndex = 2;
            this.bFinanceiro.Text = "Financeiro";
            this.bFinanceiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bFinanceiro.UseVisualStyleBackColor = true;
            this.bFinanceiro.Click += new System.EventHandler(this.bFinanceiro_Click);
            // 
            // tsGerenciamento
            // 
            this.tsGerenciamento.AutoSize = false;
            this.tsGerenciamento.BackColor = System.Drawing.Color.MidnightBlue;
            this.tsGerenciamento.BackgroundImage = global::Easy_Idiomas.Properties.Resources.logon11;
            this.tsGerenciamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSair,
            this.tslNome});
            this.tsGerenciamento.Location = new System.Drawing.Point(0, 0);
            this.tsGerenciamento.Name = "tsGerenciamento";
            this.tsGerenciamento.Size = new System.Drawing.Size(784, 81);
            this.tsGerenciamento.TabIndex = 1;
            this.tsGerenciamento.Text = "Menu do Usuário";
            // 
            // tsbSair
            // 
            this.tsbSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::Easy_Idiomas.Properties.Resources.SAIR;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(23, 78);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // tslNome
            // 
            this.tslNome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslNome.ForeColor = System.Drawing.SystemColors.Control;
            this.tslNome.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.tslNome.Name = "tslNome";
            this.tslNome.Size = new System.Drawing.Size(161, 78);
            this.tslNome.Text = "Bem Vindo: Administrador";
            this.tslNome.Click += new System.EventHandler(this.tslNome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bFuncionario);
            this.groupBox1.Controls.Add(this.bRelatorio);
            this.groupBox1.Controls.Add(this.bAluno);
            this.groupBox1.Controls.Add(this.bFinanceiro);
            this.groupBox1.Controls.Add(this.bTurma);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(88, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interfaces de Gerenciamento";
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.tsGerenciamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gerenciamento_FormClosing);
            this.Load += new System.EventHandler(this.Gerenciamento_Load);
            this.tsGerenciamento.ResumeLayout(false);
            this.tsGerenciamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsGerenciamento;
        private System.Windows.Forms.ToolStripLabel tslNome;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStrip tsInferior;
        private System.Windows.Forms.Button bFuncionario;
        private System.Windows.Forms.Button bTurma;
        private System.Windows.Forms.Button bAluno;
        private System.Windows.Forms.Button bFinanceiro;
        private System.Windows.Forms.Button bRelatorio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}