namespace Easy_Idiomas
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.mtbDataPag = new System.Windows.Forms.ComboBox();
            this.txtFuncao = new System.Windows.Forms.ComboBox();
            this.lFuncao = new System.Windows.Forms.Label();
            this.lDataPag = new System.Windows.Forms.Label();
            this.mtbSalario = new System.Windows.Forms.MaskedTextBox();
            this.lSalario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.bFotoFuncionario = new System.Windows.Forms.Button();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.lUf = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lCidade = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lCep = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lEndereco = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lCelular = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lTelefone = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lCpf = new System.Windows.Forms.Label();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.lRg = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lSexo = new System.Windows.Forms.Label();
            this.mtbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lDataNasc = new System.Windows.Forms.Label();
            this.gbBanco = new System.Windows.Forms.GroupBox();
            this.mtbConta = new System.Windows.Forms.MaskedTextBox();
            this.lNConta = new System.Windows.Forms.Label();
            this.mtbAgencia = new System.Windows.Forms.MaskedTextBox();
            this.lagencia = new System.Windows.Forms.Label();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.lConta = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lBanco = new System.Windows.Forms.Label();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.ofdFotoF = new System.Windows.Forms.OpenFileDialog();
            this.tsFuncionario = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarF = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterarF = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluirF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBuscarPorId = new System.Windows.Forms.ToolStripLabel();
            this.tstId = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.gbRegistro.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.gbBanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.tsFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistro
            // 
            this.gbRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegistro.Controls.Add(this.mtbDataPag);
            this.gbRegistro.Controls.Add(this.txtFuncao);
            this.gbRegistro.Controls.Add(this.lFuncao);
            this.gbRegistro.Controls.Add(this.lDataPag);
            this.gbRegistro.Controls.Add(this.mtbSalario);
            this.gbRegistro.Controls.Add(this.lSalario);
            this.gbRegistro.Controls.Add(this.txtSenha);
            this.gbRegistro.Controls.Add(this.lSenha);
            this.gbRegistro.Controls.Add(this.txtNome);
            this.gbRegistro.Controls.Add(this.lNome);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(11, 34);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(660, 85);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro";
            // 
            // mtbDataPag
            // 
            this.mtbDataPag.FormattingEnabled = true;
            this.mtbDataPag.Items.AddRange(new object[] {
            "05",
            "10",
            "15",
            "20",
            "30"});
            this.mtbDataPag.Location = new System.Drawing.Point(364, 54);
            this.mtbDataPag.Name = "mtbDataPag";
            this.mtbDataPag.Size = new System.Drawing.Size(85, 24);
            this.mtbDataPag.TabIndex = 10;
            // 
            // txtFuncao
            // 
            this.txtFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncao.FormattingEnabled = true;
            this.txtFuncao.Items.AddRange(new object[] {
            "Administrativo",
            "Professor",
            "Serviços Gerais"});
            this.txtFuncao.Location = new System.Drawing.Point(539, 52);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(110, 24);
            this.txtFuncao.TabIndex = 9;
            // 
            // lFuncao
            // 
            this.lFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFuncao.AutoSize = true;
            this.lFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFuncao.Location = new System.Drawing.Point(468, 55);
            this.lFuncao.Name = "lFuncao";
            this.lFuncao.Size = new System.Drawing.Size(69, 20);
            this.lFuncao.TabIndex = 8;
            this.lFuncao.Text = "Função*";
            // 
            // lDataPag
            // 
            this.lDataPag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lDataPag.AutoSize = true;
            this.lDataPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataPag.Location = new System.Drawing.Point(190, 54);
            this.lDataPag.Name = "lDataPag";
            this.lDataPag.Size = new System.Drawing.Size(158, 20);
            this.lDataPag.TabIndex = 6;
            this.lDataPag.Text = "Data de Pagamento*";
            // 
            // mtbSalario
            // 
            this.mtbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSalario.Location = new System.Drawing.Point(83, 54);
            this.mtbSalario.Name = "mtbSalario";
            this.mtbSalario.Size = new System.Drawing.Size(100, 26);
            this.mtbSalario.TabIndex = 5;
            this.mtbSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSalario
            // 
            this.lSalario.AutoSize = true;
            this.lSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalario.Location = new System.Drawing.Point(20, 56);
            this.lSalario.Name = "lSalario";
            this.lSalario.Size = new System.Drawing.Size(64, 20);
            this.lSalario.TabIndex = 4;
            this.lSalario.Text = "Salário*";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(538, 20);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(111, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSenha
            // 
            this.lSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSenha.AutoSize = true;
            this.lSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSenha.Location = new System.Drawing.Point(468, 23);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(62, 20);
            this.lSenha.TabIndex = 2;
            this.lSenha.Text = "Senha*";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(83, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lNome
            // 
            this.lNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lNome.AutoSize = true;
            this.lNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNome.Location = new System.Drawing.Point(20, 23);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(57, 20);
            this.lNome.TabIndex = 0;
            this.lNome.Text = "Nome*";
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDadosPessoais.Controls.Add(this.bFotoFuncionario);
            this.gbDadosPessoais.Controls.Add(this.pbFuncionario);
            this.gbDadosPessoais.Controls.Add(this.txtEmail);
            this.gbDadosPessoais.Controls.Add(this.cbUf);
            this.gbDadosPessoais.Controls.Add(this.lUf);
            this.gbDadosPessoais.Controls.Add(this.lEmail);
            this.gbDadosPessoais.Controls.Add(this.txtBairro);
            this.gbDadosPessoais.Controls.Add(this.lBairro);
            this.gbDadosPessoais.Controls.Add(this.txtCidade);
            this.gbDadosPessoais.Controls.Add(this.lCidade);
            this.gbDadosPessoais.Controls.Add(this.mtbCep);
            this.gbDadosPessoais.Controls.Add(this.lCep);
            this.gbDadosPessoais.Controls.Add(this.mtbNumero);
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Controls.Add(this.txtEndereco);
            this.gbDadosPessoais.Controls.Add(this.lEndereco);
            this.gbDadosPessoais.Controls.Add(this.mtbCelular);
            this.gbDadosPessoais.Controls.Add(this.lCelular);
            this.gbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gbDadosPessoais.Controls.Add(this.lTelefone);
            this.gbDadosPessoais.Controls.Add(this.mtbCpf);
            this.gbDadosPessoais.Controls.Add(this.lCpf);
            this.gbDadosPessoais.Controls.Add(this.mtbRg);
            this.gbDadosPessoais.Controls.Add(this.lRg);
            this.gbDadosPessoais.Controls.Add(this.cbSexo);
            this.gbDadosPessoais.Controls.Add(this.lSexo);
            this.gbDadosPessoais.Controls.Add(this.mtbDataNasc);
            this.gbDadosPessoais.Controls.Add(this.lDataNasc);
            this.gbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoais.Location = new System.Drawing.Point(11, 119);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(660, 196);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // bFotoFuncionario
            // 
            this.bFotoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFotoFuncionario.Location = new System.Drawing.Point(14, 158);
            this.bFotoFuncionario.Name = "bFotoFuncionario";
            this.bFotoFuncionario.Size = new System.Drawing.Size(100, 29);
            this.bFotoFuncionario.TabIndex = 31;
            this.bFotoFuncionario.Text = "Foto";
            this.bFotoFuncionario.UseVisualStyleBackColor = true;
            this.bFotoFuncionario.Click += new System.EventHandler(this.bFotoFuncionario_Click);
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Location = new System.Drawing.Point(14, 25);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(100, 124);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 30;
            this.pbFuncionario.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(183, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 26);
            this.txtEmail.TabIndex = 29;
            // 
            // cbUf
            // 
            this.cbUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
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
            this.cbUf.Location = new System.Drawing.Point(594, 125);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(54, 28);
            this.cbUf.TabIndex = 29;
            // 
            // lUf
            // 
            this.lUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lUf.AutoSize = true;
            this.lUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUf.Location = new System.Drawing.Point(555, 129);
            this.lUf.Name = "lUf";
            this.lUf.Size = new System.Drawing.Size(37, 20);
            this.lUf.TabIndex = 28;
            this.lUf.Text = "UF*";
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(124, 164);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(53, 20);
            this.lEmail.TabIndex = 28;
            this.lEmail.Text = "E-mail";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(449, 128);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(106, 26);
            this.txtBairro.TabIndex = 27;
            // 
            // lBairro
            // 
            this.lBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBairro.AutoSize = true;
            this.lBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBairro.Location = new System.Drawing.Point(392, 129);
            this.lBairro.Name = "lBairro";
            this.lBairro.Size = new System.Drawing.Size(57, 20);
            this.lBairro.TabIndex = 26;
            this.lBairro.Text = "Bairro*";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(189, 127);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(202, 26);
            this.txtCidade.TabIndex = 25;
            // 
            // lCidade
            // 
            this.lCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCidade.AutoSize = true;
            this.lCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCidade.Location = new System.Drawing.Point(124, 131);
            this.lCidade.Name = "lCidade";
            this.lCidade.Size = new System.Drawing.Size(65, 20);
            this.lCidade.TabIndex = 24;
            this.lCidade.Text = "Cidade*";
            // 
            // mtbCep
            // 
            this.mtbCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCep.Location = new System.Drawing.Point(559, 89);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(88, 26);
            this.mtbCep.TabIndex = 23;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCep
            // 
            this.lCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCep.AutoSize = true;
            this.lCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCep.Location = new System.Drawing.Point(513, 92);
            this.lCep.Name = "lCep";
            this.lCep.Size = new System.Drawing.Size(41, 20);
            this.lCep.TabIndex = 22;
            this.lCep.Text = "CEP";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumero.Location = new System.Drawing.Point(443, 90);
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(63, 26);
            this.mtbNumero.TabIndex = 21;
            this.mtbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nº *";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(167, 91);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(233, 26);
            this.txtEndereco.TabIndex = 19;
            // 
            // lEndereco
            // 
            this.lEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEndereco.AutoSize = true;
            this.lEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndereco.Location = new System.Drawing.Point(124, 92);
            this.lEndereco.Name = "lEndereco";
            this.lEndereco.Size = new System.Drawing.Size(44, 20);
            this.lEndereco.TabIndex = 18;
            this.lEndereco.Text = "End*";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(514, 53);
            this.mtbCelular.Mask = "(000) 0000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(133, 26);
            this.mtbCelular.TabIndex = 17;
            this.mtbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCelular
            // 
            this.lCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCelular.AutoSize = true;
            this.lCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCelular.Location = new System.Drawing.Point(481, 56);
            this.lCelular.Name = "lCelular";
            this.lCelular.Size = new System.Drawing.Size(32, 20);
            this.lCelular.TabIndex = 16;
            this.lCelular.Text = "Cel";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(332, 54);
            this.mtbTelefone.Mask = "(999) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(137, 26);
            this.mtbTelefone.TabIndex = 15;
            this.mtbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lTelefone
            // 
            this.lTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTelefone.AutoSize = true;
            this.lTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefone.Location = new System.Drawing.Point(301, 57);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(30, 20);
            this.lTelefone.TabIndex = 14;
            this.lTelefone.Text = "Tel";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(168, 54);
            this.mtbCpf.Mask = "00000000000";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(112, 26);
            this.mtbCpf.TabIndex = 13;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lCpf
            // 
            this.lCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCpf.AutoSize = true;
            this.lCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCpf.Location = new System.Drawing.Point(124, 57);
            this.lCpf.Name = "lCpf";
            this.lCpf.Size = new System.Drawing.Size(46, 20);
            this.lCpf.TabIndex = 12;
            this.lCpf.Text = "CPF*";
            // 
            // mtbRg
            // 
            this.mtbRg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRg.Location = new System.Drawing.Point(546, 19);
            this.mtbRg.Mask = "000000000";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(100, 26);
            this.mtbRg.TabIndex = 11;
            this.mtbRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lRg
            // 
            this.lRg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRg.AutoSize = true;
            this.lRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRg.Location = new System.Drawing.Point(504, 21);
            this.lRg.Name = "lRg";
            this.lRg.Size = new System.Drawing.Size(40, 20);
            this.lRg.TabIndex = 10;
            this.lRg.Text = "RG*";
            // 
            // cbSexo
            // 
            this.cbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(441, 17);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(60, 28);
            this.cbSexo.TabIndex = 10;
            // 
            // lSexo
            // 
            this.lSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSexo.AutoSize = true;
            this.lSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSexo.Location = new System.Drawing.Point(394, 19);
            this.lSexo.Name = "lSexo";
            this.lSexo.Size = new System.Drawing.Size(45, 20);
            this.lSexo.TabIndex = 9;
            this.lSexo.Text = "Sexo";
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataNasc.Location = new System.Drawing.Point(288, 17);
            this.mtbDataNasc.Mask = "00/00/0000";
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(100, 26);
            this.mtbDataNasc.TabIndex = 8;
            this.mtbDataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lDataNasc
            // 
            this.lDataNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lDataNasc.AutoSize = true;
            this.lDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataNasc.Location = new System.Drawing.Point(124, 22);
            this.lDataNasc.Name = "lDataNasc";
            this.lDataNasc.Size = new System.Drawing.Size(160, 20);
            this.lDataNasc.TabIndex = 2;
            this.lDataNasc.Text = "Data de Nascimento*";
            // 
            // gbBanco
            // 
            this.gbBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbBanco.Controls.Add(this.mtbConta);
            this.gbBanco.Controls.Add(this.lNConta);
            this.gbBanco.Controls.Add(this.mtbAgencia);
            this.gbBanco.Controls.Add(this.lagencia);
            this.gbBanco.Controls.Add(this.cbTipoConta);
            this.gbBanco.Controls.Add(this.lConta);
            this.gbBanco.Controls.Add(this.txtBanco);
            this.gbBanco.Controls.Add(this.lBanco);
            this.gbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBanco.Location = new System.Drawing.Point(11, 320);
            this.gbBanco.Name = "gbBanco";
            this.gbBanco.Size = new System.Drawing.Size(660, 58);
            this.gbBanco.TabIndex = 2;
            this.gbBanco.TabStop = false;
            this.gbBanco.Text = "Dados Bancários";
            // 
            // mtbConta
            // 
            this.mtbConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbConta.Location = new System.Drawing.Point(564, 22);
            this.mtbConta.Name = "mtbConta";
            this.mtbConta.Size = new System.Drawing.Size(82, 26);
            this.mtbConta.TabIndex = 37;
            this.mtbConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lNConta
            // 
            this.lNConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNConta.AutoSize = true;
            this.lNConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNConta.Location = new System.Drawing.Point(510, 24);
            this.lNConta.Name = "lNConta";
            this.lNConta.Size = new System.Drawing.Size(52, 20);
            this.lNConta.TabIndex = 36;
            this.lNConta.Text = "Conta";
            // 
            // mtbAgencia
            // 
            this.mtbAgencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbAgencia.Location = new System.Drawing.Point(431, 23);
            this.mtbAgencia.Name = "mtbAgencia";
            this.mtbAgencia.Size = new System.Drawing.Size(75, 26);
            this.mtbAgencia.TabIndex = 35;
            this.mtbAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lagencia
            // 
            this.lagencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lagencia.AutoSize = true;
            this.lagencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagencia.Location = new System.Drawing.Point(360, 24);
            this.lagencia.Name = "lagencia";
            this.lagencia.Size = new System.Drawing.Size(67, 20);
            this.lagencia.TabIndex = 34;
            this.lagencia.Text = "Agência";
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Items.AddRange(new object[] {
            "Poupança",
            "Corrente",
            "Salário"});
            this.cbTipoConta.Location = new System.Drawing.Point(278, 22);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(79, 28);
            this.cbTipoConta.TabIndex = 33;
            // 
            // lConta
            // 
            this.lConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lConta.AutoSize = true;
            this.lConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConta.Location = new System.Drawing.Point(163, 24);
            this.lConta.Name = "lConta";
            this.lConta.Size = new System.Drawing.Size(114, 20);
            this.lConta.TabIndex = 32;
            this.lConta.Text = "Tipo da Conta*";
            // 
            // txtBanco
            // 
            this.txtBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(69, 22);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(89, 26);
            this.txtBanco.TabIndex = 31;
            // 
            // lBanco
            // 
            this.lBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBanco.AutoSize = true;
            this.lBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBanco.Location = new System.Drawing.Point(8, 24);
            this.lBanco.Name = "lBanco";
            this.lBanco.Size = new System.Drawing.Size(55, 20);
            this.lBanco.TabIndex = 30;
            this.lBanco.Text = "Banco";
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(11, 384);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(661, 167);
            this.dgvFuncionario.TabIndex = 30;
            this.dgvFuncionario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFuncionario_MouseClick_1);
            // 
            // ofdFotoF
            // 
            this.ofdFotoF.FileName = "openFileDialog1";
            // 
            // tsFuncionario
            // 
            this.tsFuncionario.AutoSize = false;
            this.tsFuncionario.BackgroundImage = global::Easy_Idiomas.Properties.Resources.logon4;
            this.tsFuncionario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarF,
            this.tsbAlterarF,
            this.tsbExcluirF,
            this.toolStripSeparator1,
            this.tslBuscarPorId,
            this.tstId,
            this.tsbBuscar});
            this.tsFuncionario.Location = new System.Drawing.Point(0, 0);
            this.tsFuncionario.Name = "tsFuncionario";
            this.tsFuncionario.Size = new System.Drawing.Size(684, 31);
            this.tsFuncionario.TabIndex = 31;
            this.tsFuncionario.Text = "toolStrip1";
            // 
            // tsbSalvarF
            // 
            this.tsbSalvarF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarF.Image = global::Easy_Idiomas.Properties.Resources.icone_salvar;
            this.tsbSalvarF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarF.Name = "tsbSalvarF";
            this.tsbSalvarF.Size = new System.Drawing.Size(23, 28);
            this.tsbSalvarF.Text = "Salvar";
            this.tsbSalvarF.Click += new System.EventHandler(this.tsbSalvarF_Click);
            // 
            // tsbAlterarF
            // 
            this.tsbAlterarF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterarF.Image = global::Easy_Idiomas.Properties.Resources._11;
            this.tsbAlterarF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterarF.Name = "tsbAlterarF";
            this.tsbAlterarF.Size = new System.Drawing.Size(23, 28);
            this.tsbAlterarF.Text = "Alterar";
            this.tsbAlterarF.Click += new System.EventHandler(this.tsbAlterarF_Click);
            // 
            // tsbExcluirF
            // 
            this.tsbExcluirF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluirF.Image = global::Easy_Idiomas.Properties.Resources.icone_excluir;
            this.tsbExcluirF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluirF.Name = "tsbExcluirF";
            this.tsbExcluirF.Size = new System.Drawing.Size(23, 28);
            this.tsbExcluirF.Text = "excluir";
            this.tsbExcluirF.Click += new System.EventHandler(this.tsbExcluirF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tslBuscarPorId
            // 
            this.tslBuscarPorId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslBuscarPorId.ForeColor = System.Drawing.SystemColors.Control;
            this.tslBuscarPorId.Name = "tslBuscarPorId";
            this.tslBuscarPorId.Size = new System.Drawing.Size(93, 28);
            this.tslBuscarPorId.Text = "Buscar por Id:";
            // 
            // tstId
            // 
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(100, 31);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = global::Easy_Idiomas.Properties.Resources.icone_pesquisa;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 28);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 555);
            this.Controls.Add(this.tsFuncionario);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.gbBanco);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.gbRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.gbBanco.ResumeLayout(false);
            this.gbBanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.tsFuncionario.ResumeLayout(false);
            this.tsFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lFuncao;
        private System.Windows.Forms.Label lDataPag;
        private System.Windows.Forms.MaskedTextBox mtbSalario;
        private System.Windows.Forms.Label lSalario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lCpf;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.Label lRg;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lSexo;
        private System.Windows.Forms.MaskedTextBox mtbDataNasc;
        private System.Windows.Forms.Label lDataNasc;
        private System.Windows.Forms.GroupBox gbBanco;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lCelular;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lCidade;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label lCep;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lEndereco;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label lUf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lBanco;
        private System.Windows.Forms.ComboBox cbTipoConta;
        private System.Windows.Forms.Label lConta;
        private System.Windows.Forms.MaskedTextBox mtbConta;
        private System.Windows.Forms.Label lNConta;
        private System.Windows.Forms.MaskedTextBox mtbAgencia;
        private System.Windows.Forms.Label lagencia;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.ToolStrip tsFuncionario;
        private System.Windows.Forms.ToolStripButton tsbSalvarF;
        private System.Windows.Forms.ToolStripButton tsbAlterarF;
        private System.Windows.Forms.ToolStripButton tsbExcluirF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslBuscarPorId;
        private System.Windows.Forms.ToolStripTextBox tstId;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.OpenFileDialog ofdFotoF;
        private System.Windows.Forms.ComboBox txtFuncao;
        private System.Windows.Forms.Button bFotoFuncionario;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.ComboBox mtbDataPag;
    }
}