using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_VehicleInfo:DAL_Common
    {
        public DataTable selectVehicleInfoWithGroupAndKey(string key, string groupName)
        {
            string tablename = "t_vehicle";

            string sql = "select a.id,a.vehicle_num,b.name as vehiclename,a.vehicle_kind as vehiclekind" +
            " from " + tablename + " a " +
            " left join t_passenger b on b.id=a.vehicle_owner "+
            " left join t_pg_binding tpg on tpg.passengerid=b.id " +
            " left join t_group tg on tg.id=tpg.groupid " +
            " left join t_itemcollection ti on ti.itemvalue=a.is_temp and itemtype='CustomerType' where 1=1 ";
         
            if (key != "")
            {
                sql += " and (a.vehicle_num='" + key + "' or b.name='" + key + "' ) ";
            }
            if (groupName != "全部")
            {
                sql += " and  tg.groupname='" + groupName + "' ";
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

        public DAO.VehicleInfoDao selectVehicleInfoID(string id)
        {

            string tablename = "t_vehicle";

            string sql = "select a.id,a.vehicle_num,b.name as vehicleownername,a.vehicle_grand,a.vehicle_kind,a.vehicle_color,c.groupname " +
              " from " + tablename + " a " +
              " left join t_passenger b on b.id=a.vehicle_owner " +
              " left join t_group c on c.id=b.group where a.id="+id+" ";

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DAO.VehicleInfoDao dao = new DAO.VehicleInfoDao();

                dao.Vehiclenum = _dt.Rows[0]["vehicle_num"].ToString();
                dao.Vehicleowner = _dt.Rows[0]["vehicleownername"].ToString();
                dao.Vehiclegrand = _dt.Rows[0]["vehicle_grand"].ToString();
                dao.Vehiclekind = _dt.Rows[0]["vehicle_kind"].ToString();
                dao.Vehiclecolor= _dt.Rows[0]["vehicle_color"].ToString();
                return dao;
            }
        }


        public bool deleteVehicleWithId(string id)
        {
            string sql = "delete from t_vehicle" +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool insertVehicleInfo(DAO.VehicleInfoDao dao)
        {
            string sql = "insert into t_vehicle(vehicle_num,vehicle_owner,vehicle_grand,vehicle_kind,vehicle_color,is_temp) values " +
            " ('" + dao.Vehiclenum + "'," + dao.Vehicleowner + ",'" + dao.Vehiclegrand + "','" + dao.Vehiclekind + "','" + dao.Vehiclecolor + "',"+dao.Istemp+") ";

            return this.InsertQuery(sql);
        }

        public bool updateCustomerInfo(string id, DAO.CustomerDao dao)
        {
            string sql = "update t_passenger set name='" + dao.Sex + "',sex='" + dao.Sex + "',nation='" + dao.Sex + "',job='" + dao.Sex + "',idcard='" + dao.Sex + "',address='" + dao.Address + "',rfid='" + dao.Sex + "',group='" + dao.Sex + "',remark='" + dao.Sex + "'',is_temp="+dao.Istemp+" where id=" + id + "  ";
            return this.updateQuery(sql);
        }

    }
}
