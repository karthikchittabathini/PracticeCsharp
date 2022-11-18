using System;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNetConnection
{
    public class Program
    {

        public static void ShowAllProducts()
        {
            string cnstring = "Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("select * from products", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int prodid;
            string prodname;
            double price;
            while (dr.Read())
            {
                prodid = Convert.ToInt32(dr["ProductID"]);
                prodname = dr["ProductName"].ToString();
                price = Convert.ToDouble(dr[5]);
                Console.WriteLine(prodid);
                Console.WriteLine(prodname);
                Console.WriteLine(price);
                Console.WriteLine("------- * ---------");
            }
            cn.Close();

        }

        public static void InsertData(string name, double price)
        {
            string cnstring = "Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("insert into products (ProductName,UnitPrice) values (" + "'" + name + "'" + "," + price + ")", cn);

            //  SqlCommand cmd = new SqlCommand("insert into products(ProductName,UnitPrice) values(" + "'" + name +"'" "," + price + ")", cn);

            cn.Open();
            int cnt = cmd.ExecuteNonQuery();
            Console.WriteLine(cnt + " Rows added Successfully");

            cn.Close();

        }

        public static void UpdateData(int prodid , string name , double price)
        {
            string cname = "Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cname);
            SqlCommand cmd = new SqlCommand("update Products set productname='" + name + "',unitprice=" + price + " where productid=" + prodid, cn);
            cn.Open();
            int cnt = cmd.ExecuteNonQuery();
            cn.Close();

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Menu \n 1.Show All \n 2. Insert \n 3. Update \n 4. Delete  \n 5. Find \n 6. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllProducts();
                    break;

                case 2:
                    string prodName = Console.ReadLine();
                    double price = Convert.ToDouble(Console.ReadLine());
                    InsertData(prodName,price);
                    break;
                case 3:
                    Console.WriteLine("Enter the product id");
                    int prodid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the product name");
                    string prodname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the product price");
                    double prodprice = Convert.ToDouble(Console.ReadLine());
                    UpdateData(prodid, prodname, prodprice);
                    break;
            }


            Console.Read();
        }
    }
}
