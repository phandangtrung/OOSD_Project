namespace Final_Project.GUI.Admin
{
    partial class UC_Category
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_AddCate = new System.Windows.Forms.Button();
            this.txb_des = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btn_Removecate = new System.Windows.Forms.Button();
            this.btn_editcate = new System.Windows.Forms.Button();
            this.txb_namecate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_category = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.PanEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_clear);
            this.PanEmployee.Controls.Add(this.btn_AddCate);
            this.PanEmployee.Controls.Add(this.txb_des);
            this.PanEmployee.Controls.Add(this.Tên);
            this.PanEmployee.Controls.Add(this.btn_Removecate);
            this.PanEmployee.Controls.Add(this.btn_editcate);
            this.PanEmployee.Controls.Add(this.txb_namecate);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(634, 21);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(506, 427);
            this.PanEmployee.TabIndex = 9;
            // 
            // btn_AddCate
            // 
            this.btn_AddCate.Location = new System.Drawing.Point(50, 368);
            this.btn_AddCate.Name = "btn_AddCate";
            this.btn_AddCate.Size = new System.Drawing.Size(112, 40);
            this.btn_AddCate.TabIndex = 42;
            this.btn_AddCate.Text = "Thêm danh mục";
            this.btn_AddCate.UseVisualStyleBackColor = true;
            this.btn_AddCate.Click += new System.EventHandler(this.btn_AddCate_Click);
            // 
            // txb_des
            // 
            this.txb_des.Location = new System.Drawing.Point(178, 124);
            this.txb_des.Name = "txb_des";
            this.txb_des.Size = new System.Drawing.Size(200, 26);
            this.txb_des.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(27, 124);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(49, 20);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Mô tả";
            // 
            // btn_Removecate
            // 
            this.btn_Removecate.Location = new System.Drawing.Point(196, 368);
            this.btn_Removecate.Name = "btn_Removecate";
            this.btn_Removecate.Size = new System.Drawing.Size(112, 40);
            this.btn_Removecate.TabIndex = 3;
            this.btn_Removecate.Text = "Xoá danh mục";
            this.btn_Removecate.UseVisualStyleBackColor = true;
            this.btn_Removecate.Click += new System.EventHandler(this.btn_Removecate_Click);
            // 
            // btn_editcate
            // 
            this.btn_editcate.Location = new System.Drawing.Point(365, 368);
            this.btn_editcate.Name = "btn_editcate";
            this.btn_editcate.Size = new System.Drawing.Size(112, 40);
            this.btn_editcate.TabIndex = 2;
            this.btn_editcate.Text = "Sửa danh muc";
            this.btn_editcate.UseVisualStyleBackColor = true;
            this.btn_editcate.Click += new System.EventHandler(this.btn_editcate_Click);
            // 
            // txb_namecate
            // 
            this.txb_namecate.Location = new System.Drawing.Point(178, 79);
            this.txb_namecate.Name = "txb_namecate";
            this.txb_namecate.Size = new System.Drawing.Size(200, 26);
            this.txb_namecate.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên danh mục";
            // 
            // dtgv_category
            // 
            this.dtgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_category.Location = new System.Drawing.Point(3, 22);
            this.dtgv_category.Name = "dtgv_category";
            this.dtgv_category.RowHeadersWidth = 62;
            this.dtgv_category.RowTemplate.Height = 28;
            this.dtgv_category.Size = new System.Drawing.Size(625, 425);
            this.dtgv_category.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(40, 262);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 40);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // UC_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanEmployee);
            this.Controls.Add(this.dtgv_category);
            this.Name = "UC_Category";
            this.Size = new System.Drawing.Size(1166, 472);
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.Button btn_AddCate;
        private System.Windows.Forms.TextBox txb_des;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_Removecate;
        private System.Windows.Forms.Button btn_editcate;
        private System.Windows.Forms.TextBox txb_namecate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_category;
        private System.Windows.Forms.Button btn_clear;
    }
}
