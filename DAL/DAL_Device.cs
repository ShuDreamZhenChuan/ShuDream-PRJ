using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_Device:DAL_Common
    {
        public DataTable selectDeviceInfoWithPositionAndKey(string key, string position)
        {

            string tablename = "t_device";

            string sql = "select a.id,a.`name` as devicename,b.itemname as devicetype,a.code,a.netaddress,c.position as position " +
            " from " + tablename + " a " +
            " left join t_itemcollection b on b.itemvalue=a.type and b.itemtype='DeviceType' " +
            " left join t_position c on c.id=a.position where 1=1 ";
            if (key != "")
            {
                sql += " and  a.name like '%" + key + "%' ";
            }
            if (position != "全部")
            {
                sql += " and  c.position='" + position + "' ";
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

        public DAO.DeviceDao selectDeviceInfoWithID(string id)
        {

            string tablename = "t_device";

            string sql = "select a.id,a.name,b.itemname as devicetype,a.code,a.netaddress,c.position as position" +
            " from " + tablename + " a " +
            " left join t_itemcollection b on b.itemvalue=a.type and b.itemtype='DeviceType' " +
            " left join t_position c on c.id=a.position where a.id="+id+" ";

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DAO.DeviceDao dao = new DAO.DeviceDao();

                dao.Devicename = _dt.Rows[0]["name"].ToString();
                dao.Devicetype = _dt.Rows[0]["devicetype"].ToString();
                dao.Code = _dt.Rows[0]["code"].ToString();
                dao.Netaddress = _dt.Rows[0]["netaddress"].ToString();
                dao.Deviceposition = _dt.Rows[0]["position"].ToString();
                
                return dao; 
            }
        }

        public string  getdeviceaddressWithpositionname(string positionname)
        {
            string sql = "select netaddress from t_device where `position` in (select id from t_position where `position`='" + positionname + "') and type=0";
         
            DataTable _dt=this.SelectQuery(sql);

            if(_dt!=null&&_dt.Rows.Count>0)
                return _dt.Rows[0][0].ToString();
            else
                return "";
        }

        public DAO.DeviceDao selectDeviceInfoWithIP(string ip)
        {

            string tablename = "t_device";

            string sql = "select a.id,a.name,b.itemname as devicetype,a.code,a.netaddress,c.position as position" +
            " from " + tablename + " a " +
            " left join t_itemcollection b on b.itemvalue=a.type and b.itemtype='DeviceType' " +
            " left join t_position c on c.id=a.position where a.netaddress='" + ip + "' ";

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DAO.DeviceDao dao = new DAO.DeviceDao();

                dao.Devicename = _dt.Rows[0]["name"].ToString();
                dao.Devicetype = _dt.Rows[0]["devicetype"].ToString();
                dao.Code = _dt.Rows[0]["code"].ToString();
                dao.Netaddress = _dt.Rows[0]["netaddress"].ToString();
                dao.Deviceposition = _dt.Rows[0]["position"].ToString();

                return dao;
            }
        }

        public DataTable GetDeviceTypeList()
        {
            string tablename = "t_itemcollection";

            string sql = "select a.itemname" +
            " from " + tablename + " a where itemtype='DeviceType' ";

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

     
        public bool deleteDeviceWithId(string id)
        {
            string sql = "delete from t_device " +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool insertDeviceInfo(DAO.DeviceDao dao)
        {
            string sql = "insert into t_device(`name`,type,code,netaddress,position) values " +
            " ('" + dao.Devicename + "',(Select itemvalue from t_itemcollection where Itemname='" + dao.Devicetype + "' limit 0,1),'" + dao.Code + "','" + dao.Netaddress + "',(Select id from t_position where position='" + dao.Deviceposition + "' limit 0,1)) ";

            return this.InsertQuery(sql);
        }

        public bool updateDeviceInfo(string id, DAO.DeviceDao dao)
        {
            string sql = "update t_device set `name`='" + dao.Devicename + "',type=(Select itemvalue from t_itemcollection where Itemname='" + dao.Devicetype + "' limit 0,1),code='" + dao.Code + "',netaddress='" + dao.Netaddress + "',position=(Select id from t_position where position='" + dao.Deviceposition + "' limit 0,1) where id="+id+" ";

            return this.updateQuery(sql);
        }
    }
}
