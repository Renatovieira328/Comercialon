using System.Collections.Generic;

namespace Comercialon.Classes
{
    public class ItemPedido
    {
        private readonly int idPedido;
        public int IdPedido { get { return idPedido; } }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorProduto { get; set; }
        public double Desconto { get; set; }
        public ItemPedido()
        {
        }
        public ItemPedido(int idPedido, Produto produto, double quantidade, double valorProduto, double desconto)
        {
            this.idPedido = idPedido;
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
            Desconto = desconto;
        }
        public static List<ItemPedido> ObterItemsPedido()
        {
            List<ItemPedido> lista = new List<ItemPedido>();

            return lista;
        }
        public void Inserir()
        {

        }
    }
}