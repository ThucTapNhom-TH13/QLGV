using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLGV_nhom9
{
    class ChuoiKetNoi
    {
        SqlConnection con = new SqlConnection("Data Source=LINH\\SQLEXPRESS;Initial Catalog=QLGV;Integrated Security=True");

        
        public DataTable GetData(string sql, List<SqlParameter> danhsach)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.CommandType = CommandType.Text;
            foreach (SqlParameter p in danhsach)
                cmd.Parameters.Add(p);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable GetData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        //storedprocedure
        public DataTable GetDatastoreprocude(string sql,List<SqlParameter> danhsach)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter p in danhsach)
                cmd.Parameters.Add(p);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public void ExcecuteProcedure(string sql, List<SqlParameter> danhsach)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter p in danhsach)
                cmd.Parameters.Add(p);
            DataTable dt = new DataTable();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        // excutenonquery
        public  void ExecuteNonQuerySQL( string sql)
        {
          
            SqlCommand myCommand = new SqlCommand(sql, con);
            myCommand.Connection.Open();
            myCommand.ExecuteNonQuery();
            con.Close();
        }

        public void  ExecuteNonQuerySQL( string sql, List<SqlParameter> danhsach)
        {
            
            SqlCommand myCommand = new SqlCommand(sql,con);

            foreach (SqlParameter p in danhsach)
                myCommand.Parameters.Add(p);

            myCommand.Connection.Open();
            myCommand.ExecuteNonQuery();

            con.Close();
           
        }
    }
}
