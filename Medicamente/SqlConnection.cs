
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Medicamente
{
    static class SqlConn
    {
        public static SqlConnection connection = new SqlConnection();

        public static string GetConnectionString()
        {
            return @"Data Source = CIPRI-ASUS\SQLEXPRESS; " +
                    "Initial Catalog = Medicamente_DB; " +
                    "Integrated Security = True; " +
                    "MultipleActiveResultSets = True;";
        }

        public static string myApp()
        {
            return "Medicamente";
        }

        public static void ConnectionState()
        {
            string msg = "Connection state: " + "The connection is ";
            string title = SqlConn.myApp();
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            MessageBox.Show(msg + connection.State.ToString(), title, btn, icon);
        }

        public static void OpenConn()
        {
            connection.Close();
            try
            {
                connection.ConnectionString = SqlConn.GetConnectionString();
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("The sysyem failed to establish a connection." + Environment.NewLine + e);
            }
            //finally
            //{
            //    ConnectionState();
            //}
        }

        public static void CloseConn()
        {
            connection.Close();
            connection.Dispose();
            //ConnectionState();
        }
    }
}
