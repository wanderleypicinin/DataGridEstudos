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

namespace DataGridEstudos
{
    public partial class FormPrincipal : Form
    {
        //string de conexão
        private string connectionString = "Server=localhost;Port=3306;Database=ExemploDataGridView;Uid=root;Pwd=Info@2025";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var form = new FormAdicionarCliente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO Clientes (Nome, Email, Telefone, DataCadastro)" + " VALUES (@nome, @email, @telefone, @DataCadastro)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@nome", form.Nome);
                            command.Parameters.AddWithValue("@email", form.Email);
                            command.Parameters.AddWithValue("@telefone", form.Telefone);
                            command.Parameters.AddWithValue("@dataCadastro", form.DataCadastro);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Clientes";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    //Configuraçãoes opicionais do DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["id"].Visible = false; // Oculta a coluna ID
                    dataGridView1.Columns["DataCadastro"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
