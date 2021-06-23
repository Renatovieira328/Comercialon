using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Categoria
    {
        private readonly int idCategoria;
        public int IdCategoria { get; set; }
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

        public Categoria(int idcatedoria, string nome, string sigla)
        {
            this.IdCategoria = idCategoria;
            Nome = nome;
            Sigla = sigla;
        }
        public void inserir() 
        {
            string query = "insert categoria values(" +
                idCategoria + "'," +
                "'" + Nome +"',"+
                "'"+Sigla + "')";
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

      
            
   }
}
