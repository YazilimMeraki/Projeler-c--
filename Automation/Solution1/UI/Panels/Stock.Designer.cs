
namespace UI
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAddCatagory = new System.Windows.Forms.ComboBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtUpdatePic = new System.Windows.Forms.TextBox();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateCatagory = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbxUpdate = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbxProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.ColumnHeadersVisible = false;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvProduct.Location = new System.Drawing.Point(546, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(454, 600);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProductAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbxProductAdd.Controls.Add(this.txtPic);
            this.gbxProductAdd.Controls.Add(this.btnOpenFile);
            this.gbxProductAdd.Controls.Add(this.btnAddClear);
            this.gbxProductAdd.Controls.Add(this.txtAddPrice);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.label4);
            this.gbxProductAdd.Controls.Add(this.label3);
            this.gbxProductAdd.Controls.Add(this.pbxAdd);
            this.gbxProductAdd.Controls.Add(this.label1);
            this.gbxProductAdd.Controls.Add(this.cbxAddCatagory);
            this.gbxProductAdd.Controls.Add(this.txtAddName);
            this.gbxProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProductAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 0);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(470, 300);
            this.gbxProductAdd.TabIndex = 1;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Ürün Ekle";
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(340, 210);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(124, 26);
            this.txtPic.TabIndex = 13;
            this.txtPic.Visible = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Tan;
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(386, 156);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(36, 31);
            this.btnOpenFile.TabIndex = 12;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.BackColor = System.Drawing.Color.Gold;
            this.btnAddClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClear.Location = new System.Drawing.Point(6, 263);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(124, 31);
            this.btnAddClear.TabIndex = 11;
            this.btnAddClear.Text = "Temizle";
            this.btnAddClear.UseVisualStyleBackColor = false;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPrice.Location = new System.Drawing.Point(133, 127);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(164, 26);
            this.txtAddPrice.TabIndex = 9;
            this.txtAddPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddPrice_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(340, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Katagorisi";
            // 
            // pbxAdd
            // 
            this.pbxAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAdd.Location = new System.Drawing.Point(340, 16);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(124, 134);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 3;
            this.pbxAdd.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // cbxAddCatagory
            // 
            this.cbxAddCatagory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAddCatagory.FormattingEnabled = true;
            this.cbxAddCatagory.Items.AddRange(new object[] {
            "Sıcak",
            "Soğuk",
            "Yiyecek",
            "Tatlı",
            "Aperatif"});
            this.cbxAddCatagory.Location = new System.Drawing.Point(133, 77);
            this.cbxAddCatagory.Name = "cbxAddCatagory";
            this.cbxAddCatagory.Size = new System.Drawing.Size(164, 27);
            this.cbxAddCatagory.TabIndex = 1;
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(133, 33);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(164, 26);
            this.txtAddName.TabIndex = 0;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gbxUpdate.Controls.Add(this.txtUpdatePic);
            this.gbxUpdate.Controls.Add(this.btnUpdatePic);
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.label6);
            this.gbxUpdate.Controls.Add(this.txtUpdateName);
            this.gbxUpdate.Controls.Add(this.txtUpdatePrice);
            this.gbxUpdate.Controls.Add(this.cbxUpdateCatagory);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.pbxUpdate);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.label5);
            this.gbxUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbxUpdate.Location = new System.Drawing.Point(12, 300);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(470, 300);
            this.gbxUpdate.TabIndex = 2;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Güncelle / Sil";
            // 
            // txtUpdatePic
            // 
            this.txtUpdatePic.Location = new System.Drawing.Point(340, 204);
            this.txtUpdatePic.Name = "txtUpdatePic";
            this.txtUpdatePic.Size = new System.Drawing.Size(124, 26);
            this.txtUpdatePic.TabIndex = 22;
            this.txtUpdatePic.Visible = false;
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.BackColor = System.Drawing.Color.Tan;
            this.btnUpdatePic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePic.Location = new System.Drawing.Point(386, 148);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(36, 31);
            this.btnUpdatePic.TabIndex = 14;
            this.btnUpdatePic.Text = "...";
            this.btnUpdatePic.UseVisualStyleBackColor = false;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 31);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürün Adı";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateName.Location = new System.Drawing.Point(133, 29);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(164, 26);
            this.txtUpdateName.TabIndex = 12;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePrice.Location = new System.Drawing.Point(133, 123);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(164, 26);
            this.txtUpdatePrice.TabIndex = 19;
            this.txtUpdatePrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpdatePrice_MouseClick);
            // 
            // cbxUpdateCatagory
            // 
            this.cbxUpdateCatagory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdateCatagory.FormattingEnabled = true;
            this.cbxUpdateCatagory.Items.AddRange(new object[] {
            "Sıcak",
            "Soğuk",
            "Yiyecek",
            "Tatlı",
            "Aperatif"});
            this.cbxUpdateCatagory.Location = new System.Drawing.Point(133, 73);
            this.cbxUpdateCatagory.Name = "cbxUpdateCatagory";
            this.cbxUpdateCatagory.Size = new System.Drawing.Size(164, 27);
            this.cbxUpdateCatagory.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(340, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbxUpdate
            // 
            this.pbxUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxUpdate.Location = new System.Drawing.Point(340, 12);
            this.pbxUpdate.Name = "pbxUpdate";
            this.pbxUpdate.Size = new System.Drawing.Size(124, 134);
            this.pbxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUpdate.TabIndex = 15;
            this.pbxUpdate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürün Katagorisi";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.dgvProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAddCatagory;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.ComboBox cbxUpdateCatagory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbxUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.TextBox txtUpdatePic;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}