using gestao_stock_03.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace gestao_stock_03.dao
{
    internal class ProdutoDAO
    {
        private ConexaoBD bd = new ConexaoBD();

        // Salvar / Inserir
        public bool Inserir(string codigo, string nome, decimal compra, decimal venda, int qtd, int qtdMin, int catId, int fornId)
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "INSERT INTO Produtos (codigo_barras, nome, preco_compra, preco_venda, quantidade_atual, quantidade_minima, categoria_id, fornecedor_id) " +
                             "VALUES (@codigo, @nome, @compra, @venda, @qtd, @qtdMin, @catId, @fornId)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@compra", compra);
                cmd.Parameters.AddWithValue("@venda", venda);
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@qtdMin", qtdMin);
                cmd.Parameters.AddWithValue("@catId", catId);
                cmd.Parameters.AddWithValue("@fornId", fornId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Listar Todos os Produtos
        public DataTable ListarTodos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT p.id, p.codigo_barras, p.nome, p.preco_compra, p.preco_venda, p.quantidade_atual, p.quantidade_minima, " +
                             "c.nome AS Categoria, f.nome AS Fornecedor " +
                             "FROM Produtos p " +
                             "LEFT JOIN Categorias c ON p.categoria_id = c.id " +
                             "LEFT JOIN Fornecedores f ON p.fornecedor_id = f.id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Atualizar / Editar
        public bool Atualizar(int id, string codigo, string nome, decimal compra, decimal venda, int qtd, int qtdMin, int catId, int fornId)
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "UPDATE Produtos SET codigo_barras=@codigo, nome=@nome, preco_compra=@compra, preco_venda=@venda, " +
                             "quantidade_atual=@qtd, quantidade_minima=@qtdMin, categoria_id=@catId, fornecedor_id=@fornId WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@compra", compra);
                cmd.Parameters.AddWithValue("@venda", venda);
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@qtdMin", qtdMin);
                cmd.Parameters.AddWithValue("@catId", catId);
                cmd.Parameters.AddWithValue("@fornId", fornId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Eliminar / Excluir
        public bool Eliminar(int id)
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "DELETE FROM Produtos WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
