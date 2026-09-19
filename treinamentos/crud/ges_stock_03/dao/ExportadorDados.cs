using System;
using System.Collections.Generic;
using System.Text;

namespace gestao_stock_03.dao
{
    public class ExportadorDados
    {
        // Exportação universal para formato .CSV legível instantaneamente no Microsoft Excel
        public static void ParaCSV(DataGridView dgv, string caminhoFicheiro)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Montar o Cabeçalho
                string[] cabecalhos = new string[dgv.Columns.Count];
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    cabecalhos[i] = dgv.Columns[i].HeaderText;
                }
                sb.AppendLine(string.Join(";", cabecalhos));

                // Montar as Linhas de Dados
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    if (!linha.IsNewRow)
                    {
                        string[] celulas = new string[dgv.Columns.Count];
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            celulas[i] = linha.Cells[i].Value?.ToString() ?? "";
                        }
                        sb.AppendLine(string.Join(";", celulas));
                    }
                }

                File.WriteAllText(caminhoFicheiro, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Ficheiro exportado com sucesso para o Excel/CSV!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao exportar dados: " + ex.Message);
            }
        }

    }
}
