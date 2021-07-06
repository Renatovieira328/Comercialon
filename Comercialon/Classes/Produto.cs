using System.Collections.Generic;

namespace Comercialon.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public string UnidadeVenda { get; set; }
        public string CodBar { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Produto()
        {
        }

        public Produto(string descricao, double valorUnitario, string unidadeVenda, string codBar, double desconto, bool descontinuado, Marca marca, Categoria categoria)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
        }

        public Produto(int id, string descricao, double valorUnitario, string unidadeVenda, string codBar, double desconto, bool descontinuado, Marca marca, Categoria categoria)
        {
            Id = id;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
        }
        public void Inserir()
        {

        }
        public static List<Produto> ObterLista()
        {
            List<Produto> lista = new List<Produto>();

            return lista;
        }
        public void BuscarPorId(int id)
        {

        }
        public void BuscarPorCodbar(string codBar)
        {

        }

        public bool Alterar()
        {

            return true;
        }
    }
}