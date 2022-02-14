using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Panels
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //if (ofdMenu.FileName!=null)
            //{
            //    OpenFileDialog ofdMenu = new OpenFileDialog();
            //    string fileName = "D\\Desktop\\Restoran.pdf";

            //    if (fileName != null)
            //    {
            //        axAcroPDF1.LoadFile(fileName);
            //        Process.Start(fileName);
            //    }
            //}
            
        }

        
        private void btnMenuSelect_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog ofdMenu = new OpenFileDialog();
            
            ofdMenu.Filter = "PDF Dosyaları | *.pdf";
            ofdMenu.ShowDialog();
            string fileWiew = ofdMenu.FileName;
            if (ofdMenu.FileName != "")
            {
                axAcroPDF1.LoadFile(ofdMenu.FileName);
            }
        }
       

        private void btnOk_Click(object sender, EventArgs e)
        {
        }
    }
}
