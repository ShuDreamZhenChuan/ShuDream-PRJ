using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_Group:DAL_Common
    {
        public DataTable selectGroupListInfo()
        {

            string tablename = "t_group";

            string sql = "select a.id,a.groupname " +
            " from " + tablename + " a where 1=1 ";
        
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

        public DAO.GroupDao selectGroupInfoWithId(string id)
        {
            string tablename = "t_group";

            string sql = "select a.*" +
            " from " + tablename + " a where id="+id+" ";

            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DAO.GroupDao _dao = new DAO.GroupDao();

                _dao.Grouppname = _dt.Rows[0]["groupname"].ToString();
                _dao.Groupmanager = _dt.Rows[0]["groupmanager"].ToString();
                _dao.Managerphone= _dt.Rows[0]["managerphone"].ToString();
                _dao.Describe = _dt.Rows[0]["desc"].ToString();

                return _dao;
            }
        }



        public bool insertGroup(DAL.DAO.GroupDao dao)
        {
            string sql = "insert into t_group (groupname,groupmanager,managerphone,`desc`) " +
                " values('" + dao.Grouppname + "','" + dao.Groupmanager + "','" + dao.Managerphone + "','" + dao.Describe + "')";

            return this.InsertQuery(sql);
        
        }

        public bool updateGroupInfo(string id, DAO.GroupDao dao)
        {
            string sql = "update t_group set groupname='" + dao.Grouppname + "',groupmanager='"+dao.Groupmanager+"',managerphone='"+dao.Managerphone+"',`desc`='"+dao.Describe+"' where id=" + id + "  ";

            return this.updateQuery(sql);
        }

        public bool deleteGroupWithId(string id)
        {
            string sql = "delete from t_group " +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool deleteCustomerfromGroupWithId(string id)
        {
            string sql = "delete from t_pg_binding " +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool InsertCustomerIntoGroupWithId(string customerid,string groupid)
        {
            string sql = "insert into t_pg_binding(groupid,passengerid) values("+groupid+","+customerid+") "; 

            return this.InsertQuery(sql);
        }

       

        public DataTable SelectCustomerWithGroupid(string groupid)
        {
            string sql = "Select a.id,tp.name as passengername,tp.sex,tp.idcard as idcard from t_pg_binding a " +
                " left join t_group tg on tg.id=a.groupid " +
                " left join t_passenger tp on tp.id=a.passengerid where 1=1 " +
                " and tg.id=" + groupid + " ";

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

    }
}
