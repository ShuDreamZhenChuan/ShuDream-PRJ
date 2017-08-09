using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class VehicleInfoDao
    {
        string vehiclenum;

        public string Vehiclenum
        {
            get { return vehiclenum; }
            set { vehiclenum = value; }
        }
        string vehicleowner;

        public string Vehicleowner
        {
            get { return vehicleowner; }
            set { vehicleowner = value; }
        }
        string vehiclegrand;

        public string Vehiclegrand
        {
            get { return vehiclegrand; }
            set { vehiclegrand = value; }
        }
        string vehiclekind;

        public string Vehiclekind
        {
            get { return vehiclekind; }
            set { vehiclekind = value; }
        }
        string vehiclecolor;

        public string Vehiclecolor
        {
            get { return vehiclecolor; }
            set { vehiclecolor = value; }
        }

        int istemp;

        public int Istemp
        {
            get { return istemp; }
            set { istemp = value; }
        }

    }
}
