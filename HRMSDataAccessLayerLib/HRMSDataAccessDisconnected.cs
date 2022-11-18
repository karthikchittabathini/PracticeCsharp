using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSentitieslib; // for entities classes

namespace HRMSDataAccessLayerLib
{

    public class HRMSDataAccessDisconnected
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public HRMSDataAccessDisconnected()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=CGDB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from employes";

            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);

            ds = new DataSet(); 
            da.Fill(ds, "employes");

            ds.Tables[0].Constraints.Add("pk1", ds.Tables[0].Columns[0], true);

        }

        public bool AddEmployee(Employee emp)
        {
            //create a new row on the data set table
            DataRow row = ds.Tables[0].NewRow();

            //specify the values to the columns of the new row
            row[0] = emp.Ecode;
            row[1] = emp.Ename;
            row[2] = emp.Salary;
            row[3] = emp.Deptid;

            // add this new row to the rows of the data set
            ds.Tables[0].Rows.Add(row);

            //save changes to the data base
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "employes");

            //add primary key in dataset

            //ds.Tables[0].Constraints.Add("pk1", ds.Tables[0].Columns[0], true);
            return true;
        }

        public bool DeleteEmpById(int ecode)
        {
            // 1. Find the row to be deleted
            DataRow row = ds.Tables[0].Rows.Find(ecode);
            if (row != null)
            {
                //delete the row in the dataset
                row.Delete();
                //save changes to database
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employes");
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmp(Employee emp)
        {
            //Find the row to be updated
            DataRow row = ds.Tables[0].Rows.Find(emp.Ecode);
            if (row != null)
            {
                //update the row in dataset
                row[1] = emp.Ename;
                row[2] = emp.Salary;
                row[3] = emp.Deptid;
                //save changes to database
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "employes");

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAllEmps()
        {
            List<Employee> lstemps = new List<Employee> ();
            //Traverse all the rows in the DataSet and add them to the collection
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Employee emp = new Employee
                {
                    Ecode = (int)row[0],
                    Ename = row[1].ToString(),
                    Salary = (int)row[2],
                    Deptid = (int)row[3]
                };
                //add the row value to the collection result
                lstemps.Add(emp);
            }

            return lstemps;
        }

        public Employee GetEmpByid(int ecode)
        {
            Employee emp = null;
            //Find the record by ecode
            DataRow row = ds.Tables[0].Rows.Find(ecode);
            if (row != null)
            {
                emp = new Employee
                {
                    Ecode = (int)row[0],
                    Ename = row[1].ToString(),
                    Salary = (int)row[2],
                    Deptid = (int)row[3]
                };
            }
            return emp;
        }
    }
}
