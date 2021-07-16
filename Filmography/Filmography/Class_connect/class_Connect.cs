using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Data.SqlClient;
/// <summary>
/// /реализованн паттерн одиночка для подключения к БД
/// </summary>
namespace Filmography.Class_connect
{
    class class_Connect
    {
        
        private SqlConnection connection;
        public SqlConnection Connection { get; set; }

        static private class_Connect obj;
        public string Path_date_base { get; private set; }
        protected class_Connect(string path)
        {
            this.Path_date_base = path;
            connection = new SqlConnection(Path_date_base); //path date base
            Connection = connection;

        }
        public static class_Connect Get_connect(string path)
        {
            if (obj==null)
            {
                obj = new class_Connect(path);
            }
            return obj;
        }
        public void Open_connect() //open connect date base
        {
            Connection.Open();
        }
        public void Close_connect()//close connect date base
        {
            Connection.Close();
        }



    }
}
