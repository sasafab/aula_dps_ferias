using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_dps_ferias.forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias categorias = new FrmCategorias();
            categorias.ShowDialog();
        }
    }
}
