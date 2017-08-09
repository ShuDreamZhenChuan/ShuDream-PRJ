using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserInfoDao
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string usertype;

        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }
   
        string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
