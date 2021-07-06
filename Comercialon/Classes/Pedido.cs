using System.Collections.Generic;

namespace Comercialon.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Data { get; set; }
        public string Situacao { get; set; }
        public double Desconto { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItemsPedido { get; set; }
        public Pedido()
        {
        }

        public Pedido(int data, string situacao, double desconto, Usuario usuario, Cliente cliente, List<ItemPedido> itemsPedido = null)
        {
            Data = data;
            Situacao = situacao;
            Desconto = desconto;
            Usuario = usuario;
            Cliente = cliente;
            ItemsPedido = itemsPedido;
        }
    }
}