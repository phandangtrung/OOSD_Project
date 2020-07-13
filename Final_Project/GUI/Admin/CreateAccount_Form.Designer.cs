namespace Final_Project.GUI.Admin
{
    partial class CreateAccount_Form
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
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.rb_ware = new System.Windows.Forms.RadioButton();
            this.rb_sale = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.rb_ware);
            this.PanEmployee.Controls.Add(this.rb_sale);
            this.PanEmployee.Controls.Add(this.rbAdmin);
            this.PanEmployee.Controls.Add(this.btn_Create);
            this.PanEmployee.Controls.Add(this.btn_Cancel);
            this.PanEmployee.Controls.Add(this.txb_username);
            this.PanEmployee.Controls.Add(this.label8);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(12, 11);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(485, 211);
            this.PanEmployee.TabIndex = 8;
            // 
            // rb_ware
            // 
            this.rb_ware.AutoSize = true;
            this.rb_ware.Location = new System.Drawing.Point(369, 62);
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
            this.rb_sale.Location = new System.Drawing.Point(260, 62);
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
            this.rbAdmin.Location = new System.Drawing.Point(167, 62);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(87, 24);
            this.rbAdmin.TabIndex = 35;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Quản lý";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(164, 158);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(112, 40);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.Text = "Xoá nhân viên";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(297, 158);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 40);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(164, 20);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(200, 26);
            this.txb_username.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên đăng nhập";
            // 
            // CreateAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 231);
            this.Controls.Add(this.PanEmployee);
            this.Name = "CreateAccount_Form";
            this.Text = "CreateAccount_Form";
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.RadioButton rb_ware;
        private System.Windows.Forms.RadioButton rb_sale;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}