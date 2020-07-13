namespace Final_Project.GUI
{
    partial class Admin_Form
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
            this.btn_Em = new System.Windows.Forms.Button();
            this.PanAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_brand = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Em
            // 
            this.btn_Em.Location = new System.Drawing.Point(11, 34);
            this.btn_Em.Name = "btn_Em";
            this.btn_Em.Size = new System.Drawing.Size(120, 45);
            this.btn_Em.TabIndex = 0;
            this.btn_Em.Text = "Nhân Viên";
            this.btn_Em.UseVisualStyleBackColor = true;
            this.btn_Em.Click += new System.EventHandler(this.btn_Em_Click);
            // 
            // PanAdmin
            // 
            this.PanAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanAdmin.Location = new System.Drawing.Point(166, 36);
            this.PanAdmin.Name = "PanAdmin";
            this.PanAdmin.Size = new System.Drawing.Size(1452, 472);
            this.PanAdmin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_brand);
            this.panel2.Controls.Add(this.btn_Category);
            this.panel2.Controls.Add(this.btn_Em);
            this.panel2.Location = new System.Drawing.Point(5, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 472);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tài khoản nhân viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_brand
            // 
            this.btn_brand.Location = new System.Drawing.Point(11, 171);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Size = new System.Drawing.Size(120, 45);
            this.btn_brand.TabIndex = 2;
            this.btn_brand.Text = "Brand";
            this.btn_brand.UseVisualStyleBackColor = true;
            this.btn_brand.Click += new System.EventHandler(this.btn_brand_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Location = new System.Drawing.Point(11, 102);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(120, 45);
            this.btn_Category.TabIndex = 1;
            this.btn_Category.Text = "Danh mục";
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanAdmin);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Em;
        private System.Windows.Forms.Panel PanAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_brand;
        private System.Windows.Forms.Button btn_Category;
    }
}