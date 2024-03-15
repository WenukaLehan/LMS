using MySql.Data.MySqlClient;

namespace LMS
{
    internal class dbcon
    {
        public static string connection = "server=localhost;port=3306;user=root;password=;database=test2";

        public static MySqlConnection con = null;

        public void connect()
        {
            con = new MySqlConnection(connection);
            con.Open();

        }
    }
}
