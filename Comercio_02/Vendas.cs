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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }
                public string connectionString = @"Data Source=JUN0675612W11-1\BDSENAC; " +
                                      "Initial Catalog=BDComercioTi46; " +
                                      "Persist Security Info=True; " +
                                      "User ID=senaclivre;Password=senaclivre";

        public SqlConnection conexao = null;
        SqlDataAdapter da = null;
        DataTable dt = null;


        ConectaVendaMestre MestreVendas = new ConectaVendaMestre();
        //ConectaItensVendas itensVendas = new ConectaItensVendas();


        //MestreVendas
        public int id_MestreVendas { get; set; }
        public int idcliente { get; set; }
        public int id_prod { get; set; }
        public DateTime DataCompra { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MestreVendas.idcliente = int.Parse(txtId.Text);
            MestreVendas.DataCompra = DateTime.Parse(txtData.Text);

            MestreVendas.CadMestreVendas();

        }

  
        

    }
}
