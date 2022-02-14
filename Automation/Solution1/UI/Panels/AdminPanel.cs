using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Methods.ListMethods listed =new  Methods.ListMethods();
            listed.ListDataAdmin(dataGridView1);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Writing from dgv to textbox
            txtName.Text      = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text   = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLoginId.Text   = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtLoginPwd.Text  = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text     = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAdress.Text    = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dtpStartDate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSalary.Text    = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing all textbox
            txtName.Clear();
            txtSurname.Clear();
            txtLoginId.Clear();
            txtLoginPwd.Clear();
            txtPhone.Clear();
            txtAdress.Clear();
            txtSalary.Clear();
            // Clear start date
            dtpStartDate.Value = DateTime.Now;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the data grid view row.

            string admin = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (admin!="1")
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  
                {
                    

                    int number = Convert.ToInt32(drow.Cells[0].Value);

                    Methods.WorkerMethot.delete(number);

                    AdminPanel_Load(null, null);

                    // Clearing all textbox
                    
                    txtName.Clear();
                    txtSurname.Clear();
                    txtLoginId.Clear();
                    txtLoginPwd.Clear();
                    txtPhone.Clear();
                    txtAdress.Clear();
                    txtSalary.Clear();

                    // Clear start date
                    
                    dtpStartDate.Value = DateTime.Now;

                }
            }
            else
            {
                MessageBox.Show("Admin Kullanıcı Silinemez");
            }
            
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            
            string name = txtName.Text, surname = txtSurname.Text, loginid = txtLoginId.Text, loginpwd = txtLoginPwd.Text, phone = txtPhone.Text, adress = txtAdress.Text, salary = txtSalary.Text;
            
            string startdate = dtpStartDate.Text;

            if (name!=""&&surname!="" &&loginid!=""&&loginpwd!=""&&phone!=""&&adress!=""&&salary!="")
            {
                Methods.WorkerMethot.Save(name, surname, loginid, loginpwd, phone, adress, startdate, salary);

                AdminPanel_Load(null, null);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }
    }
}
