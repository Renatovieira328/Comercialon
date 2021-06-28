using System;
using System.Windows.Forms;
using Comercialon.Classes;

namespace Comercialon.Formularios
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(
                txtCatName.Text,
                txtCatSigla.Text
                );
            categoria.inserir();

            MessageBox.Show("Categoria " + categoria.Nome + " adicionada!");
        }
        private void LimpaCampos()
        {
            txtCatName.Clear();
            txtCatSigla.Clear();
        }

        private void BTAlterar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            //categoria.Id = int.Parse(txtId.Text);
            categoria.Nome = txtCatName.Text;
            categoria.Sigla = txtCatSigla.Text;

            if (categoria.Alterar())
            {
                MessageBox.Show("Categoria alterado com sucesso");
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Falha ao alterar o cliente!");
            }
        }
    }
}
