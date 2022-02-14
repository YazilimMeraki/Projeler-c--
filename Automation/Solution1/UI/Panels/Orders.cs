using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Panels
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }


        Methods.OrderMethod orderMethod = new Methods.OrderMethod();



        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (cbxTable.SelectedIndex>=0 && txtAdet.Text !="" && txtAdet.Text != "" && lblPrice.Text != ""&& lblid.Text!="-")
            {

                String cat = lblCatagory.Text, name = lblName.Text;
                double price = Convert.ToDouble(lblPrice.Text);
                int qua = Convert.ToInt32(txtAdet.Text), table = Convert.ToInt32(cbxTable.SelectedItem), id = Convert.ToInt32(lblid.Text);
                orderMethod.ProductAdd(cat, name, price, qua, id, table);
                Order_Load(null, null);
            }
            else
            {
                MessageBox.Show("Kayıt sırasında hata oluştu");
            }
                
            
        }

        private void Order_Load(object sender, EventArgs e)
        {

            Methods.ListMethods list = new Methods.ListMethods();
            list.ListDataProduct(dgvProduct);
            list.ListDataOrderDB(dataGridView1);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            lblName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString(); // Product name write insert to label
            lblCatagory.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString(); // Product catagory write insert to label 
            lblPrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString(); // Product price insert to label
            txtPic.Text= dgvProduct.CurrentRow.Cells[4].Value.ToString();
            pbxProductPics.ImageLocation = txtPic.Text;
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            double total = 0;
            int cus = Convert.ToInt32(dataGridView1.Rows[0].Cells[6].Value);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                double aratoplam =Convert.ToDouble( dataGridView1.Rows[i].Cells[4].Value)* Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                total += aratoplam;
            }

            orderMethod.AddOrder(total, cus.ToString());
        }

        private void dgwOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            int numb =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            orderMethod.deleteorder(numb);

            Order_Load(null, null);
        }

        private void cbxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aranan = cbxTable.SelectedIndex;

            Methods.ListMethods list = new Methods.ListMethods();

            list.ListProductOrder(dataGridView1, aranan);
        }

        private void txtAdet_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdet.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
