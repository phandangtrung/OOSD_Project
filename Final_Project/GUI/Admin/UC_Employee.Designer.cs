namespace Final_Project.GUI
{
    partial class UC_Employee
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
            this.btn_AddEm = new System.Windows.Forms.Button();
            this.btn_RemoveEm = new System.Windows.Forms.Button();
            this.btn_EditEm = new System.Windows.Forms.Button();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_createacc = new System.Windows.Forms.Button();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.dtpk_Birth = new System.Windows.Forms.DateTimePicker();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_LName = new System.Windows.Forms.TextBox();
            this.txb_FName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvEmp = new System.Windows.Forms.DataGridView();
            this.PanEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddEm
            // 
            this.btn_AddEm.Location = new System.Drawing.Point(281, 368);
            this.btn_AddEm.Name = "btn_AddEm";
            this.btn_AddEm.Size = new System.Drawing.Size(112, 40);
            this.btn_AddEm.TabIndex = 2;
            this.btn_AddEm.Text = "Thêm nhân viên";
            this.btn_AddEm.UseVisualStyleBackColor = true;
            this.btn_AddEm.Click += new System.EventHandler(this.btn_AddEm_Click);
            // 
            // btn_RemoveEm
            // 
            this.btn_RemoveEm.Location = new System.Drawing.Point(154, 368);
            this.btn_RemoveEm.Name = "btn_RemoveEm";
            this.btn_RemoveEm.Size = new System.Drawing.Size(112, 40);
            this.btn_RemoveEm.TabIndex = 3;
            this.btn_RemoveEm.Text = "Xoá nhân viên";
            this.btn_RemoveEm.UseVisualStyleBackColor = true;
            this.btn_RemoveEm.Click += new System.EventHandler(this.btn_RemoveEm_Click);
            // 
            // btn_EditEm
            // 
            this.btn_EditEm.Location = new System.Drawing.Point(21, 368);
            this.btn_EditEm.Name = "btn_EditEm";
            this.btn_EditEm.Size = new System.Drawing.Size(127, 40);
            this.btn_EditEm.TabIndex = 4;
            this.btn_EditEm.Text = "Chỉnh sửa nhân viên";
            this.btn_EditEm.UseVisualStyleBackColor = true;
            this.btn_EditEm.Click += new System.EventHandler(this.btn_EditEm_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_createacc);
            this.PanEmployee.Controls.Add(this.tbx_id);
            this.PanEmployee.Controls.Add(this.txb_Phone);
            this.PanEmployee.Controls.Add(this.btn_EditEm);
            this.PanEmployee.Controls.Add(this.dtpk_Birth);
            this.PanEmployee.Controls.Add(this.btn_RemoveEm);
            this.PanEmployee.Controls.Add(this.txb_Address);
            this.PanEmployee.Controls.Add(this.btn_AddEm);
            this.PanEmployee.Controls.Add(this.txb_LName);
            this.PanEmployee.Controls.Add(this.txb_FName);
            this.PanEmployee.Controls.Add(this.label8);
            this.PanEmployee.Controls.Add(this.rb_Female);
            this.PanEmployee.Controls.Add(this.rb_Male);
            this.PanEmployee.Controls.Add(this.label4);
            this.PanEmployee.Controls.Add(this.label5);
            this.PanEmployee.Controls.Add(this.label6);
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(632, 43);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(506, 427);
            this.PanEmployee.TabIndex = 5;
            // 
            // btn_createacc
            // 
            this.btn_createacc.Location = new System.Drawing.Point(399, 360);
            this.btn_createacc.Name = "btn_createacc";
            this.btn_createacc.Size = new System.Drawing.Size(87, 56);
            this.btn_createacc.TabIndex = 36;
            this.btn_createacc.Text = "Tạo tài khoản";
            this.btn_createacc.UseVisualStyleBackColor = true;
            this.btn_createacc.Click += new System.EventHandler(this.btn_createacc_Click);
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(178, 36);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(200, 26);
            this.tbx_id.TabIndex = 35;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(178, 207);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(200, 26);
            this.txb_Phone.TabIndex = 34;
            // 
            // dtpk_Birth
            // 
            this.dtpk_Birth.Location = new System.Drawing.Point(174, 251);
            this.dtpk_Birth.Name = "dtpk_Birth";
            this.dtpk_Birth.Size = new System.Drawing.Size(280, 26);
            this.dtpk_Birth.TabIndex = 33;
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(178, 166);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(200, 26);
            this.txb_Address.TabIndex = 32;
            // 
            // txb_LName
            // 
            this.txb_LName.Location = new System.Drawing.Point(178, 122);
            this.txb_LName.Name = "txb_LName";
            this.txb_LName.Size = new System.Drawing.Size(200, 26);
            this.txb_LName.TabIndex = 31;
            // 
            // txb_FName
            // 
            this.txb_FName.Location = new System.Drawing.Point(178, 79);
            this.txb_FName.Name = "txb_FName";
            this.txb_FName.Size = new System.Drawing.Size(200, 26);
            this.txb_FName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Địa chỉ";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(260, 299);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(54, 24);
            this.rb_Female.TabIndex = 27;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(174, 299);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(67, 24);
            this.rb_Male.TabIndex = 26;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ nhân viên";
            // 
            // dtgvEmp
            // 
            this.dtgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmp.Location = new System.Drawing.Point(1, 44);
            this.dtgvEmp.Name = "dtgvEmp";
            this.dtgvEmp.RowHeadersWidth = 62;
            this.dtgvEmp.RowTemplate.Height = 28;
            this.dtgvEmp.Size = new System.Drawing.Size(625, 425);
            this.dtgvEmp.TabIndex = 6;
            this.dtgvEmp.Click += new System.EventHandler(this.dtgvEmp_Click);
            this.dtgvEmp.DoubleClick += new System.EventHandler(this.dtgvEmp_DoubleClick);
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvEmp);
            this.Controls.Add(this.PanEmployee);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1144, 472);
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddEm;
        private System.Windows.Forms.Button btn_RemoveEm;
        private System.Windows.Forms.Button btn_EditEm;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.DataGridView dtgvEmp;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.DateTimePicker dtpk_Birth;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_LName;
        private System.Windows.Forms.TextBox txb_FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Button btn_createacc;
    }
}
