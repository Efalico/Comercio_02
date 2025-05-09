using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
 
    internal class ConectaProduto
    {
        string conexao = "Data Source = JUN0675612W11-1\\BDSENAC; Initial Catalog = BDComercioTI46; User ID = senaclivre; Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas
        public int id{ get; set; }
        public string NomeProd { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime DataProduto {  get; set; }
        public decimal valorUnitario {  get; set; }    

        //CRUD CADPRO
        public void InserirCadpro()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "INSERT INTO CadProdutos (NomeProd, Marca, Modelo, DataProduto,ValorUnitario) VALUES (@NomeProd, @Marca, @Modelo, @DataProduto,@ValorUnitario)";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@NomeProd", NomeProd);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@Modelo", Modelo);
            cmd.Parameters.AddWithValue("@DataProduto", DataProduto);
            cmd.Parameters.AddWithValue("@valorUnitario", valorUnitario);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro adicionado!");
            con.Close();
        }

        public void AlterarCadprod()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "update cadprodutos set nomeprod = @nomeprod, " +
                "marca=@marca, modelo=@modelo, dataproduto=@dataProduto, valorUnitario=@valorUnitario where idprod = @idprod";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idprod", id);
            cmd.Parameters.AddWithValue("@NomeProd", NomeProd);
            cmd.Parameters.AddWithValue("@Marca",Marca );
            cmd.Parameters.AddWithValue("@Modelo", Modelo);
            cmd.Parameters.AddWithValue("@DataProduto",DataProduto );
            cmd.Parameters.AddWithValue("@valorUnitario", valorUnitario);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro alterado!");
            con.Close();
        }

        public void ExcluirCadpro()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "DELETE FROM CadProdutos WHERE IDProd=@id";
            con.Open();
            cmd = new SqlCommand (sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Registro Excluído!");
            con.Close();
        }

        public DataTable AtualizaGride(DataTable x)
        {
            string strSql;
            strSql = "SELECT * FROM CadProdutos";

            con = new SqlConnection(conexao);
            SqlDataAdapter da = new SqlDataAdapter (strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            x = dt;
            con.Close ();
            return x;
        }

        public DataTable PesquisaNome(DataTable x, string txtPes)
        {
            string strSql;
            strSql = "SELECT * FROM CadProdutos WHERE NomeProd LIKE '%"+txtPes+"%'";
            con = new SqlConnection (conexao);
            da = new SqlDataAdapter (strSql, con);
            DataTable dt = new DataTable();
            da.Fill (dt);
            con.Open ();
            x = dt;
            con.Close ();
            return x;
        }
    }
}
