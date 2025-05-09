using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace Comercio_02
{
   
    public partial class CadProdutos : Form
    {
       
        public CadProdutos()
        {
            InitializeComponent();
            atualizaGrid();
        }

        ConectaProduto compro = new ConectaProduto();

        public string conec = @"Data Source=JUN0684686W11-1\BDSENAC;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        public SqlConnection con = null;

        SqlDataAdapter da = null;
        DataTable dt = null;
        string operacao;



        //Replica tabelas Cadprodutos
        public int idprod { get; set; }
        public string nomeprod { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime dataProduto { get; set; }
        public decimal valorUnitario { get; set; }

        private void btnInserir_Click(object sender, EventArgs e)
        {

           compro.NomeProd = txtProduto.Text;
           compro.Marca = txtmarca.Text;
           compro.Modelo = txtmodelo.Text;
           compro.DataProduto = Convert.ToDateTime(txtdatacadproduto.Text);
           compro.valorUnitario = Convert.ToDecimal(txtValorUni.Text);

            compro.InserirCadpro();
            limpadados();
            atualizaGrid();

        }

        private void atualizaGrid()
        {
            dgCadprodutos.DataSource = compro.AtualizaGride(dt);
        }

        private void limpadados()
        {
            txtidproduto.Text = string.Empty;
            txtmarca.Text = string.Empty;
            txtmodelo.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtdatacadproduto.Text = string.Empty;
            txtValorUni.Text = string.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpadados();
        }

        private void dgCadprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproduto.Text = dgCadprodutos.CurrentRow.Cells[0].Value.ToString();
            txtProduto.Text = dgCadprodutos.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = dgCadprodutos.CurrentRow.Cells[2].Value.ToString();
            txtmodelo.Text = dgCadprodutos.CurrentRow.Cells[3].Value.ToString();
            txtdatacadproduto.Text = dgCadprodutos.CurrentRow.Cells[4].Value.ToString();
            txtValorUni.Text = dgCadprodutos.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            compro.id= int.Parse(txtidproduto.Text);
            compro.NomeProd = txtProduto.Text;
            compro.Marca = txtmarca.Text;
            compro.Modelo = txtmodelo.Text;
            compro.DataProduto = Convert.ToDateTime(txtdatacadproduto.Text);
            if (decimal.TryParse(txtValorUni.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valorUnitario))
            {
                compro.valorUnitario = valorUnitario;
                compro.AlterarCadprod();
                limpadados();
                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Valor unitário inválido. Utilize o formato correto.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            compro.id = int.Parse(txtidproduto.Text);
            compro.ExcluirCadpro();
            limpadados();
            atualizaGrid();
        }
        private void CadProdutos_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void dgCadProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproduto.Text = dgCadprodutos.CurrentRow.Cells[0].Value.ToString();
            txtProduto.Text = dgCadprodutos.CurrentRow.Cells[1].Value.ToString();
            txtmarca.Text = dgCadprodutos.CurrentRow.Cells[2].Value.ToString();
            txtmodelo.Text = dgCadprodutos.CurrentRow.Cells[3].Value.ToString();
            txtdatacadproduto.Text = dgCadprodutos.CurrentRow.Cells[4].Value.ToString();
            txtValorUni.Text = dgCadprodutos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}


