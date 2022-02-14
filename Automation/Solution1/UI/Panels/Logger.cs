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
    public partial class Logger : Form
    {
        public Logger()
        {
            InitializeComponent();
        }

        private void Logger_Load(object sender, EventArgs e)
        {
            Methods.ListMethods listed = new Methods.ListMethods();
            listed.ListDataLogger(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
