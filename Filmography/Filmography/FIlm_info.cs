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

namespace Filmography
{
    public partial class FIlm_info : Form
    {
         string text = "";
       
        SqlConnection connection;
        public FIlm_info()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data source=DESKTOP-550GBFP\SQLEXPRESS;Initial Catalog=Filmography; Integrated Security=SSPI");
            //  button1.BackColor = Color.Black;
          
        }
      
        public PictureBox Picture {
            get
            {
                return pictureBox1;


            }

            set
            {
                pictureBox1 = value;
            } }
        public PictureBox Picture2
        {
            get
            {
                return pictureBox2;


            }

            set
            {
                pictureBox2 = value;
            }
        }




        public string Info
        {
            get
            {
                return label1.Text;


            }

            set
            {
               label1.Text = value;
            }
        }

        public ListBox _List
        {

            set => listBox1 = value;
            get => listBox1;
        }

        public string Save
        {

            set => text = value;
            get => text;
        }
        public string Save2
        {

            set => text = value;
            get => text;
        }


        private void FIlm_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save = "";
            Save2 = "";

            label1.Text = "";
            listBox1.Items.Clear();
       

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            


        }

      
    }
    }

