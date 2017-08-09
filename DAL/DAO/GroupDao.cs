using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class GroupDao
    {
        string grouppname;

        public string Grouppname
        {
            get { return grouppname; }
            set { grouppname = value; }
        }
        string groupmanager;

        public string Groupmanager
        {
            get { return groupmanager; }
            set { groupmanager = value; }
        }
        string managerphone;

        public string Managerphone
        {
            get { return managerphone; }
            set { managerphone = value; }
        }
        string describe;

        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }



    }
}
