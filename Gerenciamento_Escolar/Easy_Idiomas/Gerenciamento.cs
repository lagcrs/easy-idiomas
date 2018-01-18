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
    public partial class Gerenciamento : Form
    {
        public fLogin principal;
        
        public Gerenciamento(fLogin form)
        {
            principal = form;
            InitializeComponent();
        }
        
        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            
        }       
                
        private void bAluno_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.ShowDialog();                
        }

        private void bFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.ShowDialog();
            
        }

        private void bFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro c = new Financeiro();
            c.ShowDialog();                
        }

        private void bTurma_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            t.ShowDialog();
        }

        private void bRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio r = new Relatorio();
            r.ShowDialog();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();      

        }

        private void tslNome_Click(object sender, EventArgs e)
        {
            
        }

        private void Gerenciamento_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
    
}
