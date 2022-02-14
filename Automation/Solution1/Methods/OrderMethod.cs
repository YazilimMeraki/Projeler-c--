using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Methods
{
    public class OrderMethod
    {
        static string conString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Automations";
        //Fatura ekleme.
        public void AddOrder(double total,string cus)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    string added = "insert into orderDB(total,customer,time) values (@total,@cus,@time)";

                    SqlCommand command = new SqlCommand(added, con);

                    command.Parameters.AddWithValue("@total",total);
                    command.Parameters.AddWithValue("@cus",cus);
                    command.Parameters.AddWithValue("@time", DateTime.Now);
                    

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

        //Ürün ekleme.
        public void ProductAdd(string cat,string name,double price,int quantity,int id,int table)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    string added = "insert into Order_ord(product_catagory,product_name,product_price,product_quantity,product_id,customer_table)" +
                        " values (@cat,@name,@price,@quantity,@product_id,@table)";

                    SqlCommand command = new SqlCommand(added, con);

                    command.Parameters.AddWithValue("@cat",cat);
                    command.Parameters.AddWithValue("@name",name);
                    command.Parameters.AddWithValue("@price",price);
                    command.Parameters.AddWithValue("@quantity",quantity);
                    command.Parameters.AddWithValue("@product_id", id);
                    command.Parameters.AddWithValue("@table", table);

                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }



        }
        //Ürün Silmek için.
        public void deleteorder(int number)
        { 
            SqlConnection con = new SqlConnection(conString);
            SqlCommand command;

            string sql = "DELETE FROM Order_ord WHERE order_id=@number";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@number", number);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi");
        }
        // Ürün kaldırak için.
        public void tableorder(int number)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand command;

            string sql = "DELETE FROM orderDB WHERE number=@number";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@number", number);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi");

        }
        // Masa kapatmak için.
        public void closetable(int number,string total)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand command;

            string sql = "DELETE FROM orderDB WHERE customer=@number";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@number", number);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Toplam tutar ="+ total + "");
        }
        // Masa kapandıktan sonra adisyonun temizlenmesi için.
        public void deleteTable(int number)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand command;

            string sql = "DELETE FROM Order_ord WHERE Customer_table=@number";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@number", number);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        // Adisyon güncelleme.
        public void UpdateProductBill(double price, int qua)
        {
            SqlConnection con = new SqlConnection(conString);
            string sql = "update Order_ord set " +
                "product_price = '" + price + "',product_quantity = '" + qua + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
