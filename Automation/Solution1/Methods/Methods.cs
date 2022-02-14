using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Methods
{
    public class Methods
    {
        
        public static void call(Panel pnl ,Form frm) // Çağırma Methodu
        {
            pnl.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnl.Controls.Add(frm);
            frm.Show();
        }
        static string conString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Automations";
       
        public static void add(string name,string catagory,double  price,string pic) // Veri Eklemek İçin Methot
        {

            SqlConnection con = new SqlConnection(conString);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    string added = "insert into productDB(name,catagory,price,prd_image) values (@name,@catagory,@price,@picture)";

                    SqlCommand command = new SqlCommand(added, con);

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@catagory", catagory);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@picture", pic);

                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün Kayıt İşlemi Gerçekleşti.");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
        

        public static void delete(int number) // Veri Silmek İçin Methot
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand command;

            string sql = "DELETE FROM productDB WHERE number=@number";
            command = new SqlCommand(sql,con);
            command.Parameters.AddWithValue("@number", number);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi");
        }


        public  static void update(string name,string catagory,double price,int number,string pic)
        {
            SqlConnection con = new SqlConnection(conString);
            

            con.Open();
            string upd = "update productDB set name=@name,catagory=@catagory,price=@price,prd_image=@pic where number=@number";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand command = new SqlCommand(upd, con);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@catagory", catagory);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@number", number);
            command.Parameters.AddWithValue("@pic", pic);


            command.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi.");
        }

        
    }
}
