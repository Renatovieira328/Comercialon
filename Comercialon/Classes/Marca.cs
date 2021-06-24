using System;

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
        public void Inserie()
        {
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert marca " +
                "(nome,sigla)" +
                "values('" + Id + "','" + Nome + "', '"+ Sigla + "''";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}