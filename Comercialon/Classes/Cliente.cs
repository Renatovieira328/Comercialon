using System;
using System.Collections.Generic;
using System.Data;


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
        public List<Endereco> Enderecos { get; set; }
        public bool Ativo { get; set; }
        //metodos cronstrutores
        public Cliente() { Id = 0; }

        //cronstutores
        public Cliente(string nome, string cpf, string email, string telefone, bool ativo = true,List<Endereco> endereco = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Enderecos = endereco;
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
            Enderecos = endereco;
            Ativo = ativo;
        }

        //metodos da classe
        public void Inserie() 
        {   //inserir usando concatenações

            //inserir utilizando expressões mysql

            //inserir utilizando procedures
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "inserir_clientes";
            cmd.Parameters.AddWithValue("_id", 0).Direction = ParameterDirection.Output;
            cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_cpf", Cpf).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_email", Email).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            Id = Convert.ToInt32(cmd.Parameters["_id"].Value);
        }
        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "alterar_clientes";
            cmd.Parameters.AddWithValue("_id", Id).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_nome", Nome).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_email", Email).Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_telefone", Telefone).Direction = ParameterDirection.Input;
            int ret =  cmd.ExecuteNonQuery();
            if (ret==1)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            string query = "select * from clientes";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetBoolean(5),
                    Endereco.ListaEnderecos(dr.GetInt32(0))
                    ));
            }
            return lista;
        }
        public void BuscarPorId(int id)
        {
            string query = "select * from clientes where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                Telefone = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
                Enderecos = Endereco.ListaEnderecos(id);
            }
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