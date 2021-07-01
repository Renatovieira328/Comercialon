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
        public string Cpf { get; set; }        
        public bool Ativo { get; set; }


        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email, string senha, string nivel,string cpf, bool ativo = true )
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
            Cpf = cpf;
        }
        internal void Inserir()
        { }

        public Usuario(string nome, string email, string senha, string nivel, string cpf, bool ativo = true)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
            Cpf = cpf;
        }

        public double Cadrastrar() 
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert usuarios " +
                "(nome,email,senha,nivel,ativo,cpf)" +
                "values('" + Nome + "', '" + Email + "', '" + Senha + "', '" + Nivel + "'" + Ativo + "','" + Cpf + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            cmd.ExecuteScalar();
        }
        public static List<Usuario> ListarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            return lista;
        }
        public bool Alterar() 
        {
            var cmd = Banco.abrir();
            cmd.CommandText = "update usuario set" +
                " nome = '" + Nome + "', email = '" + Email + "'," +
                " senha = '" + Senha + "'," +
                " nivel ='" + Nivel + "'" +
                " ativo ='" + Ativo + "'" +
                " cpf='" + Cpf + "'" +
                " where id = " + Id;
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string query = "select * from usuarios";
            var cmd = Banco.abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetBoolean(6)
                    ));
            }
            return lista;
        }
        public void BuscarPorId(int id)
        {
            string query = "select * from usuarios where id" + Id;
            var cmd = Banco.abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Senha = dr.GetString(3);
                Nivel = dr.GetString(4);
                Cpf = dr.GetString(5);
                Ativo = dr.GetBoolean(6);
            }
        }

    }
}
