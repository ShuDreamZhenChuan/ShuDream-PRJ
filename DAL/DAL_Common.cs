using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Common
    {
        SqlHelper sqlhelper;

        public DAL_Common()
        {
            sqlhelper = new SqlHelper(SqlHelper.globeSqlConnString);
        }

        public DataTable SelectQuery(string sqlstring)
        {
            try
            {
                DataTable _dt = new DataTable();
                sqlhelper.OpenConn();
                sqlhelper._adapter.SelectCommand.CommandText = sqlstring;
                sqlhelper._adapter.Fill(_dt);
                sqlhelper.CloseConn();
                return _dt;
            }
            catch (Exception ex)
            {
                sqlhelper.CloseConn();
                return null;
            }
        }

        public bool InsertQuery(string sqlstring)
        {
            try
            {
                sqlhelper.OpenConn();
                sqlhelper._comm.CommandText = sqlstring;
                if (sqlhelper._comm.ExecuteNonQuery() > 0) 
                {
                    sqlhelper.CloseConn();
                    return true;
                }
                else
                {
                    sqlhelper.CloseConn();
                    return false;
                }
            }
            catch (Exception ex)
            {
                sqlhelper.CloseConn();
                return false;
            }
        }

        public bool DeleteQuery(string sqlstring)
        {
            try
            {
                sqlhelper.OpenConn();
                sqlhelper._comm.CommandText = sqlstring;
                if (sqlhelper._comm.ExecuteNonQuery() > 0)
                {
                    sqlhelper.CloseConn();
                    return true;
                }
                else
                {
                    sqlhelper.CloseConn();
                    return false;
                }
            }
            catch (Exception ex)
            {
                sqlhelper.CloseConn();
                return false;
            }
        }

        public bool updateQuery(string sqlstring)
        {
            try
            {
                sqlhelper.OpenConn();
                sqlhelper._comm.CommandText = sqlstring;
                if (sqlhelper._comm.ExecuteNonQuery() > 0)
                {
                    sqlhelper.CloseConn();
                    return true;
                }
                else
                {
                    sqlhelper.CloseConn();
                    return false;
                }
            }
            catch (Exception ex)
            {
                sqlhelper.CloseConn();
                return false;
            }
        }


    }
}
