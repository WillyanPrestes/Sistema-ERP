using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Estudando
{
    public class oConexao
    {
        MySqlConnection conn;
        string str = "server=localhost;port=3306;user=root;database=estudo;password=32962377";

        public oConexao()
        {
           
        }
        public void Abrir()
        {
            this.conn = new MySqlConnection(str);
            this.conn.Open();   
        }
        public bool inserir(oProduto pr)
        {
            Abrir();
            MySqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = "insert into produto(descricao,preco,estoque) values(@d,@p,@e);";
                using (MySqlCommand mySqlCommand = new MySqlCommand(sql, conn,trans))
                {

                    mySqlCommand.Parameters.AddWithValue("@d", pr.Descricao);
                    mySqlCommand.Parameters.AddWithValue("@p", pr.Preco);
                    mySqlCommand.Parameters.AddWithValue("@e", pr.Estoque);


                    mySqlCommand.ExecuteNonQuery();
                    trans.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                conn.Close();   
            }
        }
        public bool Excluir(string sql)
        {
            bool foi;
            try
            {
                Abrir();
                MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
                mySqlCommand.ExecuteNonQuery();
                if (mySqlCommand.ExecuteNonQuery()>0)
                    return  true;
                else
                    return false;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public DataTable ListarDT(string sql = "select * from Produtos;")
        {
            DataTable dt = new DataTable();

            try
            {
                Abrir();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(dt);

                this.conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.conn.Close();
            }

            return dt;
        }
        public List<oProduto> Listar()
        {
            List<oProduto> lst = new List<oProduto>();

            DataTable dt = this.ListarDT();

            foreach (DataRow dr in dt.Rows)
                new oProduto()
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Descricao = dr["descricao"].ToString(),
                    Estoque = Convert.ToInt32(dr["estoque"]),
                    Preco = Convert.ToDecimal(dr["preco"])
                };
            return lst;
        }
        public oProduto Buscar(string desc)
        {
            oProduto produto = new oProduto();

            try
            {
                Abrir();
                string query = "select * from Produtos where descricao Like '%@desc%';";
                MySqlCommand mySqlCommand=new MySqlCommand(query,conn);
                mySqlCommand.Parameters.AddWithValue("@desc", desc);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                DataTable dt = new DataTable();    
                mySqlDataAdapter.Fill(dt);

                foreach (DataRow item in dt.Rows)
                    produto = new oProduto()
                    {
                        Id = Convert.ToInt16(item["id"]),
                        Descricao = item["descricao"].ToString(),
                        Estoque = Convert.ToInt32(item["estoque"]),
                        Preco = Convert.ToDecimal(item["preco"])
                    };
            }
            catch (Exception ex) { }

            return  produto;        
        }
    }
}
