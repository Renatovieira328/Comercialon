﻿using System;
using System.Collections.Generic;


namespace Comercialon.Classes
{
    public class Cliente
    {
        //declaração de Propriedade
        //private int id;
        
        //public int Id { get => id; set => id = value; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Endereco { get; set; }
        public bool Ativo { get; set; }
        //metodos cronstrutores
        public Cliente() { Id = 0; }

        public Cliente(string nome, string cpf, string email, string telefone, bool ativo = true,List<Endereco> endereco = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }

        internal void Inserir()
        { }

        public Cliente(int id, string nome, string cpf, string email, string telefone, bool ativo = true, List<Endereco> endereco = null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }

        //metodos da classe
        public void Inserie() 
        {   //inserir usando concatenações

            //inserir utilizando expressões mysql

            //inserir utilizando procedures
            var cmd = Banco.abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert clientes " +
                "(nome,cpf,email,telefone,ativo)" +
                "values('"+Nome+"', '"+Cpf+"', '"+Email+"', '"+Telefone+"', default); ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
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
//public Cliente(int id, int nome)
//{
//    Id = id;
//    Nome = nome;
//}

//public Cliente(int nome)
//{
//    Nome = nome;
//}