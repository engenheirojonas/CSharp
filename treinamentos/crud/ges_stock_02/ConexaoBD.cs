using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestao_stock_02
{
    internal class ConexaoBD
    {
        private string stringConexao = "server=localhost;database=bd_sistemastock_02;uid=root;pwd=;";

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
