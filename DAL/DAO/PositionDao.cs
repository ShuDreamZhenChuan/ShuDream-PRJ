using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.DAO
{
    public class PositionDao
    {
        string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        string positiontype;

        public string Positiontype
        {
            get { return positiontype; }
            set { positiontype = value; }
        }

        string positiondirection;

        public string Positiondirection
        {
            get { return positiondirection; }
            set { positiondirection = value; }
        }



    }
}
