
namespace UI
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnLogger = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1037, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 600);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pbUser);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.txtPwd);
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLoginExit);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 600);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(36, 73);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(155, 174);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 12;
            this.pbUser.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gold;
            this.btnLogin.Location = new System.Drawing.Point(61, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 51);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(36, 350);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(155, 22);
            this.txtPwd.TabIndex = 10;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(36, 284);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(155, 22);
            this.txtUser.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(90, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(57, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginExit.ForeColor = System.Drawing.Color.Red;
            this.btnLoginExit.Location = new System.Drawing.Point(81, 547);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(65, 50);
            this.btnLoginExit.TabIndex = 13;
            this.btnLoginExit.Text = "Kapat";
            this.btnLoginExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnAdminPanel);
            this.panel2.Controls.Add(this.btnLogger);
            this.panel2.Controls.Add(this.btnSendOrder);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnSafe);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 600);
            this.panel2.TabIndex = 1;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminPanel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel.ForeColor = System.Drawing.Color.Red;
            this.btnAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPanel.Image")));
            this.btnAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 443);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(230, 70);
            this.btnAdminPanel.TabIndex = 13;
            this.btnAdminPanel.Text = "Yönetici Paneli";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.button2_Click);
            this.btnAdminPanel.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // btnLogger
            // 
            this.btnLogger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogger.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogger.ForeColor = System.Drawing.Color.Red;
            this.btnLogger.Image = ((System.Drawing.Image)(resources.GetObject("btnLogger.Image")));
            this.btnLogger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogger.Location = new System.Drawing.Point(0, 378);
            this.btnLogger.Name = "btnLogger";
            this.btnLogger.Size = new System.Drawing.Size(230, 70);
            this.btnLogger.TabIndex = 12;
            this.btnLogger.Text = "Giriş Kontrolü";
            this.btnLogger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogger.UseVisualStyleBackColor = true;
            this.btnLogger.Click += new System.EventHandler(this.btnLogger_Click);
            this.btnLogger.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendOrder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOrder.ForeColor = System.Drawing.Color.Red;
            this.btnSendOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSendOrder.Image")));
            this.btnSendOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendOrder.Location = new System.Drawing.Point(0, 118);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(230, 70);
            this.btnSendOrder.TabIndex = 11;
            this.btnSendOrder.Text = "Giden Siparişler";
            this.btnSendOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            this.btnSendOrder.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 70);
            this.button4.TabIndex = 8;
            this.button4.Text = "Kapat";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // btnSafe
            // 
            this.btnSafe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSafe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafe.ForeColor = System.Drawing.Color.Red;
            this.btnSafe.Image = ((System.Drawing.Image)(resources.GetObject("btnSafe.Image")));
            this.btnSafe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSafe.Location = new System.Drawing.Point(0, 313);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(230, 70);
            this.btnSafe.TabIndex = 7;
            this.btnSafe.Text = "Kasa";
            this.btnSafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            this.btnSafe.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Red;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 183);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(230, 70);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menü";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Red;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 248);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(230, 70);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Ürünler";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Red;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 53);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(230, 70);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Sipariş Ekle";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseHover += new System.EventHandler(this.btnAdminPanel_MouseHover);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.MouseHover += new System.EventHandler(this.Homepage_MouseHover);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoginExit;
        private System.Windows.Forms.PictureBox pbUser;
        public System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button btnSafe;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSendOrder;
        public System.Windows.Forms.Button btnAdminPanel;
        public System.Windows.Forms.Button btnLogger;
    }
}