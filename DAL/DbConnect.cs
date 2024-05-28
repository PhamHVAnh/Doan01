using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnect
    {
        public SqlConnection con;
        public SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string chuoikn = @"Data Source=DESKTOP-PHH1LIH;Initial Catalog=QuanlyDDHT;Integrated Security=True";
        public void ketnoi()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void dongkn()
        {
            con = new SqlConnection(chuoikn);
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void thucthisql(string sql)
        {
            ketnoi();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            dongkn();
        }
        public DataTable getData(string sql)
        {
            ketnoi();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            dongkn();
            return dt;
        }
        public DataTable Getdata(string sql, SqlParameter[] parameters)
        {
            ketnoi();
            cmd = new SqlCommand(sql, con);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dongkn();
            return dt;
        }
        public int kiemtramatrung(string ma, string sql)
        {
            ketnoi();
            int i;
            cmd = new SqlCommand(sql, con);
            i = (int)cmd.ExecuteScalar();
            dongkn();
            return i;
        }
        public void ExecuteStoredProcedure(string storedProcedureName)
        {
            ketnoi();
            cmd = new SqlCommand(storedProcedureName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            dongkn();
        }
        public void ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            ketnoi();
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
            }
            dongkn();
        }
    }
}
