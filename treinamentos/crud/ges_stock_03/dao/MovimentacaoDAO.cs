using gestao_stock_03.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gestao_stock_03.dao
{
    public class MovimentacaoDAO
    {
        private ConexaoBD bd = new ConexaoBD();

        // Registar Entrada ou Saída
        public bool RegistrarMovimentacao(int produtoId, string tipo, int quantidade, string motivo)
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "INSERT INTO Movimentacoes (produto_id, tipo, quantidade, motivo) VALUES (@produtoId, @tipo, @quantidade, @motivo)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@produtoId", produtoId);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@motivo", motivo);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Histórico Geral de Movimentações
        public DataTable ListarHistorico()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT m.id, p.nome AS Produto, m.tipo, m.quantidade, m.data_movimentacao, m.motivo " +
                             "FROM Movimentacoes m " +
                             "INNER JOIN Produtos p ON m.produto_id = p.id " +
                             "ORDER BY m.data_movimentacao DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Relatório de Alerta: Produtos abaixo do stock mínimo
        public DataTable ListarStockBaixo()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT id, codigo_barras, nome, quantidade_atual, quantidade_minima " +
                             "FROM Produtos WHERE quantidade_atual <= quantidade_minima";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }



    }
}
