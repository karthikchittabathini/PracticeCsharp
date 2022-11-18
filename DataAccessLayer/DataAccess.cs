using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess
    {

        public bool InsertToBlogger(UserBO ubo)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection("Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=BlogsDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Blogger values(" + ubo.BloggerID + "," + "'" + ubo.BloggerName + "'" + "," + "'" + ubo.BloggerSubject + "'"+ ")", cn);
            cn.Open();
            int count = cmd.ExecuteNonQuery();
            Console.WriteLine(count + "rows added");
            cn.Close();
            status = true;
            return status;
        }

        public bool InsertToBlog(UserBO ubo)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection("Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=BlogsDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Blogs values(" + ubo.BlogID + "," + "'" + ubo.BlogName + "'" + "," + "'" + ubo.BlogContent + "'" + "," + "'" + ubo.BlogDate + "'" + "," + ubo.BloggerID + ")", cn);
            cn.Open();
            int count = cmd.ExecuteNonQuery();
            Console.WriteLine(count + "rows added");
            cmd.ExecuteNonQuery();
            cn.Close();
            status = true;
            return status;
        }

        public bool ShowBloggerData()
        {
            bool status = false;
            List<UserBO> BloggerList = new List<UserBO>();
            SqlConnection cn = new SqlConnection("Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=BlogsDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Blogger", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UserBO ubo = new UserBO();
                ubo.BloggerID = Convert.ToInt32(dr[0]);
                ubo.BloggerName = dr[1].ToString();
                ubo.BloggerSubject = dr[2].ToString();
                BloggerList.Add(ubo);
            }

            foreach (var x in BloggerList)
            {
                Console.WriteLine(x.BloggerID + "\t" + x.BloggerName + "\t" + x.BloggerSubject);
            }

            cn.Close();
            status = true;
            return status;

        }

        public bool ShowBlogData()
        {
            bool status = false;
            List<UserBO> BlogList = new List<UserBO>();
            SqlConnection cn = new SqlConnection("Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=BlogsDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Blogs", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UserBO uboa = new UserBO();
                uboa.BlogID = Convert.ToInt32(dr[0]);
                uboa.BlogName = dr[1].ToString();
                uboa.BlogContent = dr[2].ToString();
                uboa.BlogDate = Convert.ToDateTime(dr[3].ToString());
                uboa.BloggerID = Convert.ToInt32(dr[4]);
                BlogList.Add(uboa);
            }

            foreach (var x in BlogList)
            {
                Console.WriteLine(x.BlogID + "\t" + x.BlogName + "\t" + x.BlogContent + "\t" + x.BlogDate + "\t" + x.BloggerID);
            }

            cn.Close();
            status = true;
            return status;

        }

    }
}

