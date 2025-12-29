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

namespace cadastro_clientes
{
    public partial class Consulta : Form
    {
        private MySqlConnection Conexao;

        private string data_source = "datasource = localhost;username = root; password=usbw; database=db_produtos";
        public Consulta()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Peso", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Descrição", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Unidade", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Preço custo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Preço venda", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Lucro", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Mín.", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Valor Máx.", 85, HorizontalAlignment.Left);
            listView1.Columns.Add("Estoque Mín.", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Esroque Máx.", 105, HorizontalAlignment.Left);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string buscar = "%" + txtNome.Text + "%";

                Conexao = new MySqlConnection(data_source);

                string sql = "select * from produtos where nome like @buscar";

                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                comando.Parameters.AddWithValue("@buscar", buscar);
                MySqlDataReader reader = comando.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetInt64(0).ToString(),
                        reader.GetString(1),
                        reader.GetDecimal(2).ToString(),
                        reader.GetString(3),
                        reader.GetInt64(4).ToString(),
                        reader.GetDecimal(5).ToString("F2"),
                        reader.GetDecimal(6).ToString("F2"),
                        reader.GetDecimal(7).ToString(),
                        reader.GetDecimal(8).ToString("F2"),
                        reader.GetDecimal(9).ToString("F2"),
                        reader.GetInt64(10).ToString(),
                        reader.GetInt64(11).ToString(),
                    };

                    var linha_ListView = new ListViewItem(linha);
                    listView1.Items.Add(linha_ListView);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cadastroForm = new Form1();
            cadastroForm.Show();
        }
    }
}
