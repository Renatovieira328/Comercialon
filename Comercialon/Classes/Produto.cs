using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string Desconto { get; set; }
        public string Descontinuado { get; set; }
        //
        public Produto()
        {
        }

        public Produto(int id, string descricao, string preco, string desconto, string descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(string descricao, string preco, string desconto, string descontinuado)
        {
            Descricao = descricao;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        //
        public double Inserir() 
        {
            return Id;
        }
        public static List<Produto> ListarTodos()
        {
            List<Produto> Lista = new List<Produto>();
            return Lista;
        }
        public bool Alterar()
        {
            return false;
        }
        public void BuscarPorId(int id)
        {

        }
    }
}
