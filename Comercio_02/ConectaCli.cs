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
    internal class ConectaCli
    {
        string conexao = "Data Source = JUN0675612W11-1\\BDSENAC; Initial Catalog = BDTI46; User ID = senaclivre; Password=senaclivre";

        public SqlConnection con = null;
        SqlDataAdapter da = null;

        //Replica tabelas
        public int id { get; set; }
        public string Cliente { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime dataCadCli {  get; set; }
        //Teste
        //CRUD CADCLI
        public void InserirCadcli()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "INSERT INTO CadClientes (Cliente, Sobrenome, Telefone, Email, dataCadCli) VALUES (@Cliente, @Sobrenome, @Telefone, @Email, @dataCadCli)";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@dataCadCli", dataCadCli);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro adicionado!");
            con.Close();
        }

        public void AlterarCadcli()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "update CadClientes set Cliente = @Cliente, Sobrenome = @Sobrenome, Telefone = @Telefone, Email = @Email, dataCadCli = @dataCadCli WHERE id = @id";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Cliente", Cliente);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@dataCadCli", dataCadCli);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro alterado!");
            con.Close();
        }

        public void ExcluirCadcli()
        {
            string sql;
            SqlCommand cmd;
            con = new SqlConnection(conexao);
            sql = "DELETE FROM CadClientes WHERE id=@id";
            con.Open();
            cmd = new SqlCommand (sql, con);
            cmd.Parameters.AddWithValue("@idcliente", id);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Registro Excluído!");
            con.Close();
        }

        public DataTable AtualizaGride(DataTable x)
        {
            string strSql;
            strSql = "SELECT * FROM CadClientes";

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
            strSql = "SELECT * FROM CadClientes WHERE cliente LIKE '%"+txtPes+"%'";
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
