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

namespace LMS.source_codes
{
    public partial class login : Form
    {
        
        dbcon conn = new main.dbcon();

        Boolean admin = false, principle = false, teachers = false;
        String table;

        public login()
        {
            InitializeComponent();
            utype.Items.Add("Admin");
            utype.Items.Add("Principle");
            utype.Items.Add("Teacher");
            utype.SelectedIndex = 2;
        }

       
        private void utype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (utype.SelectedIndex == 2)
            {
                teachers = true;
                admin = false;
                principle = false;
                table = "teachers";
            }
            if (utype.SelectedIndex == 1)
            {
                principle = true;
                admin = false;
                teachers = false;
                table = "principle";
            }
            if (utype.SelectedIndex == 0)
            {
                admin = true;
                teachers = false;
                principle = false;
                table = "admin";
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (admin || principle || teachers)
            {
                conn.connect();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbcon.con;
                cmd.CommandText = "SELECT username,password FROM " + table + " WHERE username=" + "'" + username.Text + "'";
                //cmd.Parameters.AddWithValue("@username", username.Text);

                try
                {

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string pasword = reader.GetString("password");
                        if (pasword.Equals(password.Text))
                        {
                            MessageBox.Show("Login Successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(admin)
                            {
                                admin.aDashboard adm = new admin.aDashboard();
                                adm.Show();
                                this.Hide();
                            }else if(principle)
                            {
                                principle.pDashboard pri = new principle.pDashboard();
                                pri.Show();
                                this.Hide();
                            }else if(teachers)
                            {
                                teacher.tDashboard tea = new teacher.tDashboard();
                                tea.Show();
                                tea.tName(username.Text.ToString());
                                this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                    else
                    {
                        MessageBox.Show("User Name Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbcon.con.Close();

                }
                catch (Exception)
                {
                   MessageBox.Show("Database Error","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select User Type");
            }

        }
    }
    
}
