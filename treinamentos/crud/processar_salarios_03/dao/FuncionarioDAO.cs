using MySql.Data.MySqlClient;
using processar_salarios_01.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;





namespace processar_salarios_01.DAO
{
    public class FuncionarioDAO : ConexaoBD
    {

        // Método de Pesquisa Avançada com filtros opcionais (.NET 10 C# 14 Style)
        public DataTable PesquisarAvancado(string? depto, int? mes, int? ano)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();

                // Base da Query SQL utilizando Raw String Literals do C# moderno
                string query = """
                    SELECT id AS 'ID', nome AS 'Nome', cargo AS 'Cargo', departamento AS 'Departamento', 
                           salario_bruto AS 'Salário Bruto', bonus AS 'Bónus', desconto_inss AS 'INSS (11%)', 
                           desconto_irs AS 'IRS', salario_liquido AS 'Salário Líquido', 
                           data_processamento AS 'Data Processamento'
                    FROM Funcionarios
                    WHERE 1=1
                    """;

                // Adiciona os filtros dinamicamente caso tenham sido preenchidos
                if (!string.IsNullOrWhiteSpace(depto)) query += " AND departamento = @depto";
                if (mes is > 0) query += " AND MONTH(data_processamento) = @mes";
                if (ano is > 0) query += " AND YEAR(data_processamento) = @ano";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    if (!string.IsNullOrWhiteSpace(depto)) cmd.Parameters.AddWithValue("@depto", depto);
                    if (mes is > 0) cmd.Parameters.AddWithValue("@mes", mes);
                    if (ano is > 0) cmd.Parameters.AddWithValue("@ano", ano);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao filtrar dados no .NET 10: {ex.Message}");
            }
            finally
            {
                Desconectar();
            }
        }

            // Método auxiliar para carregar os departamentos existentes na Base de Dados de forma única
        public List<string> ObterDepartamentosUnicos()
        {
            List<string> lista = new() { "Todos" };
            try
            {
                Conectar();
                string query = "SELECT DISTINCT departamento FROM Funcionarios WHERE departamento IS NOT NULL AND departamento != ''";
                using MySqlCommand cmd = new(query, conexao);
                using MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["departamento"].ToString()!);
                }
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }








        // Regras de Negócio e Cálculos Automáticos
        public void CalcularFolha(ref decimal bruto, ref decimal bonus, out decimal inss, out decimal irs, out decimal liquido)
        {
            // Exemplo Prático: 11% para Segurança Social/INSS
            inss = bruto * 0.11m;

            // Alíquotas progressivas simuladas para o IRS/Retenção
            if (bruto <= 2000) irs = bruto * 0.05m;
            else if (bruto <= 5000) irs = bruto * 0.10m;
            else irs = bruto * 0.15m;

            // Salário Líquido = (Bruto + Bónus) - Descontos
            liquido = (bruto + bonus) - (inss + irs);
        }

        // CREATE: Inserir Funcionário
        public bool Inserir(string nome, string cargo, string depto, decimal bruto, decimal bonus)
        {
            try
            {
                CalcularFolha(ref bruto, ref bonus, out decimal inss, out decimal irs, out decimal liquido);
                Conectar();

                string query = "INSERT INTO Funcionarios (nome, cargo, departamento, salario_bruto, bonus, desconto_inss, desconto_irs, salario_liquido) " +
                               "VALUES (@nome, @cargo, @depto, @bruto, @bonus, @inss, @irs, @liquido)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@depto", depto);
                    cmd.Parameters.AddWithValue("@bruto", bruto);
                    cmd.Parameters.AddWithValue("@bonus", bonus);
                    cmd.Parameters.AddWithValue("@inss", inss);
                    cmd.Parameters.AddWithValue("@irs", irs);
                    cmd.Parameters.AddWithValue("@liquido", liquido);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        // READ: Listar Todos os Registos
        public DataTable ListarTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                string query = "SELECT id AS 'ID', nome AS 'Nome', cargo AS 'Cargo', departamento AS 'Departamento', " +
                               "salario_bruto AS 'Salário Bruto', bonus AS 'Bónus', desconto_inss AS 'INSS (11%)', " +
                               "desconto_irs AS 'IRS', salario_liquido AS 'Salário Líquido' FROM Funcionarios";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexao))
                {
                    da.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar dados: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

            // UPDATE: Atualizar Dados Existentes
        public bool Atualizar(int id, string nome, string cargo, string depto, decimal bruto, decimal bonus)
        {
            try
            {
                CalcularFolha(ref bruto, ref bonus, out decimal inss, out decimal irs, out decimal liquido);
                Conectar();

                string query = "UPDATE Funcionarios SET nome=@nome, cargo=@cargo, departamento=@depto, " +
                               "salario_bruto=@bruto, bonus=@bonus, desconto_inss=@inss, desconto_irs=@irs, " +
                               "salario_liquido=@liquido WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@depto", depto);
                    cmd.Parameters.AddWithValue("@bruto", bruto);
                    cmd.Parameters.AddWithValue("@bonus", bonus);
                    cmd.Parameters.AddWithValue("@inss", inss);
                    cmd.Parameters.AddWithValue("@irs", irs);
                    cmd.Parameters.AddWithValue("@liquido", liquido);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

            // DELETE: Remover Funcionário
        public bool Excluir(int id)
        {
            try
            {
                Conectar();
                string query = "DELETE FROM Funcionarios WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //--------------------Impressão Nativa do Windows (System.Drawing.Printing)--------------------

        // Estrutura simples para transportar os dados do banco para a impressora
        public record DadosRecibo(
            int Id, string Nome, string Cargo, string Depto,
            decimal Bruto, decimal Bonus, decimal Inss, decimal Irs, decimal Liquido
        );

        public DadosRecibo? ObterDadosRecibo(int idFuncionario)
        {
            Conectar();
            string query = "SELECT * FROM Funcionarios WHERE id = @id";
            DadosRecibo? dados = null;

            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@id", idFuncionario);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        dados = new DadosRecibo(
                            idFuncionario,
                            dr["nome"].ToString()!,
                            dr["cargo"].ToString()!,
                            dr["departamento"].ToString()!,
                            Convert.ToDecimal(dr["salario_bruto"]),
                            Convert.ToDecimal(dr["bonus"]),
                            Convert.ToDecimal(dr["desconto_inss"]),
                            Convert.ToDecimal(dr["desconto_irs"]),
                            Convert.ToDecimal(dr["salario_liquido"])
                        );
                    }
                }
            }
            Desconectar();
            return dados;
        }

    }
}
