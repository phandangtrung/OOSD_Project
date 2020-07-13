namespace Final_Project.GUI.Admin
{
    partial class UC_Account
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
            this.btn_RemoveAcc = new System.Windows.Forms.Button();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_updateAcc = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_idem = new System.Windows.Forms.TextBox();
            this.rb_ware = new System.Windows.Forms.RadioButton();
            this.rb_sale = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.PanEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RemoveAcc
            // 
            this.btn_RemoveAcc.Location = new System.Drawing.Point(347, 368);
            this.btn_RemoveAcc.Name = "btn_RemoveAcc";
            this.btn_RemoveAcc.Size = new System.Drawing.Size(112, 40);
            this.btn_RemoveAcc.TabIndex = 3;
            this.btn_RemoveAcc.Text = "xoá";
            this.btn_RemoveAcc.UseVisualStyleBackColor = true;
            this.btn_RemoveAcc.Click += new System.EventHandler(this.btn_RemoveAcc_Click);
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(178, 79);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(200, 26);
            this.txb_username.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên đăng nhập";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 44);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 62;
            this.dtgvAccount.RowTemplate.Height = 28;
            this.dtgvAccount.Size = new System.Drawing.Size(625, 425);
            this.dtgvAccount.TabIndex = 8;
            this.dtgvAccount.Click += new System.EventHandler(this.dtgvAccount_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_updateAcc);
            this.PanEmployee.Controls.Add(this.txb_name);
            this.PanEmployee.Controls.Add(this.Tên);
            this.PanEmployee.Controls.Add(this.label1);
            this.PanEmployee.Controls.Add(this.txb_idem);
            this.PanEmployee.Controls.Add(this.rb_ware);
            this.PanEmployee.Controls.Add(this.rb_sale);
            this.PanEmployee.Controls.Add(this.rbAdmin);
            this.PanEmployee.Controls.Add(this.btn_RemoveAcc);
            this.PanEmployee.Controls.Add(this.txb_username);
            this.PanEmployee.Controls.Add(this.label8);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(634, 43);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(506, 427);
            this.PanEmployee.TabIndex = 7;
            // 
            // btn_updateAcc
            // 
            this.btn_updateAcc.Location = new System.Drawing.Point(131, 368);
            this.btn_updateAcc.Name = "btn_updateAcc";
            this.btn_updateAcc.Size = new System.Drawing.Size(112, 40);
            this.btn_updateAcc.TabIndex = 42;
            this.btn_updateAcc.Text = "Chỉnh ";
            this.btn_updateAcc.UseVisualStyleBackColor = true;
            this.btn_updateAcc.Click += new System.EventHandler(this.btn_updateAcc_Click);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(178, 124);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(200, 26);
            this.txb_name.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(27, 124);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(116, 20);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã nhân viên";
            // 
            // txb_idem
            // 
            this.txb_idem.Location = new System.Drawing.Point(178, 36);
            this.txb_idem.Name = "txb_idem";
            this.txb_idem.Size = new System.Drawing.Size(200, 26);
            this.txb_idem.TabIndex = 38;
            // 
            // rb_ware
            // 
            this.rb_ware.AutoSize = true;
            this.rb_ware.Location = new System.Drawing.Point(380, 213);
            this.rb_ware.Name = "rb_ware";
            this.rb_ware.Size = new System.Drawing.Size(91, 24);
            this.rb_ware.TabIndex = 37;
            this.rb_ware.TabStop = true;
            this.rb_ware.Text = "Thủ kho";
            this.rb_ware.UseVisualStyleBackColor = true;
            // 
            // rb_sale
            // 
            this.rb_sale.AutoSize = true;
            this.rb_sale.Location = new System.Drawing.Point(271, 213);
            this.rb_sale.Name = "rb_sale";
            this.rb_sale.Size = new System.Drawing.Size(103, 24);
            this.rb_sale.TabIndex = 36;
            this.rb_sale.TabStop = true;
            this.rb_sale.Text = "Bán hàng";
            this.rb_sale.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(178, 213);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(87, 24);
            this.rbAdmin.TabIndex = 35;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Quản lý";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.PanEmployee);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(1144, 472);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_RemoveAcc;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.RadioButton rb_sale;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rb_ware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_idem;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_updateAcc;
    }
}
