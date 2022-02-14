using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Panels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Methods.ListMethods listed = new Methods.ListMethods();
            listed.ListDataOrder(dgwTable);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            int number = cbxTable.SelectedIndex;
            string total = lblTotal.Text;

            if (cbxTable.Text=="")
            {
                MessageBox.Show("Lütfen masa seçin");
            }
            else
            {
                Methods.OrderMethod order = new Methods.OrderMethod();

                order.closetable(number, total);
                order.deleteTable(number);

            }

            Methods.ListMethods listed = new Methods.ListMethods();
            listed.ListDataOrder(dgwTable);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aranan = cbxTable.SelectedIndex;

            Methods.ListMethods list = new Methods.ListMethods();

            list.ListOfCustomer(dgwTable, aranan);

            double total = 0;

            for (int i = 0; i < dgwTable.Rows.Count; i++)
            {
                double aratoplam = Convert.ToDouble(dgwTable.Rows[i].Cells[2].Value);
                total += aratoplam;
            }

            lblTotal.Text = total.ToString();
        }


        private void lblTable_Click(object sender, EventArgs e)
        {

        }
    }
}
