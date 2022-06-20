using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LevelDatabase
{
    public class DBConnection
    {
        //Connection with Database (For now, In SQL Server LocalDB)
        #region "PATRON SINGLETON"
        public static DBConnection connection = null;
        private DBConnection() { }

        public static DBConnection GetInstance()
        {
            if (connection == null)
            {
                connection = new DBConnection();
            }
            return connection;
        }
        #endregion

        public SqlConnection ConnectionDB()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";
            return connection;
        }

    }

}
