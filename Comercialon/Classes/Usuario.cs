using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string Situacao { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email, string senha, string nivel, string situacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
        }

        public Usuario(string nome, string email, string senha, string nivel, string situacao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
        }

        public double Inserir() 
        {
            return Id;
        }
        public static List<Usuario> ListarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            return lista;
        }
        public bool Alterar() 
        {
            return true;
        }
        public void BuscarPorId(int id)
        {

        }

    }
}
