using System;
using System.Collections.Generic;


namespace Comercialon.Classes
{
    public class Cliente
    {
        //declaração de atributo
        //private int id;

        //public int Id { get => id; set => id = value; }
        public int Id { get; set; }
        public int Nome { get; set; }
        //metodos cronstrutores
        public Cliente()
        {
        }

        public Cliente(int id, int nome)
        {
            Id = id;
            Nome = nome;
        }

        public Cliente(int nome)
        {
            Nome = nome;
        }
        //metodos da classe
        public void Inserie() 
        { }
        public bool Alterar(int id)
        {
            return true;
        }
        public static List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            return lista;
        }
        public void BuscarPorId(int Id)
        {

        }
    }
}
