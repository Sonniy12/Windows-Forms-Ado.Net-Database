using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;


namespace Filmography
{
    public partial class Page_programmer : Form
    {
        DataSet Save = new DataSet();
        SqlDataAdapter adapter;
        SqlConnection connection;
        SqlCommandBuilder Builder;
        DataSet data_set = new DataSet();//хранилище таблиц
        public Page_programmer()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");
          
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"select* from " + textBox1.Text + "", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                data_set.Clear();// оистка 

                adapter.Fill(data_set);//вытащить данные метод Fill
                dataGridView1.DataSource = data_set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите верное название таблицы !");
                //throw;
            } 
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            connection.Close();
        }

        private void Home_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"select* from " + textBox1.Text + "", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter); 
                adapter.Update(data_set);//изменить данные метод Update                                                            //  ds.Clear();// оистка 
            }
            catch (Exception ex)
            { MessageBox.Show("Введите верное название таблицы !"); }
        }
    }
}

