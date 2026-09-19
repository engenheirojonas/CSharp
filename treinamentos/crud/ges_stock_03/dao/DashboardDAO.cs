using gestao_stock_03.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace gestao_stock_03.dao
{
    public class DashboardDAO
    {
        private ConexaoBD bd = new ConexaoBD();


        // Extrai contadores essenciais agrupados para os Cards informativos
        public DataTable ObterResumoKPI()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT " +
                             "(SELECT COUNT(*) FROM produtos) AS TotalProdutos, " +
                             "(SELECT SUM(quantidade_atual) FROM produtos) AS TotalItens, " +
                             "(SELECT COUNT(*) FROM produtos WHERE quantidade_atual <= quantidade_minima) AS ProdutosCriticos";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }


        // Dados estruturados para alimentar o componente Chart do WinForms
        public DataTable ObterDadosGrafico()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT c.nome AS Categoria, SUM(p.quantidade_atual) AS Quantidade " +
                             "FROM produtos p " +
                             "INNER JOIN Categorias c ON p.categoria_id = c.id " +
                             "GROUP BY c.nome";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }


    }
}
