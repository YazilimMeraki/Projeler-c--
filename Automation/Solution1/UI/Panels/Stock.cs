using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        ToolTip Help = new ToolTip();
        private void Stock_Load(object sender, EventArgs e)
        {
            Methods.ListMethods listed = new Methods.ListMethods();
            listed.ListDataProduct(dgvProduct);

            // Açıklamalar
            Help.SetToolTip(btnAdd, "Ürün bilgilerini doldurduktan sonra kaydeder.");

            Help.SetToolTip(btnUpdate, "Ürün bilgilerini güncelledikten sonra kaydeder.");

            Help.SetToolTip(btnAddClear, "Girilen bilgileri temizler.");

            Help.SetToolTip(btnDelete, "Seçilen ürünü siler.");

            Help.SetToolTip(btnUpdatePic, "Resim seçmimi içindir.");

            Help.SetToolTip(btnOpenFile, "Resim seçmek içindir.");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text!=""&& txtAddPrice.Text!="" && cbxAddCatagory.Text!="")
            {
                string pic = txtPic.Text;
                String Name = txtAddName.Text, catagory = cbxAddCatagory.Text;
                double price = Convert.ToDouble(txtAddPrice.Text);
                Methods.Methods.add(Name, catagory, price, pic);

                Stock_Load(null, null);

            }
            else
            {
                MessageBox.Show("İşlem sırasında hata oluştu");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgvProduct.SelectedRows)  //Seçili Satırları Silme
            {
                int number = Convert.ToInt32(drow.Cells[0].Value);
                Methods.Methods.delete(number);
                Stock_Load(null, null);

                txtUpdateName.Clear();
                txtUpdatePrice.Clear();


            }
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            txtAddPrice.Clear();txtAddPrice.Clear();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text= dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtUpdatePrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            cbxUpdateCatagory.Text= dgvProduct.CurrentRow.Cells[2].Value.ToString();
            pbxUpdate.ImageLocation = dgvProduct.CurrentRow.Cells[4].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string pic = txtUpdatePic.Text;
            if (txtUpdateName.Text!=""&&txtUpdatePrice.Text!="" && cbxAddCatagory.Text!="")
            {

                MessageBox.Show("Geçerli bilgileri seçip giriniz");
            }
            else
            {
                string name = txtUpdateName.Text;
                string catagory = cbxUpdateCatagory.Text; 
                double price = Convert.ToDouble(txtUpdatePrice.Text);
                foreach (DataGridViewRow drow in dgvProduct.SelectedRows)  // Güncelleme
                {

                    int number = Convert.ToInt32(drow.Cells[0].Value);
                    Methods.Methods.update(name, catagory, price, number, pic);
                    Stock_Load(null, null);

                    txtUpdateName.Clear();
                    txtUpdatePrice.Clear();
                }
            }
            

            
        }

        private void btnAddOpenFile_Click(object sender, EventArgs e)
        {
          

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Open file dialogun açılmasını sağladık.
            openFileDialog1.ShowDialog();
            // Picturebox içine yönlendirdik open file dialogta seçileni.
            pbxAdd.ImageLocation = openFileDialog1.FileName;
            // Open file dialog'un dosya yolunu textbox a yazdırdık
            txtPic.Text = openFileDialog1.FileName;

        }

        private void btnUpdatePic_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pbxUpdate.ImageLocation = openFileDialog2.FileName;
            txtUpdatePic.Text= openFileDialog2.FileName;

        }

        private void txtAddPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddPrice.Clear();
        }

        private void txtUpdatePrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtUpdatePrice.Clear();
        }
    }
}
