using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Comercialon.Classes
{
    public class Endereco
    {
        private readonly int idCliente;
        public int IdCliente { get { return idCliente; } }
        public string Logradouro { get; set; }
        public string Numero { set; get; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Tipo { get; set; }
        public Endereco()
        {
        }

        public Endereco(int idCliente, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string uf, string tipo)
        {
            this.idCliente = idCliente;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo = tipo;
        }

        public Endereco(string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string tipo, string uf = null)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Tipo = tipo;
            Uf = uf;
        }
        public void Inserir(int idCliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "inserir_enderecos";
            cmd.Parameters.AddWithValue("_cep", Cep);
            cmd.Parameters.AddWithValue("_logradouro", Logradouro);
            cmd.Parameters.AddWithValue("_numero", Numero);
            cmd.Parameters.AddWithValue("_complemento", Complemento);
            cmd.Parameters.AddWithValue("_bairro", Bairro);
            cmd.Parameters.AddWithValue("_cidade", Cidade);
            cmd.Parameters.AddWithValue("_uf", Uf);
            cmd.Parameters.AddWithValue("_tipo", Tipo);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id do cliente na tabela endereço. Use 0 se quiser listar todos com limite de resultados</param>
        /// <param name="incial">Valor incial da base de consulta. Zero é o valor padrão</param>
        /// <param name="limit">Número de registros por consulta.</param>
        /// <returns></returns>
        public static List<Endereco> ListaEnderecos(int id = 0, int inicial = 0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>();
            string query = "";
            if (id > 0)
            {
                query = "select * from enderecos where Clientes_id = " + id;
            }
            else if (limit >= 0 && inicial >= 0)
            {
                query = "select * from enderecos limit " + inicial + "," + limit;
            }
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(1),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    ));
            }
            return lista;
        }
    }
}