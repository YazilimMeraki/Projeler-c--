
namespace UI.Panels
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnMenuSelect = new System.Windows.Forms.Button();
            this.ofdMenu = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1000, 600);
            this.axAcroPDF1.TabIndex = 0;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // btnMenuSelect
            // 
            this.btnMenuSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenuSelect.Location = new System.Drawing.Point(967, 0);
            this.btnMenuSelect.Name = "btnMenuSelect";
            this.btnMenuSelect.Size = new System.Drawing.Size(33, 600);
            this.btnMenuSelect.TabIndex = 1;
            this.btnMenuSelect.Text = "M\r\nE\r\nN\r\nÜ\r\n\r\nS\r\nE\r\nÇ\r\n";
            this.btnMenuSelect.UseVisualStyleBackColor = true;
            this.btnMenuSelect.Click += new System.EventHandler(this.btnMenuSelect_Click);
            // 
            // ofdMenu
            // 
            this.ofdMenu.FileName = "openFileDialog1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnMenuSelect);
            this.Controls.Add(this.axAcroPDF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnMenuSelect;
        private System.Windows.Forms.OpenFileDialog ofdMenu;
    }
}