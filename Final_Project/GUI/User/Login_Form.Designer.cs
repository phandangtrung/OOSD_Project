namespace Final_Project.GUI.User
{
    partial class Login_Form
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
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpassword
            // 
            this.tbpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbpassword.Location = new System.Drawing.Point(14, 280);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(349, 28);
            this.tbpassword.TabIndex = 5;
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbusername.Location = new System.Drawing.Point(14, 198);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(349, 28);
            this.tbusername.TabIndex = 4;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Silver;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btncancel.Location = new System.Drawing.Point(12, 411);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(349, 57);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Thoát";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Silver;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnlogin.Location = new System.Drawing.Point(12, 338);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(349, 58);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbpassword);
            this.panel1.Controls.Add(this.tbusername);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 479);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label2.Location = new System.Drawing.Point(20, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label1.Location = new System.Drawing.Point(20, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F);
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.label3.Location = new System.Drawing.Point(72, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 69);
            this.label3.TabIndex = 9;
            this.label3.Text = "LOGIN";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 486);
            this.Controls.Add(this.panel1);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}