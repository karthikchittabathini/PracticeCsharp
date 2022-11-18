using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAceessLayer;

namespace BusinessLayer
{
    public class BusinessLayerclass
    {
        DataAccess dal = new DataAccess();
       public bool InsertToBlogger(UserBO ubo)
       {
            bool status = dal.InsertToBlogger(ubo);
            return status;
       }

        public bool InsertToBlog(UserBO ubo)
        {
            bool status = dal.InsertToBlog(ubo);
            return status;
        }

        public bool ShowBloggerData()
        {
            bool status = dal.ShowBloggerData();
            return status;
        }

        public bool ShowBlogData()
        {
            bool status = dal.ShowBlogData();
            return status;
        }
    }
}
