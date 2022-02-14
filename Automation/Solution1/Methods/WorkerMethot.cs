using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public class WorkerMethot
    {
        static string conString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Automations";
        public static void Login(Button lbl, Panel pnl1,string id, string pwd,Button lbl2,Panel pnl2,Button safe) // Login ekranında üye sorgulama
        {
            SqlDataReader dr;

            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from workerDB where loginid=@id and loginpwd=@pwd";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                if (id == "admin")
                {
                    pnl1.Visible = true;
                    pnl2.Visible = false;
                    safe.Visible = true;
                    lbl.Visible = true;
                    lbl2.Visible = true;
                    

                }
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                pnl1.Visible = true;
                pnl2.Visible = false;

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                
            }

            con.Close();
        }

        public static void Save(string name, string surname, string loginid, string loginpwd, string phone, string adress, string startdate, string salary)
        {
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insert into workerDB " +
                       "(name,surname,loginid,loginpwd,phone,adress,startdate,salary)" +
                " values(@name,@surname,@loginid,@loginpwd,@phone,@adress,@startdate,@salary)";


            con.Open();

            string kayit = "insert into workerDB " +
                       "(name,surname,loginid,loginpwd,phone,adress,startdate,salary)" +
                       " values(@name,@surname,@loginid,@loginpwd,@phone,@adress,@startdate,@salary)";

            SqlCommand command = new SqlCommand(kayit, con);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@loginid", loginid);
            command.Parameters.AddWithValue("@loginpwd", loginpwd);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@adress", adress);
            command.Parameters.AddWithValue("@startdate", startdate);
            command.Parameters.AddWithValue("@salary", salary);


            command.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Çalışan Kayıt İşlemi Gerçekleşti.");

        }

        public static void delete(int number) // Veri Silmek İçin Methot
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand command;

            string sql = "DELETE FROM workerDB WHERE number=@number";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@number", number);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi");





        }
    }
}
