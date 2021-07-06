using System;
using System.Collections.Generic;
using System.Data;

namespace Comercialon.Classes
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Marca()
        {
        }

        public Marca(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        internal void inserie()
        { }

        public Marca(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public void Inserir_Marca()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "inserir_marca";
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
            cmd.CommandText = "alterar_marca";
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
        public static List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            string query = "select * from marca";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Marca(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
            }
            return lista;
        }
        public void BuscarPorId(int Id)
        {
            string query = "select * from marca where id = " + Id;
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