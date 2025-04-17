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
   
    public partial class CadProdutos : Form
    {
        ConectaProduto compro = new ConectaProduto();
        public CadProdutos()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

           compro.NomeProd = txtProduto.Text;
           compro.Marca = txtmarca.Text;
           compro.Modelo = txtmodelo.Text;
           compro.DataProduto = Convert.ToDateTime(txtdatacadproduto.Text);


        }
    }
}
