using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Methods
{
    public class Logger
    {
        static string conString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Automations";
        public void logged(string id,Panel pnl)
        {
            if (pnl.Visible==true)
            {
                SqlConnection con = new SqlConnection(conString);

                con.Open();

                string added = "insert into Logger(worker_id,login_time) values (@id,@time)  ";
                

                SqlCommand command = new SqlCommand(added, con);

                command.Parameters.AddWithValue("@time",DateTime.Now);

                command.Parameters.AddWithValue("@id", id);

                

                command.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
