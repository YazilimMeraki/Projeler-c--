using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Panels;
using Menu = UI.Panels.Menu;
using Methods;

namespace UI
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            
            
        }

        ToolTip Help = new ToolTip();
        private void Homepage_Load(object sender, EventArgs e)
        {
            // Açılışta gizlenen paneller.
            panel2.Hide();
            btnAdminPanel.Hide();
            btnLogger.Hide();
            btnSafe.Hide();
            panel1.Width = 1100;

            // Panel arka planları için.

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);

            // Açıklamalar


            Help.SetToolTip(btnAdminPanel, "Çalışan bilgileri ve yönetimi.");

            Help.SetToolTip(btnLogger, "Programa giriş yapanlar.");

            Help.SetToolTip(btnMenu, "Menüye bakmak için.");

            Help.SetToolTip(btnProduct, "Ürün ekle/sil/güncelle işlemleri.");

            Help.SetToolTip(btnSafe, "Giderler gelirler.");

            Help.SetToolTip(btnSendOrder, "Gönderilen siparişler.");

            Help.SetToolTip(btnLoginExit, "Çıkış yap.");

            Help.SetToolTip(btnOrder, "Adisyona ürün ekle.");

            Help.SetToolTip(btnLogin, "Size tanımlanmış kullanıcı adı ve şifrenizle giriş yapın.");


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUser.Text.ToLower(), pwd = txtPwd.Text;
            Methods.WorkerMethot.Login(btnAdminPanel,panel2,id, pwd,btnLogger,panel3,btnSafe);

            Methods.Logger log = new Methods.Logger();
            
            log.logged(txtUser.Text, panel2);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            Panels.Order order = new Panels.Order();
            Methods.Methods.call(panel1, order);

        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Methods.Methods.call(panel1,menu);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            Methods.Methods.call(panel1 ,stock);
            
            
        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            Panels.Safe safe = new Panels.Safe();
            Methods.Methods.call(panel1, safe);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Methods.Methods.call(panel1, form1);
        }

        private void btnLogger_Click(object sender, EventArgs e)
        {

            Panels.Logger logger = new Panels.Logger();
            Methods.Methods.call(panel1, logger);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminPanel adminPanel = new AdminPanel();
            Methods.Methods.call(panel1, adminPanel);
        }
        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.Width = 70;
        }

        private void btnAdminPanel_MouseHover(object sender, EventArgs e)
        {

            panel2.Width = 230;
            
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

            panel2.Width = 70;
        }

        private void Homepage_MouseHover(object sender, EventArgs e)
        {

            panel2.Width = 70;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
