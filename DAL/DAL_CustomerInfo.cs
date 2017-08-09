using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DAL_CustomerInfo:DAL_Common
    {

        public DataTable getNationTable()
        {
            string sql = "select itemvalue,itemname from t_itemcollection where itemtype='NationEnum' ";
            
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

        public DataTable selectCustomerInfoWithGroupAndKey(string key, string groupName,string customertype)
        {

            string tablename = "t_passenger";

            string sql = "select DISTINCT a.id,a.name,a.idcard,a.rfid,c.itemname as customertype" +
            " from " + tablename + " a " +
            " left join t_pg_binding tpg on tpg.passengerid=a.id "+
            " left join t_group tg on tg.id=tpg.groupid " +
            " left join t_itemcollection c on c.itemvalue=a.is_temp and itemtype='CustomerType' where 1=1 ";
            if(key!="")
            {
                sql+=" and (a.name like '%" + key + "%' or a.idcard='" + key + "' or a.rfid='" + key + "') ";
            }
            if (groupName != "全部")
            {
                sql += " and  tg.groupname='" + groupName + "' ";
            }
            if (customertype != "")
            {
                sql += " and  c.itemname='" + customertype + "' ";
            }
            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null)
            {
                return null;
            }
            else
            {
                return _dt;
            }
        }

        public DAO.CustomerDao  selectCustomerInfoID(string id)
        {

            string tablename = "t_passenger";

            string sql = "select a.*" +
            " from " + tablename + " a " +
            " where a.id="+id+" ";
           
            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DAO.CustomerDao dao = new DAO.CustomerDao();

                dao.Name = _dt.Rows[0]["name"].ToString();
                dao.Sex = _dt.Rows[0]["sex"].ToString();
                dao.Nation = _dt.Rows[0]["nation"].ToString();
                dao.Address = _dt.Rows[0]["address"].ToString();
                dao.Idcard = _dt.Rows[0]["idcard"].ToString();
                dao.Rfid = _dt.Rows[0]["rfid"].ToString();
                dao.Remark = _dt.Rows[0]["remark"].ToString();
                dao.Istemp = Convert.ToInt32(_dt.Rows[0]["is_temp"].ToString());
                return dao;
            }
        }

        public DAO.CustomerDao selectCustomerInfoWithCardNum(string num)
        {

            string tablename = "t_passenger";

            string sql = "select a.* " +
            " from " + tablename + " a " +
            " where idcard='" + num + "' or rfid='" + num + "' ";

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DAO.CustomerDao dao = new DAO.CustomerDao();

                dao.Name = _dt.Rows[0]["name"].ToString();
                dao.Sex = _dt.Rows[0]["sex"].ToString();
                dao.Nation = _dt.Rows[0]["nation"].ToString();
                dao.Address = _dt.Rows[0]["address"].ToString();
                dao.Idcard = _dt.Rows[0]["idcard"].ToString();
                dao.Rfid = _dt.Rows[0]["rfid"].ToString();
                dao.Remark = _dt.Rows[0]["remark"].ToString();
                dao.Istemp = Convert.ToInt32(_dt.Rows[0]["is_temp"].ToString());

                return dao;
            }
        }

        public DataTable SelectGroupWithCustomerID(string customerid)
        {
            string sql = "Select a.id,tg.groupname,td.name as devicename from t_pg_binding a " +
                " left join t_group tg on tg.id=a.groupid " +
                " left join t_passenger tp on tp.id=a.passengerid " +
                " left join t_gd_binding tgd on tgd.groupid=tg.id " +
                " left join t_device td on td.id=tgd.deviceid where 1=1 " +
                " and tp.id=" + customerid + " ";

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

        public DataTable SelectGroupCanJoinWithCustomerID(string customerid)
        {
            string sql = "Select tg.id,tg.groupname,td.name as devicename from t_group tg " +
                " left join t_gd_binding tgd on tgd.groupid=tg.id " +
                " left join t_device td on td.id=tgd.deviceid where 1=1 " +
                " and tg.id not in (select groupid from t_pg_binding tpg where tpg.passengerid=" + customerid + ") ";

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


        public string GetCustomerIDWithIDCard(string idCard)
        {

            string tablename = "t_passenger";

            string sql = "select top 1 id " +
            " from " + tablename + " " +
            " where idcard='" + idCard + "' ";

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return "";
            }
            else
            {
                return _dt.Rows[0][0].ToString();
            }
        }


        public bool deleteCustomerWithId(string id)
        {
            string sql = "delete from t_passenger " +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool insertCustomerInfo(DAO.CustomerDao dao)
        {
            string sql = "insert into t_passenger(`name`,sex,nation,idcard,address,rfid,remark,is_temp) values " +
            " ('" + dao.Name + "','" + dao.Sex + "','" + dao.Nation + "','" + dao.Idcard + "','" + dao.Address + "','" + dao.Rfid + "','" + dao.Remark + "'," + dao.Istemp + ") ";

            return this.InsertQuery(sql);
        }

        public bool updateCustomerInfo(string id,DAO.CustomerDao dao)
        {
            string sql = "update t_passenger set `name`='" + dao.Name + "',sex='" + dao.Sex + "',nation='" + dao.Nation + "',idcard='" + dao.Idcard + "',address='" + dao.Address + "',rfid='" + dao.Rfid + "',remark='" + dao.Remark + "',is_temp="+dao.Istemp+" where id=" + id + "  ";

            return this.updateQuery(sql);
        }


    }
}
