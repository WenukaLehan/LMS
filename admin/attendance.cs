using LMS.main;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace LMS.admin
{
    public partial class attendance : Form
    {
        dbcon conn = new dbcon();
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public attendance()
        {
            InitializeComponent();
            fromD.Value = DateTime.UtcNow.AddDays(-3000);
            toD.Value = DateTime.Now;
            attend();
            ser();
        }

        private void ser()
        {
            conn.connect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbcon.con;
            cmd.CommandText = "SELECT grade FROM classes";
            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clz.Items.Add(dr[0].ToString());
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void attend()
        {
            dt.Rows.Clear();
            conn.connect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = dbcon.con;
            cmd.CommandText = "SELECT classes.grade,stattendance.IndexNo,stattendance.Name,stattendance.Date,stattendance.Intime,stattendance.OutTime FROM((stattendance INNER JOIN students ON stattendance.IndexNo = students.stID )INNER JOIN classes ON students.grade = classes.grade) WHERE (stattendance.Date BETWEEN @from AND @to)";
            cmd.Parameters.AddWithValue("@from", fromD.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@to", toD.Value.ToString("yyyy-MM-dd"));
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
            dbcon.con.Close();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            attend();
        }

        private void clz_SelectedIndexChanged(object sender, EventArgs e)
        {
            (data.DataSource as DataTable).DefaultView.RowFilter = string.Format("grade LIKE '%{0}%'", clz.Text);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
            (data.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", name.Text);
        }

        private void Index_TextChanged(object sender, EventArgs e)
        {
            (data.DataSource as DataTable).DefaultView.RowFilter = string.Format("IndexNo LIKE '%{0}%'", Index.Text);
        }
    }
}
