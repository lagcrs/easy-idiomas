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

namespace Easy_Idiomas
{
    public partial class Turma : Form
    {
        public Turma()
        {
            InitializeComponent();

        }
        // Conexão com o Banco de dados Mysql
        string conexDb = "SERVER=localhost;DATABASE=easy;UID=root;PWD=";

        MySqlConnection conexao = null;
        MySqlCommand comando;

        
        private void Turma_Load(object sender, EventArgs e)
        {
            showDvg();
        }

        public void showDvg()
        {
            conexao = new MySqlConnection(conexDb);
            comando = new MySqlCommand("SELECT * FROM turma", conexao);

            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = comando;

            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            dgvTurma.DataSource = Dt;
        }

        private void dgvTurma_MouseClick(object sender, MouseEventArgs e)
        {
            tstIdT.Text = dgvTurma.CurrentRow.Cells[0].Value.ToString();
            txtNomeT.Text = dgvTurma.CurrentRow.Cells[1].Value.ToString();
            mtbInicio.Text = dgvTurma.CurrentRow.Cells[2].Value.ToString();
            mtbFim.Text = dgvTurma.CurrentRow.Cells[3].Value.ToString();
            txtProfessor.Text = dgvTurma.CurrentRow.Cells[4].Value.ToString();
            cbNivel.Text = dgvTurma.CurrentRow.Cells[5].Value.ToString();

            tsbAlterarT.Enabled = true;
            tsbSalvarT.Enabled = true;
            tsbExcluirT.Enabled = true;
        }

        public void limpar()
        {
            tstIdT.Text = "";
            txtNomeT.Text = "";
            mtbInicio.Text = "";
            mtbFim.Text = "";
            txtProfessor.Text = "";
            cbNivel.Text = "";

            txtNomeT.Focus();
        }

        // Método para abrir conexão
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        // Método para fechar conexão
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        // Método para testar conexão
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

        //Botão para inserir dados informados pelo usuario no banco de dados
        private void tsbSalvarT_Click(object sender, EventArgs e)
        {
            string salvar = "INSERT INTO turma(nome, inicio, fim, professor, nivel) VALUES ('" + txtNomeT.Text + "','" + mtbInicio.Text + "','" + mtbFim.Text + "','" + txtProfessor.Text + "','" + cbNivel.Text + "')";
            executar(salvar);
            showDvg();
        }

        //Botão para alterar os dados salvos no banco
        private void tsbAlterarT_Click(object sender, EventArgs e)
        {
            if(tstIdT.Text!=String.Empty)
            {
                string alterar = "UPDATE turma SET nome='" + txtNomeT.Text + "', inicio='" + mtbInicio.Text + "', fim='" + mtbFim.Text + "', professor='" + txtProfessor.Text + "', nivel='" + cbNivel.Text + "'WHERE id =" + int.Parse(tstIdT.Text);
                executar(alterar);
                showDvg();
            }
            else
            {
                MessageBox.Show("Só é possível alterar cadastros existentes");
            }
            
        }

        //Botão para excluir dados salvos no banco
        private void tsbExcluirT_Click(object sender, EventArgs e)
        {
            
            if (tstIdT.Text != String.Empty)
            {
                string excluir = "DELETE FROM turma WHERE id = " + int.Parse(tstIdT.Text);
                executar(excluir);
                showDvg();

                limpar();
            }
            else
            {
                MessageBox.Show("Só é possível excluís cadastros existentes");
            }
        }
        
        //Botão para buscar dados salvos no banco e preencher os campos do formulario, a partir de id já salvo
        private void tsbBuscarT_Click(object sender, EventArgs e)
        {
            if (tstIdT.Text != String.Empty)
            {
                MySqlDataReader pesquisa;
                string selecionar = "SELECT * FROM turma WHERE id = " + int.Parse(tstIdT.Text);
                comando = new MySqlCommand(selecionar, conexao);
                abrirConexao();
                pesquisa = comando.ExecuteReader();

                if (pesquisa.Read())
                {
                    txtNomeT.Text = pesquisa.GetString("nome");
                    mtbInicio.Text = pesquisa.GetString("inicio");
                    mtbFim.Text = pesquisa.GetString("fim");
                    txtProfessor.Text = pesquisa.GetString("professor");
                    cbNivel.Text = pesquisa.GetString("nivel");

                    tsbAlterarT.Enabled = true;
                    tsbSalvarT.Enabled = true;
                    tsbExcluirT.Enabled = true;
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
    }
}
