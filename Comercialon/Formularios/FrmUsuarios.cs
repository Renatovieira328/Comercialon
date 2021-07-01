using System;
using System.Windows.Forms;
using Comercialon.Classes;

namespace Comercialon.Formularios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Usuario usuario = new Usuario(
                TXBNome.Text,
                TXBEmail.Text,
                TXBSenha.Text,
                CbNivel.Text,
                MskCPF.Text
            );
            usuario.Inserir();
            TxBID.Text = Usuario.Id.ToString();
            MessageBox.Show("Usuario " + Usuario.Id + " inserido.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = int.Parse(TxBID.Text);
            usuario.Nome = TXBNome.Text;
            usuario.Email = TXBEmail.Text;
            usuario.Senha = TXBSenha.Text;
            usuario.Nivel = CbNivel.Text;
            usuario.Cpf = MskCPF.Text;
            if (usuario.Alterar())
            {
                MessageBox.Show("Usuario alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao alterar o usuario!");
            }
        }
    }
}
