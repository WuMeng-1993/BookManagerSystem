using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerSystem
{
    internal class Dao
    {
        // 数据库链接对象
        SqlConnection sc;

        // 链接数据库
        public SqlConnection connect()
        {
            string str = @"Data Source=.;Initial Catalog=BookMS;Integrated Security=True;Trust Server Certificate=True";
            sc = new SqlConnection(str); sc.Open();
            return sc;
        }

        // 执行SQL语句
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd; 
        }

        // 获取执行SQL语句后，数据库表中数据条数的更新数量
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        // 读取数据库中的数据
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        // 关闭数据库
        public void Daoclose()
        {
            sc.Close(); 
        }
    }
}
