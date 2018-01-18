namespace Easy_Idiomas
{
    partial class Relatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.tsRelatorio = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cPagar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ckb3dp = new System.Windows.Forms.CheckBox();
            this.cReceber = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ckb3dr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // tsRelatorio
            // 
            this.tsRelatorio.AutoSize = false;
            this.tsRelatorio.BackgroundImage = global::Easy_Idiomas.Properties.Resources.logon4;
            this.tsRelatorio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.tsRelatorio.Location = new System.Drawing.Point(0, 0);
            this.tsRelatorio.Name = "tsRelatorio";
            this.tsRelatorio.Size = new System.Drawing.Size(684, 31);
            this.tsRelatorio.TabIndex = 33;
            this.tsRelatorio.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(155, 28);
            this.toolStripLabel1.Text = "Balanço Financeiro";
            // 
            // cPagar
            // 
            chartArea1.Name = "ChartArea1";
            this.cPagar.ChartAreas.Add(chartArea1);
            this.cPagar.Location = new System.Drawing.Point(23, 98);
            this.cPagar.Name = "cPagar";
            series1.ChartArea = "ChartArea1";
            series1.Name = "0";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series3";
            this.cPagar.Series.Add(series1);
            this.cPagar.Series.Add(series2);
            this.cPagar.Series.Add(series3);
            this.cPagar.Size = new System.Drawing.Size(317, 256);
            this.cPagar.TabIndex = 34;
            this.cPagar.Text = "chartPagar";
            this.cPagar.Click += new System.EventHandler(this.cBalanco_Click);
            // 
            // ckb3dp
            // 
            this.ckb3dp.AutoSize = true;
            this.ckb3dp.BackColor = System.Drawing.Color.Transparent;
            this.ckb3dp.Location = new System.Drawing.Point(270, 360);
            this.ckb3dp.Name = "ckb3dp";
            this.ckb3dp.Size = new System.Drawing.Size(70, 17);
            this.ckb3dp.TabIndex = 35;
            this.ckb3dp.Text = "Ativar 3D";
            this.ckb3dp.UseVisualStyleBackColor = false;
            this.ckb3dp.CheckedChanged += new System.EventHandler(this.ckb3d_CheckedChanged);
            // 
            // cReceber
            // 
            chartArea2.Name = "ChartArea1";
            this.cReceber.ChartAreas.Add(chartArea2);
            this.cReceber.Location = new System.Drawing.Point(361, 98);
            this.cReceber.Name = "cReceber";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.cReceber.Series.Add(series4);
            this.cReceber.Size = new System.Drawing.Size(300, 256);
            this.cReceber.TabIndex = 36;
            this.cReceber.Text = "chart1";
            this.cReceber.Click += new System.EventHandler(this.cReceber_Click);
            // 
            // ckb3dr
            // 
            this.ckb3dr.AutoSize = true;
            this.ckb3dr.BackColor = System.Drawing.Color.Transparent;
            this.ckb3dr.Location = new System.Drawing.Point(596, 360);
            this.ckb3dr.Name = "ckb3dr";
            this.ckb3dr.Size = new System.Drawing.Size(70, 17);
            this.ckb3dr.TabIndex = 37;
            this.ckb3dr.Text = "Ativar 3D";
            this.ckb3dr.UseVisualStyleBackColor = false;
            this.ckb3dr.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Contas a Pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Contas a Receber";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckb3dr);
            this.Controls.Add(this.cReceber);
            this.Controls.Add(this.ckb3dp);
            this.Controls.Add(this.cPagar);
            this.Controls.Add(this.tsRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.tsRelatorio.ResumeLayout(false);
            this.tsRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRelatorio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPagar;
        private System.Windows.Forms.CheckBox ckb3dp;
        private System.Windows.Forms.DataVisualization.Charting.Chart cReceber;
        private System.Windows.Forms.CheckBox ckb3dr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}