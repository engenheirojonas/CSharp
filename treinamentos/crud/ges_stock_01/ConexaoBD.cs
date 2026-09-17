using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace conexao_mysql_01
{
    internal class ConexaoBD
    {
        private string stringConexao = "server=localhost;database=bd_sistemastock;uid=root;pwd=;";

        public MySqlConnection ObterConexao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConexao);
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar à base de dados: " + ex.Message);
            }
        }

    }
}
