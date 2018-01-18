namespace Easy_Idiomas
{
    partial class Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.bFotoAluno = new System.Windows.Forms.Button();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            this.cbUfA = new System.Windows.Forms.ComboBox();
            this.lUf = new System.Windows.Forms.Label();
            this.txtEmailA = new System.Windows.Forms.TextBox();
            this.lEmailA = new System.Windows.Forms.Label();
            this.txtBairroA = new System.Windows.Forms.TextBox();
            this.lBairroA = new System.Windows.Forms.Label();
            this.txtCidadeA = new System.Windows.Forms.TextBox();
            this.lCidadeA = new System.Windows.Forms.Label();
            this.mtbCepA = new System.Windows.Forms.MaskedTextBox();
            this.lCepA = new System.Windows.Forms.Label();
            this.mtbNumeroA = new System.Windows.Forms.MaskedTextBox();
            this.lNumeroA = new System.Windows.Forms.Label();
            this.txtEnderecoA = new System.Windows.Forms.TextBox();
            this.lEnderecoA = new System.Windows.Forms.Label();
            this.mtbCelularA = new System.Windows.Forms.MaskedTextBox();
            this.lCelularA = new System.Windows.Forms.Label();
            this.mtbTelefoneA = new System.Windows.Forms.MaskedTextBox();
            this.lTelefoneA = new System.Windows.Forms.Label();
            this.mtbCpfA = new System.Windows.Forms.MaskedTextBox();
            this.lCpfA = new System.Windows.Forms.Label();
            this.mtbRgA = new System.Windows.Forms.MaskedTextBox();
            this.lRgA = new System.Windows.Forms.Label();
            this.cbSexoA = new System.Windows.Forms.ComboBox();
            this.lSexoA = new System.Windows.Forms.Label();
            this.mtbDataNascA = new System.Windows.Forms.MaskedTextBox();
            this.lDataNascA = new System.Windows.Forms.Label();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.mtbDataPagA = new System.Windows.Forms.ComboBox();
            this.cbNivelA = new System.Windows.Forms.ComboBox();
            this.lNivelA = new System.Windows.Forms.Label();
            this.lDataPagA = new System.Windows.Forms.Label();
            this.mtbMensalidade = new System.Windows.Forms.MaskedTextBox();
            this.lMensalidade = new System.Windows.Forms.Label();
            this.txtSenhaA = new System.Windows.Forms.TextBox();
            this.lSenhaA = new System.Windows.Forms.Label();
            this.txtNomeA = new System.Windows.Forms.TextBox();
            this.lNomeA = new System.Windows.Forms.Label();
            this.ofdFotoA = new System.Windows.Forms.OpenFileDialog();
            this.tsAluno = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarA = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterarA = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluirA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBuscarA = new System.Windows.Forms.ToolStripLabel();
            this.tstIdA = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscarA = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.gbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            this.gbRegistro.SuspendLayout();
            this.tsAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(11, 324);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(660, 167);
            this.dgvAluno.TabIndex = 34;
            this.dgvAluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAluno_MouseClick_1);
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.bFotoAluno);
            this.gbDadosPessoais.Controls.Add(this.pbAluno);
            this.gbDadosPessoais.Controls.Add(this.cbUfA);
            this.gbDadosPessoais.Controls.Add(this.lUf);
            this.gbDadosPessoais.Controls.Add(this.txtEmailA);
            this.gbDadosPessoais.Controls.Add(this.lEmailA);
            this.gbDadosPessoais.Controls.Add(this.txtBairroA);
            this.gbDadosPessoais.Controls.Add(this.lBairroA);
            this.gbDadosPessoais.Controls.Add(this.txtCidadeA);
            this.gbDadosPessoais.Controls.Add(this.lCidadeA);
            this.gbDadosPessoais.Controls.Add(this.mtbCepA);
            this.gbDadosPessoais.Controls.Add(this.lCepA);
            this.gbDadosPessoais.Controls.Add(this.mtbNumeroA);
            this.gbDadosPessoais.Controls.Add(this.lNumeroA);
            this.gbDadosPessoais.Controls.Add(this.txtEnderecoA);
            this.gbDadosPessoais.Controls.Add(this.lEnderecoA);
            this.gbDadosPessoais.Controls.Add(this.mtbCelularA);
            this.gbDadosPessoais.Controls.Add(this.lCelularA);
            this.gbDadosPessoais.Controls.Add(this.mtbTelefoneA);
            this.gbDadosPessoais.Controls.Add(this.lTelefoneA);
            this.gbDadosPessoais.Controls.Add(this.mtbCpfA);
            this.gbDadosPessoais.Controls.Add(this.lCpfA);
            this.gbDadosPessoais.Controls.Add(this.mtbRgA);
            this.gbDadosPessoais.Controls.Add(this.lRgA);
            this.gbDadosPessoais.Controls.Add(this.cbSexoA);
            this.gbDadosPessoais.Controls.Add(this.lSexoA);
            this.gbDadosPessoais.Controls.Add(this.mtbDataNascA);
            this.gbDadosPessoais.Controls.Add(this.lDataNascA);
            this.gbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoais.Location = new System.Drawing.Point(12, 121);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(660, 195);
            this.gbDadosPessoais.TabIndex = 33;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // bFotoAluno
            // 
            this.bFotoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFotoAluno.Location = new System.Drawing.Point(14, 159);
            this.bFotoAluno.Name = "bFotoAluno";
            this.bFotoAluno.Size = new System.Drawing.Size(100, 29);
            this.bFotoAluno.TabIndex = 33;
            this.bFotoAluno.Text = "Foto";
            this.bFotoAluno.UseVisualStyleBackColor = true;
            this.bFotoAluno.Click += new System.EventHandler(this.bFotoAluno_Click);
            // 
            // pbAluno
            // 
            this.pbAluno.Location = new System.Drawing.Point(14, 26);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(100, 124);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 32;
            this.pbAluno.TabStop = false;
            // 
            // cbUfA
            // 
            this.cbUfA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUfA.FormattingEnabled = true;
            this.cbUfA.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "ES",
            "MA",
            "MG",
            "MS",
            "MT",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RO",
            "RR",
            "RS",
            "SE",
            "SC",
            "SP",
            "TO"});
            this.cbUfA.Location = new System.Drawing.Point(594, 127);
            this.cbUfA.Name = "cbUfA";
            this.cbUfA.Size = new System.Drawing.Size(54, 28);
            this.cbUfA.TabIndex = 17;
            // 
            // lUf
            // 
            this.lUf.AutoSize = true;
            this.lUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUf.Location = new System.Drawing.Point(558, 130);
            this.lUf.Name = "lUf";
            this.lUf.Size = new System.Drawing.Size(37, 20);
            this.lUf.TabIndex = 30;
            this.lUf.Text = "UF*";
            // 
            // txtEmailA
            // 
            this.txtEmailA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailA.Location = new System.Drawing.Point(192, 163);
            this.txtEmailA.Name = "txtEmailA";
            this.txtEmailA.Size = new System.Drawing.Size(286, 26);
            this.txtEmailA.TabIndex = 18;
            // 
            // lEmailA
            // 
            this.lEmailA.AutoSize = true;
            this.lEmailA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmailA.Location = new System.Drawing.Point(125, 166);
            this.lEmailA.Name = "lEmailA";
            this.lEmailA.Size = new System.Drawing.Size(53, 20);
            this.lEmailA.TabIndex = 28;
            this.lEmailA.Text = "E-mail";
            // 
            // txtBairroA
            // 
            this.txtBairroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroA.Location = new System.Drawing.Point(441, 127);
            this.txtBairroA.Name = "txtBairroA";
            this.txtBairroA.Size = new System.Drawing.Size(116, 26);
            this.txtBairroA.TabIndex = 16;
            // 
            // lBairroA
            // 
            this.lBairroA.AutoSize = true;
            this.lBairroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBairroA.Location = new System.Drawing.Point(385, 130);
            this.lBairroA.Name = "lBairroA";
            this.lBairroA.Size = new System.Drawing.Size(57, 20);
            this.lBairroA.TabIndex = 26;
            this.lBairroA.Text = "Bairro*";
            // 
            // txtCidadeA
            // 
            this.txtCidadeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeA.Location = new System.Drawing.Point(188, 127);
            this.txtCidadeA.Name = "txtCidadeA";
            this.txtCidadeA.Size = new System.Drawing.Size(193, 26);
            this.txtCidadeA.TabIndex = 15;
            // 
            // lCidadeA
            // 
            this.lCidadeA.AutoSize = true;
            this.lCidadeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCidadeA.Location = new System.Drawing.Point(124, 130);
            this.lCidadeA.Name = "lCidadeA";
            this.lCidadeA.Size = new System.Drawing.Size(65, 20);
            this.lCidadeA.TabIndex = 24;
            this.lCidadeA.Text = "Cidade*";
            // 
            // mtbCepA
            // 
            this.mtbCepA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCepA.Location = new System.Drawing.Point(560, 90);
            this.mtbCepA.Mask = "00000-000";
            this.mtbCepA.Name = "mtbCepA";
            this.mtbCepA.Size = new System.Drawing.Size(88, 26);
            this.mtbCepA.TabIndex = 14;
            this.mtbCepA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCepA
            // 
            this.lCepA.AutoSize = true;
            this.lCepA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCepA.Location = new System.Drawing.Point(518, 96);
            this.lCepA.Name = "lCepA";
            this.lCepA.Size = new System.Drawing.Size(41, 20);
            this.lCepA.TabIndex = 22;
            this.lCepA.Text = "CEP";
            // 
            // mtbNumeroA
            // 
            this.mtbNumeroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumeroA.Location = new System.Drawing.Point(455, 93);
            this.mtbNumeroA.Name = "mtbNumeroA";
            this.mtbNumeroA.Size = new System.Drawing.Size(58, 26);
            this.mtbNumeroA.TabIndex = 13;
            this.mtbNumeroA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lNumeroA
            // 
            this.lNumeroA.AutoSize = true;
            this.lNumeroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumeroA.Location = new System.Drawing.Point(419, 96);
            this.lNumeroA.Name = "lNumeroA";
            this.lNumeroA.Size = new System.Drawing.Size(36, 20);
            this.lNumeroA.TabIndex = 20;
            this.lNumeroA.Text = "Nº *";
            // 
            // txtEnderecoA
            // 
            this.txtEnderecoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoA.Location = new System.Drawing.Point(172, 93);
            this.txtEnderecoA.Name = "txtEnderecoA";
            this.txtEnderecoA.Size = new System.Drawing.Size(241, 26);
            this.txtEnderecoA.TabIndex = 12;
            // 
            // lEnderecoA
            // 
            this.lEnderecoA.AutoSize = true;
            this.lEnderecoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnderecoA.Location = new System.Drawing.Point(125, 96);
            this.lEnderecoA.Name = "lEnderecoA";
            this.lEnderecoA.Size = new System.Drawing.Size(44, 20);
            this.lEnderecoA.TabIndex = 18;
            this.lEnderecoA.Text = "End*";
            // 
            // mtbCelularA
            // 
            this.mtbCelularA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelularA.Location = new System.Drawing.Point(521, 55);
            this.mtbCelularA.Mask = "(000) 0000-0000";
            this.mtbCelularA.Name = "mtbCelularA";
            this.mtbCelularA.Size = new System.Drawing.Size(128, 26);
            this.mtbCelularA.TabIndex = 11;
            this.mtbCelularA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCelularA
            // 
            this.lCelularA.AutoSize = true;
            this.lCelularA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCelularA.Location = new System.Drawing.Point(487, 58);
            this.lCelularA.Name = "lCelularA";
            this.lCelularA.Size = new System.Drawing.Size(32, 20);
            this.lCelularA.TabIndex = 16;
            this.lCelularA.Text = "Cel";
            // 
            // mtbTelefoneA
            // 
            this.mtbTelefoneA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneA.Location = new System.Drawing.Point(348, 55);
            this.mtbTelefoneA.Mask = "(999) 0000-0000";
            this.mtbTelefoneA.Name = "mtbTelefoneA";
            this.mtbTelefoneA.Size = new System.Drawing.Size(137, 26);
            this.mtbTelefoneA.TabIndex = 10;
            this.mtbTelefoneA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lTelefoneA
            // 
            this.lTelefoneA.AutoSize = true;
            this.lTelefoneA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefoneA.Location = new System.Drawing.Point(308, 58);
            this.lTelefoneA.Name = "lTelefoneA";
            this.lTelefoneA.Size = new System.Drawing.Size(30, 20);
            this.lTelefoneA.TabIndex = 14;
            this.lTelefoneA.Text = "Tel";
            // 
            // mtbCpfA
            // 
            this.mtbCpfA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfA.Location = new System.Drawing.Point(172, 55);
            this.mtbCpfA.Mask = "00000000000";
            this.mtbCpfA.Name = "mtbCpfA";
            this.mtbCpfA.Size = new System.Drawing.Size(112, 26);
            this.mtbCpfA.TabIndex = 9;
            this.mtbCpfA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCpfA
            // 
            this.lCpfA.AutoSize = true;
            this.lCpfA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCpfA.Location = new System.Drawing.Point(126, 58);
            this.lCpfA.Name = "lCpfA";
            this.lCpfA.Size = new System.Drawing.Size(46, 20);
            this.lCpfA.TabIndex = 12;
            this.lCpfA.Text = "CPF*";
            // 
            // mtbRgA
            // 
            this.mtbRgA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRgA.Location = new System.Drawing.Point(549, 18);
            this.mtbRgA.Mask = "000000000";
            this.mtbRgA.Name = "mtbRgA";
            this.mtbRgA.Size = new System.Drawing.Size(100, 26);
            this.mtbRgA.TabIndex = 8;
            this.mtbRgA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lRgA
            // 
            this.lRgA.AutoSize = true;
            this.lRgA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRgA.Location = new System.Drawing.Point(509, 21);
            this.lRgA.Name = "lRgA";
            this.lRgA.Size = new System.Drawing.Size(40, 20);
            this.lRgA.TabIndex = 10;
            this.lRgA.Text = "RG*";
            // 
            // cbSexoA
            // 
            this.cbSexoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexoA.FormattingEnabled = true;
            this.cbSexoA.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexoA.Location = new System.Drawing.Point(457, 17);
            this.cbSexoA.Name = "cbSexoA";
            this.cbSexoA.Size = new System.Drawing.Size(51, 28);
            this.cbSexoA.TabIndex = 7;
            // 
            // lSexoA
            // 
            this.lSexoA.AutoSize = true;
            this.lSexoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSexoA.Location = new System.Drawing.Point(400, 21);
            this.lSexoA.Name = "lSexoA";
            this.lSexoA.Size = new System.Drawing.Size(45, 20);
            this.lSexoA.TabIndex = 9;
            this.lSexoA.Text = "Sexo";
            // 
            // mtbDataNascA
            // 
            this.mtbDataNascA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataNascA.Location = new System.Drawing.Point(292, 20);
            this.mtbDataNascA.Mask = "00/00/0000";
            this.mtbDataNascA.Name = "mtbDataNascA";
            this.mtbDataNascA.Size = new System.Drawing.Size(100, 26);
            this.mtbDataNascA.TabIndex = 6;
            this.mtbDataNascA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lDataNascA
            // 
            this.lDataNascA.AutoSize = true;
            this.lDataNascA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataNascA.Location = new System.Drawing.Point(126, 24);
            this.lDataNascA.Name = "lDataNascA";
            this.lDataNascA.Size = new System.Drawing.Size(160, 20);
            this.lDataNascA.TabIndex = 2;
            this.lDataNascA.Text = "Data de Nascimento*";
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.mtbDataPagA);
            this.gbRegistro.Controls.Add(this.cbNivelA);
            this.gbRegistro.Controls.Add(this.lNivelA);
            this.gbRegistro.Controls.Add(this.lDataPagA);
            this.gbRegistro.Controls.Add(this.mtbMensalidade);
            this.gbRegistro.Controls.Add(this.lMensalidade);
            this.gbRegistro.Controls.Add(this.txtSenhaA);
            this.gbRegistro.Controls.Add(this.lSenhaA);
            this.gbRegistro.Controls.Add(this.txtNomeA);
            this.gbRegistro.Controls.Add(this.lNomeA);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(11, 36);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(660, 85);
            this.gbRegistro.TabIndex = 32;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro";
            // 
            // mtbDataPagA
            // 
            this.mtbDataPagA.FormattingEnabled = true;
            this.mtbDataPagA.Items.AddRange(new object[] {
            "05",
            "10",
            "15",
            "20",
            "30"});
            this.mtbDataPagA.Location = new System.Drawing.Point(369, 52);
            this.mtbDataPagA.Name = "mtbDataPagA";
            this.mtbDataPagA.Size = new System.Drawing.Size(63, 24);
            this.mtbDataPagA.TabIndex = 9;
            // 
            // cbNivelA
            // 
            this.cbNivelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelA.FormattingEnabled = true;
            this.cbNivelA.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cbNivelA.Location = new System.Drawing.Point(539, 50);
            this.cbNivelA.Name = "cbNivelA";
            this.cbNivelA.Size = new System.Drawing.Size(110, 28);
            this.cbNivelA.TabIndex = 5;
            // 
            // lNivelA
            // 
            this.lNivelA.AutoSize = true;
            this.lNivelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNivelA.Location = new System.Drawing.Point(468, 55);
            this.lNivelA.Name = "lNivelA";
            this.lNivelA.Size = new System.Drawing.Size(48, 20);
            this.lNivelA.TabIndex = 8;
            this.lNivelA.Text = "Nível*";
            // 
            // lDataPagA
            // 
            this.lDataPagA.AutoSize = true;
            this.lDataPagA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataPagA.Location = new System.Drawing.Point(249, 54);
            this.lDataPagA.Name = "lDataPagA";
            this.lDataPagA.Size = new System.Drawing.Size(100, 20);
            this.lDataPagA.TabIndex = 6;
            this.lDataPagA.Text = "Vencimento*";
            // 
            // mtbMensalidade
            // 
            this.mtbMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMensalidade.Location = new System.Drawing.Point(127, 54);
            this.mtbMensalidade.Name = "mtbMensalidade";
            this.mtbMensalidade.Size = new System.Drawing.Size(100, 26);
            this.mtbMensalidade.TabIndex = 3;
            this.mtbMensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lMensalidade
            // 
            this.lMensalidade.AutoSize = true;
            this.lMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensalidade.Location = new System.Drawing.Point(20, 56);
            this.lMensalidade.Name = "lMensalidade";
            this.lMensalidade.Size = new System.Drawing.Size(105, 20);
            this.lMensalidade.TabIndex = 4;
            this.lMensalidade.Text = "Mensalidade*";
            // 
            // txtSenhaA
            // 
            this.txtSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaA.Location = new System.Drawing.Point(538, 20);
            this.txtSenhaA.Name = "txtSenhaA";
            this.txtSenhaA.Size = new System.Drawing.Size(111, 26);
            this.txtSenhaA.TabIndex = 2;
            this.txtSenhaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSenhaA
            // 
            this.lSenhaA.AutoSize = true;
            this.lSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSenhaA.Location = new System.Drawing.Point(468, 23);
            this.lSenhaA.Name = "lSenhaA";
            this.lSenhaA.Size = new System.Drawing.Size(62, 20);
            this.lSenhaA.TabIndex = 2;
            this.lSenhaA.Text = "Senha*";
            // 
            // txtNomeA
            // 
            this.txtNomeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeA.Location = new System.Drawing.Point(83, 20);
            this.txtNomeA.Name = "txtNomeA";
            this.txtNomeA.Size = new System.Drawing.Size(368, 26);
            this.txtNomeA.TabIndex = 1;
            // 
            // lNomeA
            // 
            this.lNomeA.AutoSize = true;
            this.lNomeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomeA.Location = new System.Drawing.Point(20, 23);
            this.lNomeA.Name = "lNomeA";
            this.lNomeA.Size = new System.Drawing.Size(57, 20);
            this.lNomeA.TabIndex = 0;
            this.lNomeA.Text = "Nome*";
            // 
            // ofdFotoA
            // 
            this.ofdFotoA.FileName = "openFileDialog1";
            // 
            // tsAluno
            // 
            this.tsAluno.AutoSize = false;
            this.tsAluno.BackgroundImage = global::Easy_Idiomas.Properties.Resources.logon4;
            this.tsAluno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarA,
            this.tsbAlterarA,
            this.tsbExcluirA,
            this.toolStripSeparator1,
            this.tslBuscarA,
            this.tstIdA,
            this.tsbBuscarA});
            this.tsAluno.Location = new System.Drawing.Point(0, 0);
            this.tsAluno.Name = "tsAluno";
            this.tsAluno.Size = new System.Drawing.Size(684, 31);
            this.tsAluno.TabIndex = 35;
            this.tsAluno.Text = "toolStrip1";
            // 
            // tsbSalvarA
            // 
            this.tsbSalvarA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarA.Image = global::Easy_Idiomas.Properties.Resources.icone_salvar;
            this.tsbSalvarA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarA.Name = "tsbSalvarA";
            this.tsbSalvarA.Size = new System.Drawing.Size(23, 28);
            this.tsbSalvarA.Text = "Salvar";
            this.tsbSalvarA.Click += new System.EventHandler(this.tsbSalvarA_Click);
            // 
            // tsbAlterarA
            // 
            this.tsbAlterarA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterarA.Image = global::Easy_Idiomas.Properties.Resources._14;
            this.tsbAlterarA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterarA.Name = "tsbAlterarA";
            this.tsbAlterarA.Size = new System.Drawing.Size(23, 28);
            this.tsbAlterarA.Text = "Alterar";
            this.tsbAlterarA.Click += new System.EventHandler(this.tsbAlterarA_Click);
            // 
            // tsbExcluirA
            // 
            this.tsbExcluirA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluirA.Image = global::Easy_Idiomas.Properties.Resources.icone_excluir;
            this.tsbExcluirA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluirA.Name = "tsbExcluirA";
            this.tsbExcluirA.Size = new System.Drawing.Size(23, 28);
            this.tsbExcluirA.Text = "excluir";
            this.tsbExcluirA.Click += new System.EventHandler(this.tsbExcluirA_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tslBuscarA
            // 
            this.tslBuscarA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslBuscarA.ForeColor = System.Drawing.SystemColors.Control;
            this.tslBuscarA.Name = "tslBuscarA";
            this.tslBuscarA.Size = new System.Drawing.Size(93, 28);
            this.tslBuscarA.Text = "Buscar por Id:";
            // 
            // tstIdA
            // 
            this.tstIdA.Name = "tstIdA";
            this.tstIdA.Size = new System.Drawing.Size(100, 31);
            // 
            // tsbBuscarA
            // 
            this.tsbBuscarA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarA.Image = global::Easy_Idiomas.Properties.Resources.icone_pesquisa;
            this.tsbBuscarA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarA.Name = "tsbBuscarA";
            this.tsbBuscarA.Size = new System.Drawing.Size(23, 28);
            this.tsbBuscarA.Text = "Buscar";
            this.tsbBuscarA.Click += new System.EventHandler(this.tsbBuscarA_Click);
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 498);
            this.Controls.Add(this.tsAluno);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.gbRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.tsAluno.ResumeLayout(false);
            this.tsAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsAluno;
        private System.Windows.Forms.ToolStripButton tsbSalvarA;
        private System.Windows.Forms.ToolStripButton tsbAlterarA;
        private System.Windows.Forms.ToolStripButton tsbExcluirA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslBuscarA;
        private System.Windows.Forms.ToolStripTextBox tstIdA;
        private System.Windows.Forms.ToolStripButton tsbBuscarA;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.TextBox txtEmailA;
        private System.Windows.Forms.Label lEmailA;
        private System.Windows.Forms.TextBox txtBairroA;
        private System.Windows.Forms.Label lBairroA;
        private System.Windows.Forms.TextBox txtCidadeA;
        private System.Windows.Forms.Label lCidadeA;
        private System.Windows.Forms.MaskedTextBox mtbCepA;
        private System.Windows.Forms.Label lCepA;
        private System.Windows.Forms.MaskedTextBox mtbNumeroA;
        private System.Windows.Forms.Label lNumeroA;
        private System.Windows.Forms.TextBox txtEnderecoA;
        private System.Windows.Forms.Label lEnderecoA;
        private System.Windows.Forms.MaskedTextBox mtbCelularA;
        private System.Windows.Forms.Label lCelularA;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneA;
        private System.Windows.Forms.Label lTelefoneA;
        private System.Windows.Forms.MaskedTextBox mtbCpfA;
        private System.Windows.Forms.Label lCpfA;
        private System.Windows.Forms.MaskedTextBox mtbRgA;
        private System.Windows.Forms.Label lRgA;
        private System.Windows.Forms.ComboBox cbSexoA;
        private System.Windows.Forms.Label lSexoA;
        private System.Windows.Forms.MaskedTextBox mtbDataNascA;
        private System.Windows.Forms.Label lDataNascA;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lNivelA;
        private System.Windows.Forms.Label lDataPagA;
        private System.Windows.Forms.MaskedTextBox mtbMensalidade;
        private System.Windows.Forms.Label lMensalidade;
        private System.Windows.Forms.TextBox txtSenhaA;
        private System.Windows.Forms.Label lSenhaA;
        private System.Windows.Forms.TextBox txtNomeA;
        private System.Windows.Forms.Label lNomeA;
        private System.Windows.Forms.ComboBox cbUfA;
        private System.Windows.Forms.Label lUf;
        private System.Windows.Forms.OpenFileDialog ofdFotoA;
        private System.Windows.Forms.ComboBox cbNivelA;
        private System.Windows.Forms.Button bFotoAluno;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.ComboBox mtbDataPagA;
    }
}