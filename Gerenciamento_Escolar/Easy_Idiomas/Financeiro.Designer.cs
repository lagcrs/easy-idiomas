namespace Easy_Idiomas
{
    partial class Financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financeiro));
            this.dgvFinanceiro = new System.Windows.Forms.DataGridView();
            this.tsFinanceiro = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarFi = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterarFi = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluirFi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBuscarFi = new System.Windows.Forms.ToolStripLabel();
            this.tstIdfi = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscarfi = new System.Windows.Forms.ToolStripButton();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lDataPagA = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.mtbDataPagFi = new System.Windows.Forms.MaskedTextBox();
            this.gbContas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).BeginInit();
            this.tsFinanceiro.SuspendLayout();
            this.gbContas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFinanceiro
            // 
            this.dgvFinanceiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceiro.Location = new System.Drawing.Point(12, 128);
            this.dgvFinanceiro.Name = "dgvFinanceiro";
            this.dgvFinanceiro.Size = new System.Drawing.Size(660, 253);
            this.dgvFinanceiro.TabIndex = 40;
            this.dgvFinanceiro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellContentClick);
            this.dgvFinanceiro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFinanceiro_MouseClick);
            // 
            // tsFinanceiro
            // 
            this.tsFinanceiro.AutoSize = false;
            this.tsFinanceiro.BackgroundImage = global::Easy_Idiomas.Properties.Resources.logon4;
            this.tsFinanceiro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarFi,
            this.tsbAlterarFi,
            this.tsbExcluirFi,
            this.toolStripSeparator1,
            this.tslBuscarFi,
            this.tstIdfi,
            this.tsbBuscarfi});
            this.tsFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.tsFinanceiro.Name = "tsFinanceiro";
            this.tsFinanceiro.Size = new System.Drawing.Size(684, 31);
            this.tsFinanceiro.TabIndex = 32;
            this.tsFinanceiro.Text = "toolStrip1";
            // 
            // tsbSalvarFi
            // 
            this.tsbSalvarFi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarFi.Image = global::Easy_Idiomas.Properties.Resources.icone_salvar;
            this.tsbSalvarFi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarFi.Name = "tsbSalvarFi";
            this.tsbSalvarFi.Size = new System.Drawing.Size(23, 28);
            this.tsbSalvarFi.Text = "Salvar";
            this.tsbSalvarFi.Click += new System.EventHandler(this.tsbSalvarFi_Click);
            // 
            // tsbAlterarFi
            // 
            this.tsbAlterarFi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterarFi.Image = global::Easy_Idiomas.Properties.Resources._13;
            this.tsbAlterarFi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterarFi.Name = "tsbAlterarFi";
            this.tsbAlterarFi.Size = new System.Drawing.Size(23, 28);
            this.tsbAlterarFi.Text = "Alterar";
            this.tsbAlterarFi.Click += new System.EventHandler(this.tsbAlterarFi_Click);
            // 
            // tsbExcluirFi
            // 
            this.tsbExcluirFi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluirFi.Image = global::Easy_Idiomas.Properties.Resources.icone_excluir;
            this.tsbExcluirFi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluirFi.Name = "tsbExcluirFi";
            this.tsbExcluirFi.Size = new System.Drawing.Size(23, 28);
            this.tsbExcluirFi.Text = "excluir";
            this.tsbExcluirFi.Click += new System.EventHandler(this.tsbExcluirFi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tslBuscarFi
            // 
            this.tslBuscarFi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslBuscarFi.ForeColor = System.Drawing.SystemColors.Control;
            this.tslBuscarFi.Name = "tslBuscarFi";
            this.tslBuscarFi.Size = new System.Drawing.Size(93, 28);
            this.tslBuscarFi.Text = "Buscar por Id:";
            // 
            // tstIdfi
            // 
            this.tstIdfi.Name = "tstIdfi";
            this.tstIdfi.Size = new System.Drawing.Size(100, 31);
            // 
            // tsbBuscarfi
            // 
            this.tsbBuscarfi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarfi.Image = global::Easy_Idiomas.Properties.Resources.icone_pesquisa;
            this.tsbBuscarfi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarfi.Name = "tsbBuscarfi";
            this.tsbBuscarfi.Size = new System.Drawing.Size(23, 28);
            this.tsbBuscarfi.Text = "Buscar";
            this.tsbBuscarfi.Click += new System.EventHandler(this.tsbBuscarfi_Click);
            // 
            // mtbValor
            // 
            this.mtbValor.Enabled = false;
            this.mtbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValor.Location = new System.Drawing.Point(327, 49);
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 26);
            this.mtbValor.TabIndex = 36;
            this.mtbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(58, 49);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(188, 26);
            this.txtTipo.TabIndex = 34;
            // 
            // lDataPagA
            // 
            this.lDataPagA.AutoSize = true;
            this.lDataPagA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataPagA.Location = new System.Drawing.Point(443, 53);
            this.lDataPagA.Name = "lDataPagA";
            this.lDataPagA.Size = new System.Drawing.Size(100, 20);
            this.lDataPagA.TabIndex = 37;
            this.lDataPagA.Text = "Vencimento*";
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValor.Location = new System.Drawing.Point(269, 52);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(52, 20);
            this.lValor.TabIndex = 35;
            this.lValor.Text = "Valor*";
            // 
            // lTipo
            // 
            this.lTipo.AutoSize = true;
            this.lTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipo.Location = new System.Drawing.Point(7, 52);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(45, 20);
            this.lTipo.TabIndex = 33;
            this.lTipo.Text = "Tipo*";
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagar.Location = new System.Drawing.Point(12, 18);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(83, 24);
            this.rbPagar.TabIndex = 39;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "A pagar";
            this.rbPagar.UseVisualStyleBackColor = true;
            this.rbPagar.CheckedChanged += new System.EventHandler(this.rbPagar_CheckedChanged);
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReceber.Location = new System.Drawing.Point(112, 18);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(103, 24);
            this.rbReceber.TabIndex = 40;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "A Receber";
            this.rbReceber.UseVisualStyleBackColor = true;
            this.rbReceber.CheckedChanged += new System.EventHandler(this.rbReceber_CheckedChanged);
            // 
            // mtbDataPagFi
            // 
            this.mtbDataPagFi.Enabled = false;
            this.mtbDataPagFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataPagFi.Location = new System.Drawing.Point(549, 49);
            this.mtbDataPagFi.Mask = "00/00/0000";
            this.mtbDataPagFi.Name = "mtbDataPagFi";
            this.mtbDataPagFi.Size = new System.Drawing.Size(91, 26);
            this.mtbDataPagFi.TabIndex = 41;
            this.mtbDataPagFi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbContas
            // 
            this.gbContas.Controls.Add(this.mtbDataPagFi);
            this.gbContas.Controls.Add(this.rbReceber);
            this.gbContas.Controls.Add(this.rbPagar);
            this.gbContas.Controls.Add(this.lTipo);
            this.gbContas.Controls.Add(this.lValor);
            this.gbContas.Controls.Add(this.lDataPagA);
            this.gbContas.Controls.Add(this.txtTipo);
            this.gbContas.Controls.Add(this.mtbValor);
            this.gbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContas.Location = new System.Drawing.Point(13, 34);
            this.gbContas.Name = "gbContas";
            this.gbContas.Size = new System.Drawing.Size(659, 87);
            this.gbContas.TabIndex = 39;
            this.gbContas.TabStop = false;
            this.gbContas.Text = "Contas";
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 392);
            this.Controls.Add(this.dgvFinanceiro);
            this.Controls.Add(this.gbContas);
            this.Controls.Add(this.tsFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
            this.Load += new System.EventHandler(this.Financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceiro)).EndInit();
            this.tsFinanceiro.ResumeLayout(false);
            this.tsFinanceiro.PerformLayout();
            this.gbContas.ResumeLayout(false);
            this.gbContas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsFinanceiro;
        private System.Windows.Forms.ToolStripButton tsbSalvarFi;
        private System.Windows.Forms.ToolStripButton tsbAlterarFi;
        private System.Windows.Forms.ToolStripButton tsbExcluirFi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslBuscarFi;
        private System.Windows.Forms.ToolStripTextBox tstIdfi;
        private System.Windows.Forms.ToolStripButton tsbBuscarfi;
        private System.Windows.Forms.DataGridView dgvFinanceiro;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lDataPagA;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.MaskedTextBox mtbDataPagFi;
        private System.Windows.Forms.GroupBox gbContas;
    }
}