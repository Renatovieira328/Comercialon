using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        internal void inserir()
        { }

        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public void Inserir()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert categoria " +
                "(nome,sigla)" +
                "values('" + Nome + "', '" + Sigla + "''";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public bool Alterar()
        {
            var cmd = Banco.abrir();
            cmd.CommandText = "update categoria set" +
                " nome = '" + Nome + "', sigla = '" + Sigla + "'," +
                " where id = " + Id;
            cmd.ExecuteNonQuery();
        }
        public static List<Categoria> ListarTodos()
        {
            List<Categoria> lista = new List<Categoria>();
            string query = "select * from clientes";
            var cmd = Banco.abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Categoria(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    //Endereco.ListaEnderecos(dr.GetInt32(0))
                    ));
            }
            return lista;
        }
        public void BuscarPorId(int Id)
        {
            string query = "select * from categoria where id = " + Id;
            var cmd = Banco.abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Sigla = dr.GetString(2);
                //Enderecos = Endereco.ListaEnderecos(Id);
            }
        }
    }
}
