namespace Easy_Idiomas
{
    partial class Turma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turma));
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.gbTurma = new System.Windows.Forms.GroupBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.lNivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.mtbFim = new System.Windows.Forms.MaskedTextBox();
            this.lAs = new System.Windows.Forms.Label();
            this.mtbInicio = new System.Windows.Forms.MaskedTextBox();
            this.lNomeT = new System.Windows.Forms.Label();
            this.txtNomeT = new System.Windows.Forms.TextBox();
            this.lHorario = new System.Windows.Forms.Label();
            this.tsTurma = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarT = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterarT = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluirT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBuscarT = new System.Windows.Forms.ToolStripLabel();
            this.tstIdT = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscarT = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.gbTurma.SuspendLayout();
            this.tsTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurma
            // 
            this.dgvTurma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(12, 131);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.RowHeadersVisible = false;
            this.dgvTurma.Size = new System.Drawing.Size(660, 253);
            this.dgvTurma.TabIndex = 43;
            this.dgvTurma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvTurma_MouseClick);
            // 
            // gbTurma
            // 
            this.gbTurma.Controls.Add(this.cbNivel);
            this.gbTurma.Controls.Add(this.lNivel);
            this.gbTurma.Controls.Add(this.label1);
            this.gbTurma.Controls.Add(this.txtProfessor);
            this.gbTurma.Controls.Add(this.mtbFim);
            this.gbTurma.Controls.Add(this.lAs);
            this.gbTurma.Controls.Add(this.mtbInicio);
            this.gbTurma.Controls.Add(this.lNomeT);
            this.gbTurma.Controls.Add(this.txtNomeT);
            this.gbTurma.Controls.Add(this.lHorario);
            this.gbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTurma.Location = new System.Drawing.Point(13, 37);
            this.gbTurma.Name = "gbTurma";
            this.gbTurma.Size = new System.Drawing.Size(659, 87);
            this.gbTurma.TabIndex = 42;
            this.gbTurma.TabStop = false;
            this.gbTurma.Text = "Turma";
            // 
            // cbNivel
            // 
            this.cbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cbNivel.Location = new System.Drawing.Point(496, 56);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(149, 28);
            this.cbNivel.TabIndex = 47;
            // 
            // lNivel
            // 
            this.lNivel.AutoSize = true;
            this.lNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNivel.Location = new System.Drawing.Point(437, 59);
            this.lNivel.Name = "lNivel";
            this.lNivel.Size = new System.Drawing.Size(48, 20);
            this.lNivel.TabIndex = 46;
            this.lNivel.Text = "Nível*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Professor*";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(98, 53);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(328, 26);
            this.txtProfessor.TabIndex = 45;
            // 
            // mtbFim
            // 
            this.mtbFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFim.Location = new System.Drawing.Point(589, 20);
            this.mtbFim.Mask = "00:00";
            this.mtbFim.Name = "mtbFim";
            this.mtbFim.Size = new System.Drawing.Size(56, 26);
            this.mtbFim.TabIndex = 43;
            this.mtbFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFim.ValidatingType = typeof(System.DateTime);
            // 
            // lAs
            // 
            this.lAs.AutoSize = true;
            this.lAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAs.Location = new System.Drawing.Point(558, 24);
            this.lAs.Name = "lAs";
            this.lAs.Size = new System.Drawing.Size(26, 20);
            this.lAs.TabIndex = 42;
            this.lAs.Text = "às";
            // 
            // mtbInicio
            // 
            this.mtbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbInicio.Location = new System.Drawing.Point(496, 20);
            this.mtbInicio.Mask = "00:00";
            this.mtbInicio.Name = "mtbInicio";
            this.mtbInicio.Size = new System.Drawing.Size(56, 26);
            this.mtbInicio.TabIndex = 41;
            this.mtbInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lNomeT
            // 
            this.lNomeT.AutoSize = true;
            this.lNomeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomeT.Location = new System.Drawing.Point(12, 24);
            this.lNomeT.Name = "lNomeT";
            this.lNomeT.Size = new System.Drawing.Size(57, 20);
            this.lNomeT.TabIndex = 33;
            this.lNomeT.Text = "Nome*";
            // 
            // txtNomeT
            // 
            this.txtNomeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeT.Location = new System.Drawing.Point(69, 21);
            this.txtNomeT.Name = "txtNomeT";
            this.txtNomeT.Size = new System.Drawing.Size(357, 26);
            this.txtNomeT.TabIndex = 34;
            // 
            // lHorario
            // 
            this.lHorario.AutoSize = true;
            this.lHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHorario.Location = new System.Drawing.Point(432, 23);
            this.lHorario.Name = "lHorario";
            this.lHorario.Size = new System.Drawing.Size(67, 20);
            this.lHorario.TabIndex = 35;
            this.lHorario.Text = "Horário*";
            // 
            // tsTurma
            // 
            this.tsTurma.AutoSize = false;
            this.tsTurma.BackgroundImage = global::Easy_Idiomas.Properties.Resources.logon4;
            this.tsTurma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarT,
            this.tsbAlterarT,
            this.tsbExcluirT,
            this.toolStripSeparator1,
            this.tslBuscarT,
            this.tstIdT,
            this.tsbBuscarT});
            this.tsTurma.Location = new System.Drawing.Point(0, 0);
            this.tsTurma.Name = "tsTurma";
            this.tsTurma.Size = new System.Drawing.Size(684, 31);
            this.tsTurma.TabIndex = 41;
            this.tsTurma.Text = "toolStrip1";
            // 
            // tsbSalvarT
            // 
            this.tsbSalvarT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarT.Image = global::Easy_Idiomas.Properties.Resources.icone_salvar;
            this.tsbSalvarT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarT.Name = "tsbSalvarT";
            this.tsbSalvarT.Size = new System.Drawing.Size(23, 28);
            this.tsbSalvarT.Text = "Salvar";
            this.tsbSalvarT.Click += new System.EventHandler(this.tsbSalvarT_Click);
            // 
            // tsbAlterarT
            // 
            this.tsbAlterarT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterarT.Image = global::Easy_Idiomas.Properties.Resources._12;
            this.tsbAlterarT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterarT.Name = "tsbAlterarT";
            this.tsbAlterarT.Size = new System.Drawing.Size(23, 28);
            this.tsbAlterarT.Text = "Alterar";
            this.tsbAlterarT.Click += new System.EventHandler(this.tsbAlterarT_Click);
            // 
            // tsbExcluirT
            // 
            this.tsbExcluirT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluirT.Image = global::Easy_Idiomas.Properties.Resources.icone_excluir;
            this.tsbExcluirT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluirT.Name = "tsbExcluirT";
            this.tsbExcluirT.Size = new System.Drawing.Size(23, 28);
            this.tsbExcluirT.Text = "excluir";
            this.tsbExcluirT.Click += new System.EventHandler(this.tsbExcluirT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tslBuscarT
            // 
            this.tslBuscarT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslBuscarT.ForeColor = System.Drawing.SystemColors.Control;
            this.tslBuscarT.Name = "tslBuscarT";
            this.tslBuscarT.Size = new System.Drawing.Size(93, 28);
            this.tslBuscarT.Text = "Buscar por Id:";
            // 
            // tstIdT
            // 
            this.tstIdT.Name = "tstIdT";
            this.tstIdT.Size = new System.Drawing.Size(100, 31);
            // 
            // tsbBuscarT
            // 
            this.tsbBuscarT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarT.Image = global::Easy_Idiomas.Properties.Resources.icone_pesquisa;
            this.tsbBuscarT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarT.Name = "tsbBuscarT";
            this.tsbBuscarT.Size = new System.Drawing.Size(23, 28);
            this.tsbBuscarT.Text = "Buscar";
            this.tsbBuscarT.Click += new System.EventHandler(this.tsbBuscarT_Click);
            // 
            // Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.gbTurma);
            this.Controls.Add(this.tsTurma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Turma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.Turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.gbTurma.ResumeLayout(false);
            this.gbTurma.PerformLayout();
            this.tsTurma.ResumeLayout(false);
            this.tsTurma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.GroupBox gbTurma;
        private System.Windows.Forms.Label lNomeT;
        private System.Windows.Forms.TextBox txtNomeT;
        private System.Windows.Forms.Label lHorario;
        private System.Windows.Forms.ToolStrip tsTurma;
        private System.Windows.Forms.ToolStripButton tsbSalvarT;
        private System.Windows.Forms.ToolStripButton tsbAlterarT;
        private System.Windows.Forms.ToolStripButton tsbExcluirT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslBuscarT;
        private System.Windows.Forms.ToolStripTextBox tstIdT;
        private System.Windows.Forms.ToolStripButton tsbBuscarT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.MaskedTextBox mtbFim;
        private System.Windows.Forms.Label lAs;
        private System.Windows.Forms.MaskedTextBox mtbInicio;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lNivel;
    }
}