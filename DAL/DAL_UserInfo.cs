using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using System.Data;

namespace DAL
{
   public class DAL_UserInfo:DAL_Common 
    {

        public UserInfoDao selectUserInfoWithNameAndPwd(string user, string pwd)
        {

            string tablename = "t_user";

            string sql="select a.*,b.itemname as usertypename,c.groupname as groupname"+ 
            " from "+ tablename+" a "+
            " left join t_itemcollection b on b.itemtype='UserType' and b.itemvalue=a.usertype "+
            " left join t_group c on a.group=c.id "+
            " where name='"+user+"' ";
            if(pwd!="")
            {
                sql+=" and password='"+pwd+"' ";
            }
            DataTable _dt=this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count<=0)
            {
                return null;
            }
            else
            {
                UserInfoDao info = new UserInfoDao();
                
                info.Id=Convert.ToInt32(_dt.Rows[0]["id"].ToString());
                info.Name=_dt.Rows[0]["name"].ToString();
                info.Usertype=_dt.Rows[0]["usertypename"].ToString();
             
                return info;
            }
             
        
        
        }

        public bool checkpwdwithuserid(string id, string pwd)
        {
            string sql = "select * from t_user  where password='" + pwd + "' and id=" + id + " ";

            DataTable _dt=this.SelectQuery(sql);

            if (_dt != null && _dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }


        public bool editpwdwithuserid(string id,string newpwd)
        {
            string sql = "update t_user set password='" + newpwd + "' where id=" + id + " ";

            return this.updateQuery(sql);
        }

        public UserInfoDao selectUserInfoWithId(string id)
        {

            string tablename = "t_user";

            string sql = "select a.*,b.itemname as usertypename,d.itemname as userstatus" +
            " from " + tablename + " a " +
            " left join t_itemcollection b on b.itemtype='UserType' and b.itemvalue=a.usertype " +
            " left join t_itemcollection d on d.itemtype='UserStatus' and d.itemvalue=a.status " +
            " where a.id='" + id + "' ";
            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                UserInfoDao info = new UserInfoDao();

                info.Id = Convert.ToInt32(_dt.Rows[0]["id"].ToString());
                info.Name = _dt.Rows[0]["name"].ToString();
                info.Usertype = _dt.Rows[0]["usertypename"].ToString();
                info.State = _dt.Rows[0]["userstatus"].ToString();
                return info;
            }
        }

        public string selectUserPermissionWithId(string id)
        {

            string tablename = "t_user";

            string sql = "select a.id,b.permissionnames " +
            " from " + tablename + " a " +
            " left join t_userpermission b on b.usertype=a.usertype " +
            " where a.id='" + id + "' ";
            DataTable _dt = this.SelectQuery(sql);
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                return "";
            }
            else
            {
                return _dt.Rows[0][1].ToString();
            }
        }

        public DataTable selectUserInfoListWithKeyAndGroup(string key)
        {

            string tablename = "t_user";

            string sql = "select a.id,a.name as username,b.itemname as usertypename,d.itemname as userstatus" +
            " from " + tablename + " a " +
            " left join t_itemcollection b on b.itemtype='UserType' and b.itemvalue=a.usertype " +
            " left join t_itemcollection d on d.itemtype='UserStatus' and d.itemvalue=a.status "+ 
            " where 1=1 ";
            if (key != "")
            {
                sql += " and a.name like '%" + key + "%' ";
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

        public DataTable checkUserName(string username)
        {

            string tablename = "t_user";

            string sql = "select a.id,a.name as username,b.itemname as usertypename " +
            " from " + tablename + " a " +
            " left join t_itemcollection b on b.itemtype='UserType' and b.itemvalue=a.usertype " +
            " where 1=1 ";
            sql += " and a.name ='" + username + "' ";


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

        public bool deleteUserWithId(string id)
        {
            string sql = "delete from t_user " +
            " where id='" + id + "' ";

            return this.DeleteQuery(sql);
        }

        public bool insertUserInfo(DAO.UserInfoDao dao)
        {
            string sql = "insert into t_user(`name`,`password`,usertype,status) values " +
            " ('" + dao.Name + "','" + dao.Pwd + "',(select itemvalue from t_itemcollection where itemname='" + dao.Usertype + "'),0) ";

            return this.InsertQuery(sql);
        }

        public bool updateUserInfo(string id, DAO.UserInfoDao dao)
        {
            string sql = "update t_user set `name`='" + dao.Name + "',usertype=(select itemvalue from t_itemcollection where itemname='" + dao.Usertype + "'),`status`=(select itemvalue from t_itemcollection where itemname='" + dao.State + "') where id=" + id + "  ";

            return this.updateQuery(sql);
        }

        public DataTable getUserTypeList()
        {
            string sql = "select itemname from t_itemcollection where itemtype='UserType' ";

            return this.SelectQuery(sql);
        }

        public DataTable getUserStatusList()
        {
            string sql = "select itemname from t_itemcollection where itemtype='UserStatus' ";

            return this.SelectQuery(sql);
        }





    }
}
