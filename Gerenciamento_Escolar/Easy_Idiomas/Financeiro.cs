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
    public partial class Financeiro : Form
    {
        MySqlConnection conexao = new MySqlConnection ("SERVER=localhost;DATABASE=easy;UID=root;PWD=");
        MySqlCommand comando;

        public Financeiro()
        {
            InitializeComponent();           
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            
        }

        public void showDvgP()
        {
            comando = new MySqlCommand("SELECT * FROM pagar", conexao);

            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = comando;

            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            dgvFinanceiro.DataSource = Dt;
        }

        private void rbPagar_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
            mtbValor.Enabled = true;
            mtbDataPagFi.Enabled = true;
            showDvgP();
            limpar();

        }

        public void showDvgR()
        {
            comando = new MySqlCommand("SELECT * FROM receber", conexao);

            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = comando;

            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            dgvFinanceiro.DataSource = Dt;
        }
        private void rbReceber_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
            mtbValor.Enabled = true;
            mtbDataPagFi.Enabled = true;
            showDvgR();
            limpar();
        }

        private void dgvFinanceiro_MouseClick(object sender, MouseEventArgs e)
        {
            tstIdfi.Text = dgvFinanceiro.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = dgvFinanceiro.CurrentRow.Cells[1].Value.ToString();
            mtbValor.Text = dgvFinanceiro.CurrentRow.Cells[2].Value.ToString();
            mtbDataPagFi.Text = dgvFinanceiro.CurrentRow.Cells[3].Value.ToString();
        }

        public void limpar()
        {
            tstIdfi.Text ="";
            txtTipo.Text = "";
            mtbValor.Text = "";
            mtbDataPagFi.Text = "";

            txtTipo.Focus();
        }

        public void abrirConexao()
        {
            if(conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public void executar(string banco)
        {
            try
            {
                abrirConexao();
                comando = new MySqlCommand(banco, conexao);
                if(comando.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Operação Realizada com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possivel completar esta operação, por favor tente novamente!");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tsbSalvarFi_Click(object sender, EventArgs e)
        {
            if(rbPagar.Checked)
            {
                string salvar = "INSERT INTO pagar(tipo, valor, vencimento) VALUES ('" + txtTipo.Text + "','" + mtbValor.Text + "','" + mtbDataPagFi.Text + "')";
                executar(salvar);
                showDvgP();
            }
            if(rbReceber.Checked)
            {
                string salvar = "INSERT INTO receber(tipo, valor, vencimento) VALUES ('" + txtTipo.Text + "','" + mtbValor.Text + "','" + mtbDataPagFi.Text + "')";
                executar(salvar);
                showDvgR();
            }
           
        }

        private void tsbAlterarFi_Click(object sender, EventArgs e)
        {
            if (tstIdfi.Text != String.Empty)
            {
                if (rbPagar.Checked)
                {
                    string alterar = "UPDATE pagar SET tipo='" + txtTipo.Text + "', valor='" + mtbValor.Text + "', vencimento='" + mtbDataPagFi.Text + "' WHERE id =" + int.Parse(tstIdfi.Text);
                    executar(alterar);
                    showDvgP();
                }
                if (rbReceber.Checked)
                {
                    string alterar = "UPDATE receber SET tipo='" + txtTipo.Text + "', valor='" + mtbValor.Text + "', vencimento='" + mtbDataPagFi.Text + "' WHERE id =" + int.Parse(tstIdfi.Text);
                    executar(alterar);
                    showDvgR();

                }
            }
            else
            {
                MessageBox.Show("Só é possível alterar cadastros existentes");
            }

            
        }

        private void tsbExcluirFi_Click(object sender, EventArgs e)
        {
            if (tstIdfi.Text != String.Empty)
            {
                if (rbPagar.Checked)
                {
                    string excluir = "DELETE FROM pagar WHERE id = " + int.Parse(tstIdfi.Text);
                    executar(excluir);
                    showDvgP();

                    limpar();
                }
                if (rbReceber.Checked)
                {
                    string excluir = "DELETE FROM receber WHERE id = " + int.Parse(tstIdfi.Text);
                    executar(excluir);
                    showDvgR();

                    limpar();
                }
            }
            else
            {
                MessageBox.Show("Só é possível excluir cadastros existentes");
            }
                
        }

        private void tsbBuscarfi_Click(object sender, EventArgs e)
        {
            if (tstIdfi.Text != String.Empty)
            {
                if (rbPagar.Checked)
                {
                    MySqlDataReader pesquisa;
                    string selecionar = "SELECT * FROM pagar WHERE id = " + int.Parse(tstIdfi.Text);
                    comando = new MySqlCommand(selecionar, conexao);
                    abrirConexao();
                    pesquisa = comando.ExecuteReader();

                    if (pesquisa.Read())
                    {
                        txtTipo.Text = pesquisa.GetString("tipo");
                        mtbValor.Text = pesquisa.GetString("valor");
                        mtbDataPagFi.Text = pesquisa.GetString("vencimento");
                    }
                    else
                    {
                        MessageBox.Show("Miga, esta turma não existe. Procure novamente!");
                        limpar();
                    }

                    fecharConexao();

                }
                if (rbReceber.Checked)
                {
                    MySqlDataReader pesquisa;
                    string selecionar = "SELECT * FROM receber WHERE id = " + int.Parse(tstIdfi.Text);
                    comando = new MySqlCommand(selecionar, conexao);
                    abrirConexao();
                    pesquisa = comando.ExecuteReader();

                    if (pesquisa.Read())
                    {
                        txtTipo.Text = pesquisa.GetString("tipo");
                        mtbValor.Text = pesquisa.GetString("valor");
                        mtbDataPagFi.Text = pesquisa.GetString("vencimento");
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe. Procure novamente.");
                        limpar();
                    }

                    fecharConexao();

                }

            }
            else
            {
                MessageBox.Show("Só é possível pesquisar cadastros existentes");
            }
        }
    }
}
