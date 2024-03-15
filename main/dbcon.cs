using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace LMS.main
{
    internal class dbcon
    {
        public static string connection = "server=localhost;port=3307;user=root;password=root123;database=lms";

        public static MySqlConnection con = null;

        public void connect()
        {
            con = new MySqlConnection(connection);
            try 
            { 
                con.Open(); 
            }
            catch (MySqlException ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
            

        }
    }
}
