using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //precisa ser importado para a conexão com o banco de dados mysql


namespace projetoAgenda
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao; //declara uma variável tipo mysql para conexão com o banco de dados

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //tente...
            {
                string server = "localhost"; //servidor
                string user = "root"; //usuário. padrão do usbwebserver
                string password = "usbw"; //senha. padrão do usbwebserver
                string database = "db_cadastroagenda"; //nome dado ao banco de dados

                string strConnect = $"Server = {server}; User id = {user}; Password = {password}; Database = {database}"; //definindo que o servidor será o servidor dado anteriormente e assim por diante

                Conexao = new MySqlConnection(strConnect); //criando a conexão com o banco de dados mysql e strConnect será o conjunto de dados essenciais (server, usuário, etc) dado a cima


                //cria uma variável sql que insere os dados registrados pelo usuário no banco de dados (primeiro com os nomes dados no banco e depois com os nomes da caixa de texto que damos)
                string sql = "insert into cadastrocontato (nomeCompleto, telefone, celular, telefoneFax, endereco, bairro, cidade, cep, uf, cpf, rg, dataNasc, email)"
                + "values " +
                "(" + 
                "'" + txtNome.Text + "' , '" + txtTelefoneFax.Text + "' ,'" + txtCelular.Text + "' , '" + txtTelefone.Text + "' , '" + txtEndereco.Text + "' , '" + txtBairro.Text + "' , '" + txtCidade.Text + "' , '" + txtCep.Text + "' , '" + txtUF.Text + "' , '" + txtCPF.Text + "' , '" + txtRG.Text + "' , '" + txtNascimento.Text + "' , '" + txtEmail.Text + "'  )";
            
                MySqlCommand comando = new MySqlCommand(sql, Conexao); //cria uma variável tipo comando de mysql e em seguida uma nova instância passando sql, que tem a instrução para inserir dados, e conexao, onde já foi inicializada e tem o banco
                Conexao.Open(); //abre a conexão com o banco de dados
                comando.ExecuteReader();  //executa o comando
                MessageBox.Show("Dados inseridos com sucesso !"); //mostra uma mensagem dizendo que os dados foram inseridos corretamente
            } 

            catch (Exception error) //caso dê errado, abre uma exceção nomeada "error"
            {
                MessageBox.Show(error.Message); //mostra uma mensagem de erro com o erro que ocorreu
            }

            finally //e finalmente...
            {
                Conexao.Close(); //feche a conexão com o banco de dados
            }

            //limpando as caixas de texto
            txtNome.Text = ""; //declarando que a caixa de texto nome será igual a "", ou seja, nada. para que esteja vazia para ser utilizada de novo
            txtTelefoneFax.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
            txtUF.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtNascimento.Text = "";
            txtEmail.Text = "";
        } 

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
