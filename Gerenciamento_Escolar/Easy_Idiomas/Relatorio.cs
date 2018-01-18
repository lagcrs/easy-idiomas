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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

      
        // Conectando com o banco de dados
        string conexDb = "SERVER=localhost;DATABASE=easy;UID=root;PWD=";

        MySqlConnection conexao = null;
        MySqlCommand comando;

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

        private void Relatorio_Load(object sender, EventArgs e)
        {
            Pagar();
            Receber();
        }

        
        private void ckb3d_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb3dp.Checked)
            {
                cPagar.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                cPagar.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb3dr.Checked)
            {
                cReceber.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                cReceber.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        public void Pagar()
        {
            try
            {
                cPagar.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;

                conexao = new MySqlConnection(conexDb);
                MySqlDataReader apagar;
                string pegar = "SELECT * FROM pagar";
                comando = new MySqlCommand(pegar, conexao);
                abrirConexao();
                apagar = comando.ExecuteReader();

                while (apagar.Read())
                {
                    cPagar.Series[2].Points.AddXY(apagar.GetString("tipo"), apagar.GetString("valor"));
                }

                fecharConexao();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public void Receber()
        {
            try
            {
                cReceber.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;

                conexao = new MySqlConnection(conexDb);
                MySqlDataReader areceber;
                string selecionar = "SELECT * FROM receber";
                comando = new MySqlCommand(selecionar, conexao);
                abrirConexao();
                areceber = comando.ExecuteReader();

                while (areceber.Read())
                {
                    cReceber.Series[0].Points.AddXY(areceber.GetString("tipo"), areceber.GetString("valor"));
                }

                fecharConexao();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void cBalanco_Click(object sender, EventArgs e)
        {
            

        }

        private void cReceber_Click(object sender, EventArgs e)
        {
            
        }
    }
}
