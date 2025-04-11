using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public partial class Comercio : Form
    {
        public Comercio()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClientes cadClientes = new CadClientes();
            cadClientes.Show();
            //explicação para Nicholas
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProdutos cadProdutos = new CadProdutos();
            cadProdutos.Show(); 
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEstoque cadEstoque = new CadEstoque();
            cadEstoque.Show();
        }
    }
}
