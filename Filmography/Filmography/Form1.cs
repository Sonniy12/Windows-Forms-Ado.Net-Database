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
using System.IO;
using System.Drawing.Imaging;
    

/// <summary>
/// Приложение подобие онлайна-кинотеатра IVI
/// </summary>

namespace Filmography
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Form form2 = new Form();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;





        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start_page start = new Start_page();
            start.ShowDialog();
        }



        //---------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
          

          


        }

        //-----------------------------------
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

       
    }
}
