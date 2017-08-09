using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class DeviceDao
    {
        string devicename;

        public string Devicename
        {
            get { return devicename; }
            set { devicename = value; }
        }
        string devicetype;

        public string Devicetype
        {
            get { return devicetype; }
            set { devicetype = value; }
        }
        string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        string netaddress;

        public string Netaddress
        {
            get { return netaddress; }
            set { netaddress = value; }
        }
        string deviceposition;

        public string Deviceposition
        {
            get { return deviceposition; }
            set { deviceposition = value; }
        }



    }
}
