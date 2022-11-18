using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSentitieslib; // for entities
using HRMSDataAccessLayerLib; // for dataAccessLayer

namespace HRMSBusinessLayerLIb
{
    public class HRMSBusinessLayer
    {
        public bool AddEmployee(Employee emp)
        {
            HRMSDataAccessDisconnected dal = new HRMSDataAccessDisconnected();
            bool status = dal.AddEmployee(emp);
            return status;
        }

        public bool DeleteEmpById(int ecode)
        {
            HRMSDataAccessDisconnected dal = new HRMSDataAccessDisconnected();
            bool status = dal.DeleteEmpById(ecode);
            return status;
        }

        public bool UpdateEmp(Employee emp)
        {
            HRMSDataAccessDisconnected dal = new HRMSDataAccessDisconnected();
            bool status = dal.UpdateEmp(emp);
            return status;
        }

        public List<Employee> GetAllEmps()
        {
            List<Employee> lstemps = new List<Employee>();
            //Get all records using DAL Layer
            HRMSDataAccessDisconnected dal = new HRMSDataAccessDisconnected();
            lstemps = dal.GetAllEmps();
            return lstemps;
        }

        public Employee GetEmpByid(int ecode)
        {
            Employee emp = new Employee();
            //Get the reocrd using the DAL Layer
            HRMSDataAccessDisconnected dal = new HRMSDataAccessDisconnected();
            emp = dal.GetEmpByid(ecode);
            return emp;
        }
    }
}
