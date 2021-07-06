using System;
using System.Windows.Forms;

namespace Comercialon.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmCadrastrosCliente_Click(object sender, EventArgs e)
        {
            Form1 frmCliente = new Form1();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void tsmCadrastoProdutosNovo_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void tsmCadrastoUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }
    }
}
