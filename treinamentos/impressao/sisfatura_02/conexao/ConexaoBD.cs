using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace sisfatura_02.conexao
{
    public static class ConexaoBD
    {
        private static string strConexao = "Server=localhost;Database=bd_sistemafatura_01;Uid=root;Pwd=;";
        public static MySqlConnection ObterConexao()
        {
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();
            return conexao;
        }
    }
}
