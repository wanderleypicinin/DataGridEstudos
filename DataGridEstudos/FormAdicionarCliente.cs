using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridEstudos
{
    public partial class FormAdicionarCliente : Form
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public FormAdicionarCliente()
        {
            InitializeComponent();
            dtpDataCadastro.Value = DateTime.Today; // Define a data atual como padrão
        }

        private void FormAdicionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Nome = txtNome.Text;
            Email = txtEmail.Text;
            Telefone = txtTelefone.Text;
            DataCadastro = dtpDataCadastro.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)


        { 
               DialogResult = DialogResult.Cancel;
                Close(); // Define o resultado do diálogo como OK
            
        }
    }  
}
