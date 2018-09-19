using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace prototipo_login_2
{
    class CapaLogica
    {
        MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
       

        public Boolean login(string usuario, string contrasena)
        {
            conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            conn_string.Password = "MyPass12345";
            conn_string.Database = "mydb_security";

            int i = 0;
            string username = usuario;
            string password = contrasena;


            MySqlConnection con = new MySqlConnection(conn_string.ToString());
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuario where usu_nickname='" + username + "' and usu_password='" + password + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = dt.Rows.Count;

            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
