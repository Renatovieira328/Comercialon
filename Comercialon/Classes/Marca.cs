using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Marca
    {
        private readonly int idMarca;
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

        public Marca(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public void inserir()
        {
            string query = "insert marca values(" +
               Nome + "," +
               "," + Sigla + "')";
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }



    }
}