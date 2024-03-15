using LMS.main;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDev.HtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LMS.teacher
{
    public partial class attendence : Form
    {
        public static attendence instance;
        public Label tb;
        

        dbcon conn = new main.dbcon();
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public attendence()
        {
            InitializeComponent();
            instance = this;
            tb = hide1;
            toD.Value = DateTime.Now;
            fromD.Value = DateTime.UtcNow.Date.AddDays(-3000);
            atten();
        }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            atten();
        }

        public void atten()
        {
            System.Threading.Thread.Sleep(1250);
            conn.connect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbcon.con;
            cmd.CommandText = "SELECT stattendance.IndexNo,stattendance.Name,stattendance.Date,stattendance.Intime,stattendance.OutTime FROM((stattendance INNER JOIN students ON stattendance.IndexNo = students.stID )INNER JOIN classes ON students.grade = classes.grade) WHERE classes.Incharge =@abc AND stattendance.Date BETWEEN @from AND @to ORDER BY stattendance.Date DESC";

            cmd.Parameters.AddWithValue("@from", fromD.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@to", toD.Value.ToString("yyyy-MM-dd"));
            
            cmd.Parameters.AddWithValue("@abc",hide1.Text );
            cmd.ExecuteNonQuery();
            
            


            try
            {
                
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }


        

    }
}
