using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
   public class CustomerDao
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        string nation;

        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }

        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        string idcard;

        public string Idcard
        {
            get { return idcard; }
            set { idcard = value; }
        }

        string rfid;

        public string Rfid
        {
            get { return rfid; }
            set { rfid = value; }
        }

        string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        int istemp;

        public int Istemp
        {
            get { return istemp; }
            set { istemp = value; }
        }
    }
}
