using gestao_stock_03.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// 1. CERTIFIQUE-SE QUE ESTE USING ESTÁ AQUI NO TOPO

namespace gestao_stock_03
{
    public partial class frmMenuPrincipal : Form
    {
        private DashboardDAO dashDAO = new DashboardDAO();
        private string perfilUtilizador;

        public frmMenuPrincipal(string perfil = "")
        {
            InitializeComponent();

            this.perfilUtilizador = perfil;
            AplicarPermissoes();
        }

        private void AplicarPermissoes()
        {
            // Restringe o acesso a menus críticos caso o utilizador seja apenas Operador
            if (perfilUtilizador == "OPERADOR")
            {
                btnEliminarProdutos.Enabled = false;
                btnConfiguraUtilizadores.Visible = false;
            }
        }

        private void frmMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            // 1. Carregar os Indicadores (Cards)
            DataTable dtKPI = dashDAO.ObterResumoKPI();
            if (dtKPI.Rows.Count > 0)
            {
                lblTotalProdutos.Text = dtKPI.Rows[0]["TotalProdutos"].ToString();
                lblVolumeStock.Text = dtKPI.Rows[0]["TotalItens"].ToString();
                lblStockCritico.Text = dtKPI.Rows[0]["ProdutosCriticos"].ToString();
            }

            // 2. Renderizar o Gráfico de Barras / Torta dinamicamente
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProd = new frmProdutos();
            frmProd.Show();
            this.Visible = false;
        }
    }
}
