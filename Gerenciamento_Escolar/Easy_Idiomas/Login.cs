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
    public partial class fLogin : Form
    {
        bool result = false;
        public fLogin()
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

        public bool validaLogin()
        {
            
            try
            {
                conexao = new MySqlConnection(conexDb);
                MySqlDataReader pesquisa;
                string selecionar = "SELECT * FROM funcionarios WHERE rg='"+txt_L_Id.Text+"'AND senha='"+txt_L_Senha.Text+"'AND funcao='Administrativo'";
                comando = new MySqlCommand(selecionar, conexao);
                abrirConexao();
                pesquisa = comando.ExecuteReader();
                result = pesquisa.HasRows;                
            }
            catch(MySqlException e)
            {
                throw new Exception(e.Message);
            }  
            finally
            {
                fecharConexao();
            }
            return(result);
                        
        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            
                validaLogin();
                if (result == true)
                {
                    Gerenciamento g = new Gerenciamento(this);
                    txt_L_Id.Clear();
                    txt_L_Senha.Clear();
                    this.Hide();
                    g.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválida!!!");
                }
           
           
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            
        }
        
    }
    
}
