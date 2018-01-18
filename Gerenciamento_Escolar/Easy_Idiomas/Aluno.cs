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
    
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        // Conectando com o banco de dados
        string conexDb = "SERVER=localhost;DATABASE=easy;UID=root;PWD=";

        MySqlConnection conexao = null;
        MySqlCommand comando;
                  
        
        private void Aluno_Load(object sender, EventArgs e)
        {
            showDvg();
        }

        //Método para exibir informações do banco no dataGrid
        public void showDvg()
        {
            try
            {
                conexao = new MySqlConnection(conexDb);
                comando = new MySqlCommand(cmdText: "SELECT * FROM aluno", connection: conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);
                dgvAluno.DataSource = Dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

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

        
        private void dgvAluno_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Preenche os campos com as informações contidas na linha selecionada do dataGrid
            tstIdA.Text = dgvAluno.CurrentRow.Cells[0].Value.ToString();

            if (tstIdA.Text != String.Empty)
            {
                
                txtNomeA.Text = dgvAluno.CurrentRow.Cells[1].Value.ToString();
                txtSenhaA.Text = dgvAluno.CurrentRow.Cells[2].Value.ToString();
                mtbMensalidade.Text = dgvAluno.CurrentRow.Cells[3].Value.ToString();
                mtbDataPagA.Text = dgvAluno.CurrentRow.Cells[4].Value.ToString();
                cbNivelA.Text = dgvAluno.CurrentRow.Cells[5].Value.ToString();
                mtbDataNascA.Text = dgvAluno.CurrentRow.Cells[6].Value.ToString();
                cbSexoA.Text = dgvAluno.CurrentRow.Cells[7].Value.ToString();
                mtbRgA.Text = dgvAluno.CurrentRow.Cells[8].Value.ToString();
                mtbCpfA.Text = dgvAluno.CurrentRow.Cells[9].Value.ToString();
                mtbTelefoneA.Text = dgvAluno.CurrentRow.Cells[10].Value.ToString();
                mtbCelularA.Text = dgvAluno.CurrentRow.Cells[11].Value.ToString();
                txtEnderecoA.Text = dgvAluno.CurrentRow.Cells[12].Value.ToString();
                mtbNumeroA.Text = dgvAluno.CurrentRow.Cells[13].Value.ToString();
                mtbCepA.Text = dgvAluno.CurrentRow.Cells[14].Value.ToString();
                txtCidadeA.Text = dgvAluno.CurrentRow.Cells[15].Value.ToString();
                txtBairroA.Text = dgvAluno.CurrentRow.Cells[16].Value.ToString();
                cbUfA.Text = dgvAluno.CurrentRow.Cells[17].Value.ToString();
                txtEmailA.Text = dgvAluno.CurrentRow.Cells[18].Value.ToString();
                pbAluno.Load(dgvAluno.CurrentRow.Cells[20].Value.ToString());
            }
            else
            {
                limpar();
            }

        }

        // Método para limpar os campos
        public void limpar()
        {
            tstIdA.Text = "";
            txtNomeA.Text = "";
            txtSenhaA.Text = "";
            mtbMensalidade.Text = "";
            mtbDataPagA.Text = "";
            cbNivelA.Text = "";
            mtbDataNascA.Text = "";
            cbSexoA.Text = "";
            mtbRgA.Text = "";
            mtbCpfA.Text = "";
            mtbTelefoneA.Text = "";
            mtbCelularA.Text = "";
            txtEnderecoA.Text = "";
            mtbNumeroA.Text = "";
            mtbCepA.Text = "";
            txtCidadeA.Text = "";
            txtBairroA.Text = "";
            cbUfA.Text = "";
            txtEmailA.Text = "";
            pbAluno.Image = null;

            txtNomeA.Focus();
        }

        // Método para gravar informação no banco de dados
        private void tsbSalvarA_Click(object sender, EventArgs e)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO aluno (nome, senha, mensalidade, vencimento, nivel, nascimento, sexo, rg, cpf, telefone, celular, endereco, numero, cep, cidade, bairro, uf, email,fotoaluno) VALUES (@NOME, @SENHA, @MENSALIDADE, @VENCIMENTO, @NIVEL, @NASCIMENTO, @SEXO, @RG, @CPF,@TELEFONE, @CELULAR, @ENDERECO, @NUMERO, @CEP, @CIDADE, @BAIRRO, @UF, @EMAIL,@FOTOALUNO)";
                comando.Parameters.AddWithValue("NOME", txtNomeA.Text);
                comando.Parameters.AddWithValue("SENHA", txtSenhaA.Text);
                comando.Parameters.AddWithValue("MENSALIDADE", mtbMensalidade.Text);
                comando.Parameters.AddWithValue("VENCIMENTO", mtbDataPagA.Text);
                comando.Parameters.AddWithValue("NIVEL", cbNivelA.Text);
                comando.Parameters.AddWithValue("NASCIMENTO", mtbDataNascA.Text);
                comando.Parameters.AddWithValue("SEXO", cbSexoA.Text);
                comando.Parameters.AddWithValue("RG", mtbRgA.Text);
                comando.Parameters.AddWithValue("CPF", mtbCpfA.Text);
                comando.Parameters.AddWithValue("TELEFONE", mtbTelefoneA.Text);
                comando.Parameters.AddWithValue("CELULAR", mtbCelularA.Text);
                comando.Parameters.AddWithValue("ENDERECO", txtEnderecoA.Text);
                comando.Parameters.AddWithValue("NUMERO", mtbNumeroA.Text);
                comando.Parameters.AddWithValue("CEP", mtbCepA.Text);
                comando.Parameters.AddWithValue("CIDADE", txtCidadeA.Text);
                comando.Parameters.AddWithValue("BAIRRO", txtBairroA.Text);
                comando.Parameters.AddWithValue("UF", cbUfA.Text);
                comando.Parameters.AddWithValue("EMAIL", txtEmailA.Text);
                comando.Parameters.AddWithValue("FOTOALUNO", ofdFotoA.FileName);

                abrirConexao();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");

                showDvg();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        // Método para alterar as informações gravadas no banco de dados
        private void tsbAlterarA_Click(object sender, EventArgs e)
        {
            try
            {
                if (tstIdA.Text != String.Empty)
                {
                    string alterar = "UPDATE aluno SET nome='" + txtNomeA.Text + "',senha='" + txtSenhaA.Text + "',mensalidade='" + mtbMensalidade.Text + "', vencimento='" + mtbDataPagA.Text + "', nivel='" + cbNivelA.Text + "', nascimento='" + mtbDataNascA.Text + "', sexo='" + cbSexoA.Text + "', rg='" + mtbRgA.Text + "', cpf='" + mtbCpfA.Text + "', telefone='" + mtbTelefoneA.Text + "', celular='" + mtbCelularA.Text + "', endereco='" + txtEnderecoA.Text + "', numero='" + mtbNumeroA.Text + "', cep='" + mtbCepA.Text + "', cidade='" + txtCidadeA.Text + "', bairro='" + txtBairroA.Text + "', uf='" + cbUfA.Text + "', email='" + txtEmailA.Text + "' WHERE id =" + int.Parse(tstIdA.Text);
                    executar(alterar);

                    showDvg();
                }
                else
                {
                    MessageBox.Show("Só é possível alterar cadastros existentes");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        // Método para excluír as informações gravadas no banco de dados
        private void tsbExcluirA_Click(object sender, EventArgs e)
        {
            try
            {
                if (tstIdA.Text != String.Empty)
                {
                    string excluir = "DELETE FROM aluno WHERE id = " + int.Parse(tstIdA.Text);
                    executar(excluir);
                    showDvg();

                    limpar();
                }
                else
                {
                    MessageBox.Show("Só é possível excluir cadastros existentes");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        // Método para buscar as informações gravadas no banco de dados a partir do ID
        private void tsbBuscarA_Click(object sender, EventArgs e)
        {
            try
            {
                if (tstIdA.Text != String.Empty)
                {
                    MySqlDataReader pesquisa;
                    string selecionar = "SELECT * FROM aluno WHERE id = " + int.Parse(tstIdA.Text);
                    comando = new MySqlCommand(selecionar, conexao);
                    abrirConexao();
                    pesquisa = comando.ExecuteReader();

                    if (pesquisa.Read())
                    {
                        txtNomeA.Text = pesquisa.GetString("nome");
                        txtSenhaA.Text = pesquisa.GetString("senha");
                        mtbMensalidade.Text = pesquisa.GetString("mensalidade");
                        mtbDataPagA.Text = pesquisa.GetString("vencimento");
                        cbNivelA.Text = pesquisa.GetString("nivel");
                        mtbDataNascA.Text = pesquisa.GetString("nascimento");
                        cbSexoA.Text = pesquisa.GetString("sexo");
                        mtbRgA.Text = pesquisa.GetString("rg");
                        mtbCpfA.Text = pesquisa.GetString("cpf");
                        mtbTelefoneA.Text = pesquisa.GetString("telefone");
                        mtbCelularA.Text = pesquisa.GetString("celular");
                        txtEnderecoA.Text = pesquisa.GetString("endereco");
                        mtbNumeroA.Text = pesquisa.GetString("numero");
                        mtbCepA.Text = pesquisa.GetString("cpf");
                        txtCidadeA.Text = pesquisa.GetString("cidade");
                        txtBairroA.Text = pesquisa.GetString("bairro");
                        cbUfA.Text = pesquisa.GetString("uf");
                        txtEmailA.Text = pesquisa.GetString("email");


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
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        

        private void bFotoAluno_Click(object sender, EventArgs e)
        {
            if (ofdFotoA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbAluno.Load(ofdFotoA.FileName);
            }
        }
    }
}
