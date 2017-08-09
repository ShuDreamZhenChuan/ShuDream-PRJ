using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_Log:DAL_Common
    {
        public void  Inster_Log(string logevent,int eventtype,int eventposition,string subject,int timestamp,DateTime time,string desc)
        {
            try
            {
                string insertsql = "Insert into t_log (logevent,logeventtype,logeventposition,logsubject,logtimestamp,logtime,logdesc) values('" + logevent + "',"+eventtype+","+eventposition+",'" + subject + "'," + timestamp + ",'" + time.ToString() + "','" + desc + "')";

                this.InsertQuery(insertsql);
            }
            catch (Exception ex)
            { 
                
            
            }
        }

        public DataTable search_PassengerLog(string eventposition,string startTime, string endtime,string searchkey)
        {
            try
            {
                
                string selectsql = "Select tpa.name as logname,tp.position as positionname,tl.logtime,tl.logdesc from t_log tl " +
                    " left join t_position tp on tp.id=tl.logeventposition " +
                    " left join t_passenger tpa on (tpa.idcard=tl.logsubject or tpa.rfid=tl.logsubject) "+
                    " where tl.logtime between '" + startTime + "' and '" + endtime + "' and (tl.logeventtype=0 or tl.logeventtype=1) ";
                
                if (eventposition != "")
                {
                    selectsql += " and tp.position='" + eventposition + "' ";
                }
                if (searchkey != "")
                {
                    selectsql += " and tl.logsubject='" + searchkey + "' ";
                }

                selectsql += " order by tl.logtimestamp desc";

                DataTable _dt = this.SelectQuery(selectsql);
                if (_dt == null)
                {
                    return null;
                }
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
         public DataTable search_vehicleLog(string eventposition,string startTime, string endtime,string searchkey)
        {
            try
            {
                string selectsql = "Select tl.logsubject,tl.logtime,tl.logdesc,tp.position as positionname,tpa.name as vehicleowner from t_log tl " +
                    " left join t_position tp on tp.id=tl.logeventposition " +
                    " left join t_vehicle tv on tv.vehicle_num=tl.logsubject " +
                    " left join t_passenger tpa on tpa.id=tv.vehicle_owner "+
                    " where tl.logtime between '" + startTime + "' and '" + endtime + "' and (tl.logeventtype=2 or tl.logeventtype=3)";
                if (eventposition != "")
                {
                    selectsql += " and tp.position='" + eventposition + "' ";
                }
                if (searchkey != "")
                {
                    selectsql += " and tl.logsubject='" + searchkey + "' ";
                }

                selectsql += " order by tl.logtimestamp desc";

                DataTable _dt = this.SelectQuery(selectsql);
                if (_dt == null)
                {
                    return null;
                }
                else
                    return _dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

         public DataTable search_vehicleLogDetailWithLogType(string eventposition, string startTime, string endtime, string searchkey,string logtype)
         {
             try
             {
                 string selectsql = "Select tl.id,tl.logtime,tl.logdesc,tp.position as positionname,tpa.name as vehicleowner,tv.vehicle_kind as vehiclekind from t_log tl " +
                     " left join t_position tp on tp.id=tl.logeventposition " +
                     " left join t_vehicle tv on tv.vehicle_num=tl.logsubject " +
                     " left join t_passenger tpa on tpa.id=tv.vehicle_owner " +
                     " where tl.logtime between '" + startTime + "' and '" + endtime + "' and tl.logeventtype=" + logtype + " ";
                 if (eventposition != "")
                 {
                     selectsql += " and tp.position='" + eventposition + "' ";
                 }
                 if (searchkey != "")
                 {
                     selectsql += " and tl.logsubject='" + searchkey + "' ";
                 }

                 selectsql += " order by tl.logtimestamp desc ";

                 DataTable _dt = this.SelectQuery(selectsql);
                 if (_dt == null)
                 {
                     return null;
                 }
                 else
                     return _dt;
             }
             catch (Exception ex)
             {
                 return null;
             }
         }

         public DataTable getLogVehicleReport(string startTime, string endtime, string reportway)
         {
             string reportsql = "";
             if (reportway == "车辆")
             {
                 reportsql = "SELECT b.logsubject as reportitem,COUNT(CASE WHEN b.logeventtype=2 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=3 THEN 1 ELSE NULL END ) AS outcount FROM t_log b WHERE logeventtype=2 OR logeventtype=3 GROUP BY b.logsubject";
             }
             if (reportway == "位置")
             {
                 reportsql = "SELECT tp.`position` as reportitem,COUNT(CASE WHEN b.logeventtype=2 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=3 THEN 1 ELSE NULL END ) AS outcount FROM t_log b" +
                 " LEFT JOIN t_position tp ON tp.`id`=b.`logeventposition` " +
                 " WHERE logeventtype=2 OR logeventtype=3 GROUP BY b.`logeventposition` ";
             }
             if (reportway == "年")
             {
                 reportsql = "SELECT DATE_FORMAT(logtime, '%Y')AS reportitem,COUNT(CASE WHEN b.logeventtype=2 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=3 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=2 OR b.`logeventtype`=3   GROUP BY DATE_FORMAT(logtime, '%Y')";
             }
             if (reportway == "月")
             {
                 reportsql = "SELECT DATE_FORMAT(logtime, '%Y-%m')AS reportitem,COUNT(CASE WHEN b.logeventtype=2 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=3 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=2 OR b.`logeventtype`=3   GROUP BY DATE_FORMAT(logtime, '%Y-%m')";
             }
             if (reportway == "日")
             {
                 reportsql = "SELECT DATE_FORMAT(logtime, '%Y-%m-%d')AS reportitem,COUNT(CASE WHEN b.logeventtype=2 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=3 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=2 OR b.`logeventtype`=3   GROUP BY DATE_FORMAT(logtime, '%Y-%m-%d')";
             }

             DataTable _dt = this.SelectQuery(reportsql);

             if (_dt.Rows.Count <= 0)
             {
                 return null;
             }

             reportsql = "SELECT COUNT(CASE WHEN b.logeventtype=2 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=3 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=2 OR b.`logeventtype`=3";

             DataTable _sumdt = this.SelectQuery(reportsql);

             if (_sumdt.Rows.Count <= 0)
             {
                 return null;
             }

             DataRow _row = _dt.NewRow();

             _row["reportitem"] = "汇总";
             _row["incount"] = Convert.ToInt32(_sumdt.Rows[0][0]);
             _row["outcount"] = Convert.ToInt32(_sumdt.Rows[0][1]);

             _dt.Rows.Add(_row);

             return _dt;
         }

         public DataTable getLogPassengerReport(string startTime, string endtime, string reportway)
         {
             string reportsql = "";
             if (reportway == "人员")
             {
                 reportsql = "SELECT tp.`name` as reportitem,COUNT(CASE WHEN b.logeventtype=0 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=1 THEN 1 ELSE NULL END ) AS outcount FROM t_log b "+
                 " LEFT JOIN t_passenger tp ON tp.idcard=b.logsubject or tp.rfid=b.logsubject " +
                 " WHERE logeventtype=0 OR logeventtype=1 GROUP BY tp.`name`";
             }
             if (reportway == "位置")
             {
                 reportsql = "SELECT tp.`position` as reportitem,COUNT(CASE WHEN b.logeventtype=0 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=1 THEN 1 ELSE NULL END ) AS outcount FROM t_log b" +
                 " LEFT JOIN t_position tp ON tp.`id`=b.`logeventposition` " +
                 " WHERE logeventtype=0 OR logeventtype=1 GROUP BY b.`logeventposition` ";
             }
             if (reportway == "年")
             {
                 reportsql = "SELECT DATE_FORMAT(logtime, '%Y')AS reportitem,COUNT(CASE WHEN b.logeventtype=0 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=1 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=0 OR b.`logeventtype`=1   GROUP BY DATE_FORMAT(logtime, '%Y')";
             }
             if (reportway == "月")
             {
                 reportsql = "SELECT DATE_FORMAT(logtime, '%Y-%m')AS reportitem,COUNT(CASE WHEN b.logeventtype=0 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=1 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=0 OR b.`logeventtype`=1   GROUP BY DATE_FORMAT(logtime, '%Y-%m')";
             }
             if (reportway == "日")
             {
                 reportsql = "SELECT DATE_FORMAT(logtime, '%Y-%m-%d')AS reportitem,COUNT(CASE WHEN b.logeventtype=0 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=1 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=0 OR b.`logeventtype`=1   GROUP BY DATE_FORMAT(logtime, '%Y-%m-%d')";
             }

             DataTable _dt = this.SelectQuery(reportsql);

             if (_dt.Rows.Count <= 0)
             {
                 return null;
             }

             reportsql = "SELECT COUNT(CASE WHEN b.logeventtype=0 THEN 1 ELSE NULL END ) AS incount,COUNT(CASE WHEN b.logeventtype=1 THEN 1 ELSE NULL END ) AS outcount  FROM t_log b WHERE b.`logeventtype`=0 OR b.`logeventtype`=1";

             DataTable _sumdt = this.SelectQuery(reportsql);

             if (_sumdt.Rows.Count <= 0)
             {
                 return null;
             }

             DataRow _row = _dt.NewRow();

             _row["reportitem"] = "汇总";
             _row["incount"] = Convert.ToInt32(_sumdt.Rows[0][0]);
             _row["outcount"] = Convert.ToInt32(_sumdt.Rows[0][1]);

             _dt.Rows.Add(_row);

             return _dt;
         }








    }
}
