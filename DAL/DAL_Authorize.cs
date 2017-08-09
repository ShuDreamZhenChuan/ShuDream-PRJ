using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Authorize:DAL_Common
    {
        public bool CheckPassengerWithDevice(string passengerid,string deviceIP)
        {

            DataTable _dt = new DataTable();
            string sql="select a.id from t_gd_binding a "+
                " left join t_group tg on tg.id=a.groupid " +
                " left join t_pg_binding tpg on tpg.groupid=a.groupid "+
                " left join t_passenger tp on tp.id=tpg.passengerid "+
                " left join t_device td on td.id=a.deviceid "+
                " where (tp.idcard='" + passengerid + "' or tp.rfid='" + passengerid + "') and td.netaddress='" + deviceIP + "' ";
            _dt=this.SelectQuery(sql);

            if (_dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool CheckVehicleInfoWithDevice(string vehiclenum,string vehicleowner,string deviceIP)
        {

            DataTable _dt = new DataTable(); 
          
            string sql = "select a.id from t_gd_binding a "+
                " left join t_group tg on tg.id=a.groupid " +
                " left join t_pg_binding tpg on tpg.groupid=a.groupid " +
                " left join t_passenger tp on tp.id=tpg.passengerid " +
                " left join t_vehicle tv on tv.vehicle_owner=tp.id " +
                " left join t_device td on td.id=a.deviceid  where 1=1 ";
                if(vehicleowner!="")
                {
                    sql += " and (tp.idcard='" + vehicleowner + "' or tp.rfid='" + vehicleowner + "') ";
                }
                sql += " and tv.vehicle_num='" + vehiclenum + "' and td.netaddress='" + deviceIP + "' ";
           
            _dt = this.SelectQuery(sql);

            if (_dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public DataTable GetCustomerAuthorize(string id)
        {
            try
            {
                string sql = "select a.id,b.`name` as devicename,c.itemname as devicetype,a.authorizeendtime " +
                    " from t_pd_binding a " +
                    " left join t_device b on b.id=a.device_id " +
                    " left join t_itemcollection c on c.itemvalue=b.type and c.itemtype='DeviceType' " +
                    " where a.passenger_id=" + id + " ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }



        public DataTable GetVehicleAuthorize(string id)
        {
            try
            {
                string sql = "select a.id,b.`name` as devicename,c.itemname as devicetype,a.authorizeendtime " +
                    " from t_vd_binding a " +
                    " left join t_device b on b.id=a.device_id " +
                    " left join t_itemcollection c on c.itemvalue=b.type and c.itemtype='DeviceType' " +
                    " where a.vehicle_id=" + id + " ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetGroupAuthorize(string id)
        {
            try
            {
                string sql = "select a.id,b.`name` as devicename,c.itemname as devicetype,a.authorizeendtime " +
                    " from t_gd_binding a " +
                    " left join t_device b on b.id=a.deviceid " +
                    " left join t_itemcollection c on c.itemvalue=b.type and c.itemtype='DeviceType' " +
                    " where a.groupid=" + id + " ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetCutomerNotHaveAuthrize(string id)
        {
            try
            {
                string sql = "select a.id,a.`name` as devicename,c.itemname as devicetype " +
                    " from t_device a " +
                    " left join t_itemcollection c on c.itemvalue=a.type and c.itemtype='DeviceType' " +
                    " left join t_position tp on tp.id=a.position " +
                    " where a.id not in (Select device_id from t_pd_binding where t_pd_binding.passenger_id=" + id + " ) and tp.positiontype=1 ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt==null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetVehicleNotHaveAuthrize(string id)
        {
            try
            {
                string sql = "select a.id,a.`name` as devicename,c.itemname as devicetype " +
                    " from t_device a " +
                    " left join t_itemcollection c on c.itemvalue=a.type and c.itemtype='DeviceType' " +
                    " left join t_position tp on tp.id=a.position " +
                    " where a.id not in (Select device_id from t_vd_binding where t_vd_binding.vehicle_id=" + id + " ) and tp.positiontype=2  ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetGroupNotHaveAuthrize(string id)
        {
            try
            {
                string sql = "select a.id,a.`name` as devicename,c.itemname as devicetype " +
                    " from t_device a " +
                    " left join t_itemcollection c on c.itemvalue=a.type and c.itemtype='DeviceType' " +
                    " left join t_position tp on tp.id=a.position " +
                    " where a.id not in (Select deviceid from t_gd_binding where t_gd_binding.groupid=" + id + " ) ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool InsertCustomerAuthrize(string passengerid,string deviceid,string authorizeendtime)
        {
            if (authorizeendtime == "")
                authorizeendtime = "NULL";
            else
                authorizeendtime = "'" + authorizeendtime + "'";
            try
            {
                string sql = " insert into t_pd_binding (passenger_id,device_id,authorizeendtime) values(" + passengerid + "," + deviceid + ","+authorizeendtime +") ";

                return this.InsertQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool InsertGroupAuthrize(string groupid, string deviceid, string authorizeendtime)
        {
            if (authorizeendtime == "")
                authorizeendtime = "NULL";
            else
                authorizeendtime = "'" + authorizeendtime + "'";
            try
            {
                string sql = " insert into t_gd_binding (groupid,deviceid,authorizeendtime) values(" + groupid + "," + deviceid + "," + authorizeendtime + ") ";

                return this.InsertQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool updateCustomerAuthrizeTime(string Authrizeid, string datetime)
        {
            try
            {
                string sql = " update t_pd_binding set authorizeendtime='" + datetime + "' where id=" + Authrizeid + " ";

                return this.updateQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool updateGroupAuthrizeTime(string Authrizeid, string datetime)
        {
            try
            {
                string sql = " update t_gd_binding set authorizeendtime='" + datetime + "' where id=" + Authrizeid + " ";

                return this.updateQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool DeleteCustomerAuthrize(string Authrizeid)
        {
            try
            {
                string sql = "Delete from t_pd_binding where id=" + Authrizeid + " ";

                return this.DeleteQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteGroupAuthrize(string Authrizeid)
        {
            try
            {
                string sql = "Delete from t_gd_binding where id=" + Authrizeid + " ";

                return this.DeleteQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool InsertVehicleAuthrize(string vehicleid, string deviceid, string authorizeendtime)
        {
            if (authorizeendtime == "")                                             
                authorizeendtime = "NULL";
            else
                authorizeendtime = "'" + authorizeendtime + "'";
            try
            {
                string sql = " insert into t_vd_binding (vehicle_id,device_id,authorizeendtime) values(" + vehicleid + "," + deviceid + "," + authorizeendtime + ") ";

                return this.InsertQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateVehicleAuthrizeTime(string Authrizeid, string datetime)
        {
            try
            {
                string sql = " update t_vd_binding set authorizeendtime='" + datetime + "' where id=" + Authrizeid + " ";

                return this.updateQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteVehicleAuthrize(string Authrizeid)
        {
            try
            {
                string sql = "Delete from t_vd_binding where id=" + Authrizeid + " ";

                return this.DeleteQuery(sql);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetDevicePassengerAuthorize(string id,string key)
        {
            try
            {
                string sql = "select a.id,b.`name` as passengername,b.rfid,b.idcard " +
                    " from t_pd_binding a " +
                    " left join t_passenger b on b.id=a.passenger_id " +
                    " where a.device_id=" + id + " ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetDeviceGroupAuthorize(string id)
        {
            try
            {
                string sql = "select a.id,b.groupname AS groupname,pg.groupcount " +
                    " from t_gd_binding a " +
                    " LEFT JOIN t_group b ON b.id=a.groupid " +
                    " LEFT JOIN (SELECT t_pg_binding.`groupid`,COUNT(*) AS groupcount FROM t_pg_binding GROUP BY groupid) pg ON pg.groupid=b.id " +
                    " WHERE a.deviceid="+id+" ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetDevcieCanRelationGroup(string id)
        {
            try
            {
                string sql = "select a.id,a.groupname,pg.groupcount " +
                    " from t_group a " +
                    " LEFT JOIN (SELECT t_pg_binding.`groupid`,COUNT(*) AS groupcount FROM t_pg_binding GROUP BY groupid) pg ON pg.groupid=a.id " +
                    " where a.id not in (Select groupid from t_gd_binding where t_gd_binding.deviceid=" + id + " )";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }






        public DataTable GetDeviceVehicleAuthorize(string id, string key)
        {
            try
            {
                string sql = "select a.id,b.`vehicle_num` as vehiclenum,b.vehice_type as vehicletype,c.`name` as vehicleowner" +
                    " from t_vd_binding a " +
                    " left join t_vehicle b on b.id=a.vehicle_id " +
                    " left join t_passenger c on c.id=b.vehicle_owner " +
                    " where a.device_id=" + id + " ";

                DataTable _dt = this.SelectQuery(sql);

                if (_dt == null)
                    return null;
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
