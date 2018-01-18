namespace Easy_Idiomas
{
    partial class fLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.txt_L_Id = new System.Windows.Forms.TextBox();
            this.txt_L_Senha = new System.Windows.Forms.TextBox();
            this.bEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_L_Id
            // 
            this.txt_L_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L_Id.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_L_Id.Location = new System.Drawing.Point(60, 192);
            this.txt_L_Id.Name = "txt_L_Id";
            this.txt_L_Id.Size = new System.Drawing.Size(175, 26);
            this.txt_L_Id.TabIndex = 0;
            this.txt_L_Id.Text = "RG";
            // 
            // txt_L_Senha
            // 
            this.txt_L_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L_Senha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_L_Senha.Location = new System.Drawing.Point(60, 235);
            this.txt_L_Senha.Name = "txt_L_Senha";
            this.txt_L_Senha.PasswordChar = '*';
            this.txt_L_Senha.Size = new System.Drawing.Size(175, 26);
            this.txt_L_Senha.TabIndex = 1;
            this.txt_L_Senha.Text = "Senha";
            // 
            // bEntrar
            // 
            this.bEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEntrar.Location = new System.Drawing.Point(60, 280);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(175, 28);
            this.bEntrar.TabIndex = 2;
            this.bEntrar.Text = "Entrar";
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Easy_Idiomas.Properties.Resources.EASYYYYY1;
            this.ClientSize = new System.Drawing.Size(296, 359);
            this.Controls.Add(this.bEntrar);
            this.Controls.Add(this.txt_L_Senha);
            this.Controls.Add(this.txt_L_Id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_L_Id;
        private System.Windows.Forms.TextBox txt_L_Senha;
        private System.Windows.Forms.Button bEntrar;
    }
}

