using System;
using System.Collections.Generic;
using System.Data;

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

        public Usuario(int id, string nome, string email, string senha, string nivel, string cpf, bool ativo = true)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
            Cpf = cpf;
        }

        public Usuario(string nome, string email, string senha, string nivel, string cpf, bool ativo = true)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
            Cpf = cpf;
        }

        public void Inserir_Usuario()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "inserir_usuarios";
            cmd.Parameters.AddWithValue("_id", 0);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_nivel", Nivel);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.Parameters["_id"].Value);
        }
        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "alterar_usuarios";
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_nivel", Nivel);
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
        public static List<Usuario> ListarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            string query = "select * from clientes";
            var cmd = Banco.Abrir();
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
            string query = "select * from usuarios where id = " + id;
            var cmd = Banco.Abrir();
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