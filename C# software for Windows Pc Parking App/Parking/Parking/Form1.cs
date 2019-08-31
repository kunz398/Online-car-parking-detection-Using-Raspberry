using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

using System.Drawing;




namespace Parking
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlConnection conn2;
        string connString;
     //Start here ->>>>>>>>>
        private void Form1_Load(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/23137073/refresh-the-form-every-second
            Timer timer = new Timer();
            timer.Interval = 2000; //2
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            connString = "SERVER=johnny.heliohost.org;PORT=3306;DATABASE=ENTERDB;UID=ENTERUSERNAME;PASSWORD=ENTERPASSWORD;";
            //connString = "SERVER=localhost;PORT=3306;DATABASE=parking1_parking;UID=root;PASSWORD=;";

            try
            {
                // MessageBox.Show("SUCCESS!!");
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                
                string query = "SELECT * FROM parkinglot WHERE parked = 1";                
                MySqlCommand cmd = new MySqlCommand(query, conn);//create command
                MySqlDataReader dataReader = cmd.ExecuteReader();//create a db reader and execute the command            
                
                //read the data and store them in a list
                while (dataReader.Read())
                {
                    string id = dataReader["id"].ToString();
                    string location = dataReader["location"].ToString();
                    string parked = dataReader["parked"].ToString();

                    Label lbls = (Label)this.Controls.Find(location, false).FirstOrDefault(); //find the label name which is location
                    //string lblstr = lbls.ToString();
                    //string checklbl = lblstr.Substring(Math.Max(0, lblstr.Length - 2)); //sub-stringing it to get the last 2 characters
                    lbls.BackColor = Color.Red;               
                }
                conn.Close(); //closing connection 1

                conn2 = new MySqlConnection();
                conn2.ConnectionString = connString;
                conn2.Open();
                string query2 = "SELECT * FROM parkinglot WHERE parked = 0";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn2);
                dataReader = cmd2.ExecuteReader();

                while (dataReader.Read())
                {
                    string location = dataReader["location"].ToString();
                    Label lbls = (Label)this.Controls.Find(location, false).FirstOrDefault();
                    lbls.BackColor = Color.Blue;
                }
                conn2.Close();// closing connection 2               
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("YOU ARE A LOSER!!" + ex);
            }
        }
        //END here <<<<<--
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblA1_Click(object sender, EventArgs e)
        {

        }
    }
}
