using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio_02
{
    internal class ConectaEstoque
    {
        public string conec = @"Data Source=JUN0675612W11-1\BDSENAC;
                              Initial Catalog=BDComercioTi46;
                              Persist Security Info=True;
                              User ID=senaclivre;Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas
        public int id_estoque { get; set; }
        public int idprod { get; set; }
        public double precoUnit { get; set; }
        public DateTime dataEntr { get; set; }
        public DateTime dataSaida { get; set; }



        //CRUD CADESTOQUE
        public void InserirEstoque()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "INSERT INTO CadEstoque (idprod, precoUnit, dataEntr, dataSaida) " +
                "VALUES (@idprod, @precoUnit, @dataEntr, @dataSaida)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idprod", idprod);
            cmd.Parameters.AddWithValue("@precoUnit", precoUnit);
            cmd.Parameters.AddWithValue("@dataEntr", dataEntr);
            cmd.Parameters.AddWithValue("@dataSaida", dataSaida);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro adicionado!");
            con.Close();

        }

        public void AlterarCadEstoque()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "update CadEstoque set idprod = @idprod, precoUnit = @precoUnit, " +
                "dataEntr=@dataEntr, dataSaida=@dataSaida where id_estoque = @id_estoque";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id_estoque", id_estoque);
            cmd.Parameters.AddWithValue("@idprod", idprod);
            cmd.Parameters.AddWithValue("@precoUnit", precoUnit);
            cmd.Parameters.AddWithValue("@dataEntr", dataEntr);
            cmd.Parameters.AddWithValue("@dataSaida", dataSaida);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Alterado!");
            con.Close();
        }


        //ExcluirCadEstoque
        public void ExcluirEstoque()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conec);
            sql = "DELETE FROM CadEstoque WHERE id_estoque=@id_estoque";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id_estoque", id_estoque);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Excluido!");
            con.Close();
        }


        public DataTable AtualizaGride(DataTable x)
        {
            string strSql;
            strSql = "SELECT * FROM CadEstoque";

            con = new SqlConnection(conec);
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return x;

        }

        public DataTable PesquisaProduto(DataTable x, string txtPes)
        {
            string strSql;
            strSql = "SELECT * FROM CadEstoque WHERE idprod LIKE '%" + txtPes + "%'";
            con = new SqlConnection(conec);
            da = new SqlDataAdapter(strSql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            x = dt;
            con.Close();
            return (x);
        }


    }
}
    

