using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    internal class ConectaVendaMestre   {
        string conexao = "Data Source = JUN0675611W11-1\\BDSENAC; Initial Catalog = BDTI46; User ID = senaclivre; Password=senaclivre";
        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas

        //MestreVendas
        public int id_MestreVendas { get; set; }
        public int idcliente { get; set; }
        public int id_prod { get; set; }
        public DateTime DataCompra { get; set; }






        //CRUD CADCLI
        public void CadMestreVendas()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "INSERT INTO MestreVendas (idcliente, DataCompra) " +
                "VALUES (@idcliente, @DataCompra)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idcliente", idcliente);
            cmd.Parameters.AddWithValue("@DataCompra", DataCompra);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Mestre de vendas adicionado!");
            con.Close();

        }







    }
}
