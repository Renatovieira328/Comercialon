using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Comercialon.Classes
{   
    /// <summary>
    /// abre uma conexão para um banco de dados MySql
    /// </summary>
    public static class Banco
    {
        public static MySqlCommand abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strConnection = @"server=127.0.0.1;database=comercialondb;user id=root;password=usbw";
            MySqlConnection cn = new MySqlConnection(strConnection);
            try //tratamento de exceção C#
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                    cmd.Connection = cn;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cmd;
        }
    }
}
