using Comercialon.Classes;
using System;
using System.Windows.Forms;

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
                TxtNome.Text,
                TxtEmail.Text,
                TxtSenha.Text,
                CbNivel.Text,
                MskCPF.Text
            );
            usuario.Inserir_Usuario();
            TxtID.Text = usuario.Id.ToString();
            MessageBox.Show("Usuario " + usuario.Id + " inserido.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = int.Parse(TxtID.Text);
            usuario.Nome = TxtNome.Text;
            usuario.Email = TxtEmail.Text;
            usuario.Senha = TxtSenha.Text;
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
