using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public class ListMethods
    {
        // Connection string.
        SqlConnection con = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Database=Automations");

        // Müşteri için listeleme.
        public void ListOfCustomer(DataGridView dgw, int aranan)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM orderDB where(customer like '%" + aranan + "%')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw.DataSource = dt;
        }
        // Ürün siparişi için listeleme. 
        public void ListProductOrder(DataGridView dgw, int aranan)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Order_ord where(Customer_table like '%" + aranan + "%')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw.DataSource = dt;
        }
        // DataGridView İçin listeleme.Ürünler
        public void ListDataProduct(DataGridView dgw)
        {
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM productDB ", con);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dgw.DataSource = tablo;
        }

        // DataGridView içine listelemek için.Adisyon
        public void ListDataOrderDB(DataGridView dgw)
        {
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM Order_ord ", con);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dgw.DataSource = tablo;
        }
        // Logger listelemek için.
        public void ListDataLogger(DataGridView dgw)
        {
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM Logger ", con);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dgw.DataSource = tablo;
        }
        // Siparişleri listlemelek için.Order.
        public void ListDataOrder(DataGridView dgw)
        {
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM orderDB ", con);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dgw.DataSource = tablo;
        }
        // Admin paneli için.
        public void ListDataAdmin(DataGridView dgw)
        {
            SqlDataAdapter komut = new SqlDataAdapter("SELECT * FROM workerDB ", con);
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dgw.DataSource = tablo;
        }


    }
}
