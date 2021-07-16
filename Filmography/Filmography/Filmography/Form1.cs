using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace Filmography
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
      
        SqlCommand command;
  

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");

            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  string select = @"select* from Film;";
            // command = new SqlCommand(select, connection);//подкл к базе данных

            command = new SqlCommand(@" select* from Film where ID>0 ORDER BY ID;", connection);
            SqlDataReader sqlData = command.ExecuteReader(); //откр 



            listBox1.Items.Clear();
            try
            {
                while (sqlData.Read())
                {

                    string res = "";

                    for (int i = 0; i < sqlData.FieldCount; i++)//вывод данныхиз стобцов
                    {

                        res += " " + sqlData.GetValue(i) + "\t" + "\n";


                    }


                    listBox1.Items.Add(res);


                }
                connection.Close();
            }
            catch (Exception)
            {

                //throw;
            }
            finally { connection.Open(); }
          
          
              

       


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Sorting sort = new Sorting();
            sort.ShowDialog();
            
               
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            connection.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

      
    }
}
