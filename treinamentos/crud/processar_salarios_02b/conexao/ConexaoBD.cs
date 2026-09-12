using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace processar_salarios_01.conexao
{
        public class ConexaoBD
        {
            // Altere as credenciais conforme a configuração do seu servidor local
            private readonly string stringConexao = "Server=localhost;Database=bd_processasalarios;Uid=root;Pwd=;";
            protected MySqlConnection conexao;

            protected void Conectar()
            {
                conexao = new MySqlConnection(stringConexao);
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }

            protected void Desconectar()
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }
        }
}
