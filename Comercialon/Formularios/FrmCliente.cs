using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Comercialon.Classes;

namespace Comercialon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {   //remove pontos do bloco
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cliente cliente = new Cliente(
                txtNome.Text,
                mskCpf.Text,
                txtEmail.Text,
                txtTelefone.Text
            );
            cliente.Inserir();
            Endereco endereco = new Endereco
                (txtLogradouro.Text, txtNumero.Text, txtComplemento.Text
                , mskCEP.Text, txtBairro.Text, txtCidade.Text, CBTipo.Text,
                txtEstado.Text, txtUF.Text);
            endereco.inserir(cliente.Id);
            txtID.Text = cliente.Id.ToString();
            MessageBox.Show("Cliente " + cliente.Id + " inserido.");
            LimpaCampos();
        }
        private void LimpaCampos()
        {

            txtID.Clear();
            txtNome.Clear();
            mskCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            if (rg.IsMatch(email))
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text=="...")
            {
            txtID.ReadOnly = false;
            txtID.Focus();
            BloquearControles();
            button2.Text = "buscar";
            }
            else
            {
                txtID.ReadOnly = true;
                txtID.Focus();
                BloquearControles();
                button2.Text = "buscar";
                Cliente cliente = new Cliente();
                cliente.BuscarPorId(int.Parse(txtID.Text));
                if (cliente.Id>0)
                {
                    txtNome.Text = cliente.Nome;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    mskCpf.Text = cliente.Cpf;
                    mskCpf.Enabled = false;
                    chkAtivo.Checked = cliente.Ativo;
                    chkAtivo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cliente não cadratasdo");
                }
            }
        }
        private void DesbloquearControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            mskCpf.Enabled = true;
        }
        private void BloquearControles() 
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            mskCpf.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            if(cliente.Alterar())
            {
                MessageBox.Show("Cliente alterado com sucesso");
                LimpaCampos();
                btnAlterar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o cliente!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            var lista = Cliente.ListarTodos();
            foreach (var item in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[2].Value = item.Cpf;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[3].Value = item.Email;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[4].Value = item.Telefone;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[5].Value = item.Ativo;

            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEndereco.Rows.Clear();
            int idCli = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            var listaEnd = Endereco.ListaEnderecos(idCli);
            if (listaEnd.Count>0)
            {
                foreach (var item in listaEnd)
                {
                    dgvEndereco.Rows.Add();
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[0].Value = item.Tipo;
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[1].Value = item.Cep;
                    StringBuilder endereco = new StringBuilder();
                    endereco.Append(", " + item.Numero);
                    endereco.Append(" - " + item.Bairro);
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[2].Value = endereco;

                }
            }
            else
            {
                dgvEndereco.Rows.Add();
                string mensagem = "Não há endereços cadastrados";
                dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[2].Value = mensagem;
            }
           
        }
    }
}