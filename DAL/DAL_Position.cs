using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_Position:DAL_Common
    {
        public DataTable selectPositionListInfo(string positiontype)
        {

            string tablename = "t_position";

            string sql = "select a.id,a.position " +
            " from " + tablename + " a where 1=1 ";
            if (positiontype != "")
            {
                sql += " and positiontype='" + positiontype + "' ";
            }

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return _dt;
            }
        }

        //public DAO.CustomerDao selectCustomerInfoID(string id)
        //{

        //    string tablename = "t_customer";

        //    string sql = "select .*" +
        //    " from " + tablename + " " +
        //    " where id=" + id + " ";

        //    DataTable _dt = this.SelectQuery(sql);
        //    if (_dt == null || _dt.Rows.Count <= 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        DAO.CustomerDao dao = new DAO.CustomerDao();

        //        dao.Name = _dt.Rows[0]["name"].ToString();
        //        dao.Sex = _dt.Rows[0]["sex"].ToString();
        //        dao.Nation = _dt.Rows[0]["nation"].ToString();
        //        dao.Job = _dt.Rows[0]["job"].ToString();
        //        dao.Idcard = _dt.Rows[0]["idcard"].ToString();
        //        dao.Rfid = _dt.Rows[0]["rfid"].ToString();
        //        dao.Group = _dt.Rows[0]["group"].ToString();
        //        dao.Remark = _dt.Rows[0]["remark"].ToString();

        //        return dao;
        //    }
        //}

        //public string GetCustomerIDWithIDCard(string idCard)
        //{

        //    string tablename = "t_customer";

        //    string sql = "select top 1 id " +
        //    " from " + tablename + " " +
        //    " where idcard=" + idCard + " ";

        //    DataTable _dt = this.SelectQuery(sql);
        //    if (_dt == null || _dt.Rows.Count <= 0)
        //    {
        //        return "";
        //    }
        //    else
        //    {
        //        return _dt.Rows[0][0].ToString();
        //    }
        //}

        public string GetPositionType(string positionname)
        {
            string sql = "select positiontype from t_position where position='" + positionname + "' ";

            DataTable _dt=this.SelectQuery(sql);

            if (_dt != null)
            {
                return _dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        
        
        }

        public string GetPositionDirection(string positionname)
        {
            string sql = "select positiondirection from t_position where position='" + positionname + "' ";

            DataTable _dt = this.SelectQuery(sql);

            if (_dt != null)
            {
                return _dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }


        }

        public int GetPositionID(string positionname)
        {
            string sql = "select id from t_position where position='" + positionname + "' ";

            DataTable _dt = this.SelectQuery(sql);

            if (_dt != null)
            {
                return Convert.ToInt32(_dt.Rows[0][0]);
            }
            else
            {
                return -1;
            }


        }



        public bool deletePositionWithId(string id)
        {
            string sql = "delete from t_position " +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool insertPositionInfo(DAL.DAO.PositionDao dao)
        {
            string sql = "insert into t_position(position,positiontype,positiondirection) values " +
            " ('" + dao.Position + "','" + dao.Positiontype + "',"+dao.Positiondirection+") ";

            return this.InsertQuery(sql);
        }

        public bool updatePositionInfo(string id, DAO.PositionDao dao)
        {
            string sql = "update t_position set position='" + dao.Position + "' where id=" + id + "  ";

            return this.updateQuery(sql);
        }
    
    
    
    
    
    
    
    }




}
