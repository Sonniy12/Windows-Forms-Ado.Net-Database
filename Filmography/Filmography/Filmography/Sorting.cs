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
    public partial class Sorting : Form
    {
        SqlConnection connection;

        SqlCommand command;

       
      //  string res1 = "";
      
        public Sorting()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");

            connection.Open();
        }
       // public string Result1 { get => res1; }
    

        private void button1_Click(object sender, EventArgs e)
        {

         

            command = new SqlCommand(@" select* from Film where ID>0 ORDER BY Year_of_issue;", connection);
            SqlDataReader sqlData = command.ExecuteReader(); //откр 
            listBox1.Items.Clear();
                
                    
            try
            {

                while (sqlData.Read())
                {
                  
                    string res1 = "";

                    for (int i = 0; i < sqlData.FieldCount; i++)//вывод данныхиз стобцов
                    {

                        res1 += " " + sqlData.GetValue(i) +"\t " ;


                    }


                    listBox1.Items.Add(res1);


                }
                connection.Close();
               // listBox1.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Нажмите кнопку Close");
                //throw; 
            }
            finally {   connection.Open(); }    


           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            command = new SqlCommand(@" select* from Film where ID>0  ORDER BY Name ;", connection);
            SqlDataReader sqlData = command.ExecuteReader(); //откр 

            listBox1.Items.Clear();

            try
            {
                while (sqlData.Read())
                {
                    string res1 = "";


                    for (int i = 0; i < sqlData.FieldCount; i++)//вывод данныхиз стобцов
                    {

                        res1 += " " + sqlData.GetValue(i) + "\t" + "\n";


                    }


                    listBox1.Items.Add(res1);


                }
                connection.Close();
            }
            catch (Exception)
            {

                //throw;
            }
            finally { connection.Open(); }


        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            command = new SqlCommand(@" select* from Film where ID>0  ORDER BY Cost_per_film ;", connection);
            SqlDataReader sqlData = command.ExecuteReader(); //откр 
            listBox1.Items.Clear();

            try
            {

                while (sqlData.Read())
                {

                    string res1 = "";

                    for (int i = 0; i < sqlData.FieldCount; i++)//вывод данныхиз стобцов
                    {

                        res1 += " " + sqlData.GetValue(i) + "\t" + "\n";


                    }


                    listBox1.Items.Add(res1);


                }
                connection.Close();
            }
            catch (Exception)
            {

               // throw;
            }
            finally { connection.Open(); }


        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            command = new SqlCommand(@" select* from Film where ID>0  ORDER BY Country_of_issue ;", connection);
            SqlDataReader sqlData = command.ExecuteReader(); //откр 
            listBox1.Items.Clear();

            try
            {
                while (sqlData.Read())
                {
                    string res1 = "";


                    for (int i = 0; i < sqlData.FieldCount; i++)//вывод данныхиз стобцов
                    {

                        res1 += " " + sqlData.GetValue(i) + "\t" + "\n";


                    }


                    listBox1.Items.Add(res1);


                }
                connection.Close();
            }
            catch (Exception)
            {

               // throw;
            }
            finally { connection.Open(); }



        }
        private void button6_Click(object sender, EventArgs e)
        {
            command = new SqlCommand(@" select* from Film where ID>0  ORDER BY Genre ;", connection);
            SqlDataReader sqlData = command.ExecuteReader(); //откр 
            listBox1.Items.Clear();

            try
            {
                while (sqlData.Read())
                {
                    string res1 = "";


                    for (int i = 0; i < sqlData.FieldCount; i++)//вывод данныхиз стобцов
                    {

                        res1 += " " + sqlData.GetValue(i) + "\t" + "\n";


                    }


                    listBox1.Items.Add(res1);


                }

                 connection.Close();
            }
            catch (Exception)
            {

                //throw;
            }
            finally { connection.Open(); }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            connection.Close();
        }

        private void Sorting_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

      
    }
}
