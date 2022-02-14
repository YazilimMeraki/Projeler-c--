
namespace UI.Menus
{
    partial class LoginMenu
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 50);
            this.button4.TabIndex = 13;
            this.button4.Text = "Kapat";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSafe
            // 
            this.btnSafe.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafe.Location = new System.Drawing.Point(0, 339);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(230, 50);
            this.btnSafe.TabIndex = 12;
            this.btnSafe.Text = "Kasa";
            this.btnSafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSafe.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 134);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(230, 50);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menü";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(0, 238);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(230, 50);
            this.btnProduct.TabIndex = 11;
            this.btnProduct.Text = "Ürünler";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(0, 36);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(230, 50);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Siparişler";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button btnSafe;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
    }
}