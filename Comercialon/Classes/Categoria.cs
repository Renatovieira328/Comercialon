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
        internal void inserie()
        { }

        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public void Inserie()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert categoria " +
                "(nome,sigla)" +
                "values('" + Id + "','" + Nome + "', '" + Sigla + "''";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

      
            
   }
}
