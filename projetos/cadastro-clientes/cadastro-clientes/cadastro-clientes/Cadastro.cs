using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //importando mysql connection

namespace cadastro_clientes
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao; //variável de conexao
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consultaForm = new Consulta(); //instância
            consultaForm.Show(); //abre o outro formulário
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            try //tente
            {
                string server = "localhost"; //servidor
                string user = "root"; //usuário. padrão do usbwebserver
                string pass = "usbw"; //senha. padrão do usbwebserver
                string database = "db_produtos"; //nome do banco de dados

                string con = $"Server = {server}; User id = {user}; Password = {pass}; Database = {database}"; //definindo os dados para conectar ao banco de dados

                Conexao = new MySqlConnection(con); //criando a conexão com bd

                //inserindo dados no banco
                string sql = "insert into produtos (nome, peso, descricao, unidade, preco_custo, preco_venda, lucro, valor_min, valor_max, estoque_min, estoque_max)"
                + "values " +
                "(" +
                "'" + txtNome.Text + "', '" + txtPeso.Text + "', '" + txtDescricao.Text + "', '" + txtUnidade.Text + "', '" + txtPrecoCusto.Text + "', + '" + txtPrecoVenda.Text + "', + '" + txtLucro.Text + "', + '" + txtValorMin + "', + '" + txtValorMax.Text + "', + '" + txtEstoqueMin.Text + "', + '" + txtEstoqueMax.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao); //instância que passa a variável de sql, que dá a instrução p/ inserir ao banco

                Conexao.Open(); //abre a conexão com bd
                comando.ExecuteReader(); //executa o comando
                MessageBox.Show("Produto inserido com sucesso!"); //mensagem
            }
            catch (Exception error) //caso der erro...
            {
                MessageBox.Show(error.Message); //mensagem de erro
            }
            finally //e finalmente.. (vale pros dois casos)
            {
                Conexao.Close(); //fecha a conexão
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = ""; //limpando a tela
            txtPeso.Text = "";
            txtDescricao.Text = "";
            txtUnidade.Text = "";
            txtPrecoCusto.Text = "";
            txtPrecoVenda.Text = "";
            txtLucro.Text = "";
            txtValorMin.Text = "";
            txtValorMax.Text = "";
            txtEstoqueMin.Text = "";
            txtEstoqueMax.Text = "";
        }
    }
}
