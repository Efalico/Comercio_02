using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    public partial class CadEstoque : Form
    {
        public CadEstoque()
        {
            InitializeComponent();
        }
        ConectaEstoque comEst = new ConectaEstoque();

        DataTable dt = null;
        string operacao;
        public SqlConnection con = null;
        SqlDataAdapter da = null;


        //Replica tabelas
        public int id_estoque { get; set; }
        public int idprod { get; set; }
        public double precoUnit { get; set; }
        public DateTime dataEntr { get; set; }
        public DateTime dataSaida { get; set; }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            comEst.idprod = int.Parse(txtIDProd.Text);
            comEst.precoUnit = double.Parse(txtPrecoUnit.Text);
            comEst.dataEntr = Convert.ToDateTime(txtDataEnt.Text);  
            comEst.dataSaida = Convert.ToDateTime(txtDataSaida.Text);

            comEst.InserirEstoque();

            limpadados();

        }

        private void limpadados()
        {
            txtID.Text = string.Empty;
            txtIDProd.Text = string.Empty;
            txtPrecoUnit.Text = string.Empty;
            txtDataEnt.Text = string.Empty;
            txtDataSaida.Text = string.Empty;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            comEst.id_estoque = int.Parse(txtID.Text);
            comEst.idprod = int.Parse(txtIDProd.Text);
            comEst.precoUnit = double.Parse(txtIDProd.Text);
            comEst.dataEntr = Convert.ToDateTime(txtDataEnt.Text);
            comEst.dataSaida = Convert.ToDateTime(txtDataSaida.Text);

            comEst.AlterarCadEstoque();
            limpadados();
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            dgCadEstoque.DataSource = comEst.AtualizaGride(dt);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            comEst.id_estoque = int.Parse(txtID.Text) ;

            comEst.ExcluirEstoque();
            limpadados() ;
            atualizaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpadados();
        }

        private void dgCadEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgCadEstoque.CurrentRow.Cells[0].Value.ToString();
            txtIDProd.Text = dgCadEstoque.CurrentRow.Cells[1].Value.ToString();
            txtPrecoUnit.Text = dgCadEstoque.CurrentRow.Cells[2].Value.ToString();
            txtDataEnt.Text = dgCadEstoque.CurrentRow.Cells[3].Value.ToString();
            txtDataSaida.Text = dgCadEstoque.CurrentRow.Cells[4].Value.ToString();

        }

        private void CadEstoque_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }
    }
}
