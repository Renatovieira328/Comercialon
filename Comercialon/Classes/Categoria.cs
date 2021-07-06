using System;
using System.Collections.Generic;
using System.Data;

namespace Comercialon.Classes
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Categoria()
        {
        }

        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        internal void Inserir()
        { }

        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public void Inserir_categoria()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "inserir_clientes";
            cmd.Parameters.AddWithValue("_id", 0);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.Parameters["_id"].Value);
        }
        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "alterar_clientes";
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);
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
        public static List<Categoria> ListarTodos()
        {
            List<Categoria> lista = new List<Categoria>();
            string query = "select * from categorias";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Categoria(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
            }
            return lista;
        }
        public void BuscarPorId(int Id)
        {
            string query = "select * from categorias where id = " + Id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Sigla = dr.GetString(2);
            }
        }
    }
}
