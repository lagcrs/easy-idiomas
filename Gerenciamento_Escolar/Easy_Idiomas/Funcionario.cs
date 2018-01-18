using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;






namespace Easy_Idiomas
{
    public partial class Funcionario : Form
    {
       
        public Funcionario()
        {
            InitializeComponent();
        }

        // Conectando com o banco de dados
        string conexDb = "SERVER=localhost;DATABASE=easy;UID=root;PWD=";

        MySqlConnection conexao = null;
        MySqlCommand comando;
        
        private void Funcionario_Load(object sender, EventArgs e)
        {
            showDvg();

        }

        //Método para exibir informações do banco no dataGrid
        public void showDvg()
        {
            conexao = new MySqlConnection(conexDb);
            comando = new MySqlCommand("SELECT * FROM funcionarios", connection: conexao);

            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = comando;

            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            dgvFuncionario.DataSource = Dt;
        }

        //Método para abrir conexão
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        //Método para fechar conexão
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        //Método para testar conexão
        public void executar(string banco)
        {
            try
            {
                abrirConexao();
                comando = new MySqlCommand(banco, conexao);
                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Operação Realizada com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possivel completar esta operação, por favor tente novamente!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void dgvFuncionario_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Preenche os campos com as informações contidas na linha selecionada do dataGrid
            tstId.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();

            if (tstId.Text != String.Empty)
            {
                txtNome.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
                txtSenha.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
                mtbSalario.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
                mtbDataPag.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
                txtFuncao.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
                mtbDataNasc.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
                cbSexo.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
                mtbRg.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
                mtbCpf.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
                mtbTelefone.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
                mtbCelular.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
                txtEndereco.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
                mtbNumero.Text = dgvFuncionario.CurrentRow.Cells[13].Value.ToString();
                mtbCep.Text = dgvFuncionario.CurrentRow.Cells[14].Value.ToString();
                txtCidade.Text = dgvFuncionario.CurrentRow.Cells[15].Value.ToString();
                txtBairro.Text = dgvFuncionario.CurrentRow.Cells[16].Value.ToString();
                cbUf.Text = dgvFuncionario.CurrentRow.Cells[17].Value.ToString();
                txtEmail.Text = dgvFuncionario.CurrentRow.Cells[18].Value.ToString();
                pbFuncionario.Load(dgvFuncionario.CurrentRow.Cells[19].Value.ToString());
                txtBanco.Text = dgvFuncionario.CurrentRow.Cells[20].Value.ToString();
                cbTipoConta.Text = dgvFuncionario.CurrentRow.Cells[21].Value.ToString();
                mtbAgencia.Text = dgvFuncionario.CurrentRow.Cells[22].Value.ToString();
                mtbConta.Text = dgvFuncionario.CurrentRow.Cells[23].Value.ToString();
            }
            else
            {
                limpar();
            }
                
        }

        // Método para limpar os campos
        public void limpar()
        {
            tstId.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            mtbSalario.Text = "";
            mtbDataPag.Text = "";
            txtFuncao.Text = "";
            mtbDataNasc.Text = "";
            cbSexo.Text = "";
            mtbRg.Text = "";
            mtbCpf.Text = "";
            mtbTelefone.Text = "";
            mtbCelular.Text = "";
            txtEndereco.Text = "";
            mtbNumero.Text = "";
            mtbCep.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            cbUf.Text = "";
            txtEmail.Text = "";
            pbFuncionario.Image = null;
            txtBanco.Text = "";
            cbTipoConta.Text = "";
            mtbAgencia.Text = "";
            mtbConta.Text = "";

            txtNome.Focus();
        }
        // Método para gravar informação no banco de dados
        private void tsbSalvarF_Click(object sender, EventArgs e)
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO funcionarios (nome, senha, salario, pagamento, funcao, nacimento, sexo, rg, cpf, telefone, celular, endereco, numero, cep, cidade, bairro, uf, email,fotofunc, banco, tipoconta, agencia, conta) VALUES (@NOME, @SENHA, @SALARIO, @PAGAMENTO, @FUNCAO, @NASCIMENTO, @SEXO, @RG, @CPF,@TELEFONE, @CELULAR, @ENDERECO, @NUMERO, @CEP, @CIDADE, @BAIRRO, @UF, @EMAIL,@FOTOFUNC, @BANCO, @TIPOCONTA, @AGENCIA, @CONTA)";
            comando.Parameters.AddWithValue("NOME", txtNome.Text);
            comando.Parameters.AddWithValue("SENHA", txtSenha.Text);
            comando.Parameters.AddWithValue("SALARIO", mtbSalario.Text);
            comando.Parameters.AddWithValue("PAGAMENTO", mtbDataPag.Text);
            comando.Parameters.AddWithValue("FUNCAO", txtFuncao.Text);
            comando.Parameters.AddWithValue("NASCIMENTO", mtbDataNasc.Text);
            comando.Parameters.AddWithValue("SEXO", cbSexo.Text);
            comando.Parameters.AddWithValue("RG", mtbRg.Text);
            comando.Parameters.AddWithValue("CPF", mtbCpf.Text);
            comando.Parameters.AddWithValue("TELEFONE", mtbTelefone.Text);
            comando.Parameters.AddWithValue("CELULAR", mtbCelular.Text);
            comando.Parameters.AddWithValue("ENDERECO", txtEndereco.Text);
            comando.Parameters.AddWithValue("NUMERO", mtbNumero.Text);
            comando.Parameters.AddWithValue("CEP", mtbCep.Text);
            comando.Parameters.AddWithValue("CIDADE", txtCidade.Text);
            comando.Parameters.AddWithValue("BAIRRO", txtBairro.Text);
            comando.Parameters.AddWithValue("UF", cbUf.Text);
            comando.Parameters.AddWithValue("EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("FOTOFUNC", ofdFotoF.FileName);
            comando.Parameters.AddWithValue("BANCO", txtBanco.Text);
            comando.Parameters.AddWithValue("TIPOCONTA", cbTipoConta.Text);
            comando.Parameters.AddWithValue("AGENCIA", mtbAgencia.Text);
            comando.Parameters.AddWithValue("CONTA", mtbConta.Text);

            abrirConexao();
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastro realizado com sucesso!");
            
            showDvg();      
            
        }

        // Método para alterar as informações gravadas no banco de dados
        private void tsbAlterarF_Click(object sender, EventArgs e)
        {
            if (tstId.Text != String.Empty)
            {
                string alterar = "UPDATE funcionarios SET nome='" + txtNome.Text + "',senha='" + txtSenha.Text + "',salario='" + mtbSalario.Text + "', pagamento='" + mtbDataPag.Text + "', funcao='" + txtFuncao.Text + "', nacimento='" + mtbDataNasc.Text + "', sexo='" + cbSexo.Text + "', rg='" + mtbRg.Text + "', cpf='" + mtbCpf.Text + "', telefone='" + mtbTelefone.Text + "', celular='" + mtbCelular.Text + "', endereco='" + txtEndereco.Text + "', numero='" + mtbNumero.Text + "', cep='" + mtbCep.Text + "', cidade='" + txtCidade.Text + "', bairro='" + txtBairro.Text + "', uf='" + cbUf.Text + "', email='" + txtEmail.Text + "',  banco='" + txtBanco.Text + "', tipoconta='" + cbTipoConta.Text + "', agencia='" + mtbAgencia.Text + "', conta='" + mtbConta.Text + "'WHERE id =" + int.Parse(tstId.Text);
                executar(alterar);
                showDvg();

                limpar();
            }
            else
            {
                MessageBox.Show("Só é possível alterar cadastros existentes");
            }
        }

        // Método para excluír as informações gravadas no banco de dados
        private void tsbExcluirF_Click(object sender, EventArgs e)
        {
            if (tstId.Text != String.Empty)
            {
                string excluir = "DELETE FROM funcionarios WHERE id = " + int.Parse(tstId.Text);
                executar(excluir);

                showDvg();

                limpar();
            }
            else
            {
                MessageBox.Show("Só é possível excluir cadastros existentes");
            }

        }

        // Método para buscar as informações gravadas no banco de dados a partir do ID
        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            if (tstId.Text != String.Empty)
            {
                MySqlDataReader pesquisa;
                string selecionar = "SELECT * FROM funcionarios WHERE id = " + int.Parse(tstId.Text);
                comando = new MySqlCommand(selecionar, conexao);
                abrirConexao();
                pesquisa = comando.ExecuteReader();

                if (pesquisa.Read())
                {
                    txtNome.Text = pesquisa.GetString("nome");
                    txtSenha.Text = pesquisa.GetString("senha");
                    mtbSalario.Text = pesquisa.GetString("salario");
                    mtbDataPag.Text = pesquisa.GetString("pagamento");
                    txtFuncao.Text = pesquisa.GetString("funcao");
                    mtbDataNasc.Text = pesquisa.GetString("nacimento");
                    cbSexo.Text = pesquisa.GetString("sexo");
                    mtbRg.Text = pesquisa.GetString("rg");
                    mtbCpf.Text = pesquisa.GetString("cpf");
                    mtbTelefone.Text = pesquisa.GetString("telefone");
                    mtbCelular.Text = pesquisa.GetString("celular");
                    txtEndereco.Text = pesquisa.GetString("endereco");
                    mtbNumero.Text = pesquisa.GetString("numero");
                    mtbCep.Text = pesquisa.GetString("cep");
                    txtCidade.Text = pesquisa.GetString("cidade");
                    txtBairro.Text = pesquisa.GetString("bairro");
                    cbUf.Text = pesquisa.GetString("uf");
                    txtEmail.Text = pesquisa.GetString("email");                    
                    txtBanco.Text = pesquisa.GetString("banco");
                    cbTipoConta.Text = pesquisa.GetString("tipoconta");
                    mtbAgencia.Text = pesquisa.GetString("agencia");
                    mtbConta.Text = pesquisa.GetString("conta");

                }
                else
                {
                    MessageBox.Show("Este ID não existe. Procure novamente.");
                    limpar();
                }

                fecharConexao();

            }
            else
            {
                MessageBox.Show("Só é possível pesquisar cadastros existentes");
            }

        }

        private void bFotoFuncionario_Click(object sender, EventArgs e)
        {
            
                if (ofdFotoF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pbFuncionario.Load(ofdFotoF.FileName);
                }
           
        }
       
    }
}
