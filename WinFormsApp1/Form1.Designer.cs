namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDangNhap = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            txtDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            ckbShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(290, 302);
            btnDangNhap.Margin = new Padding(4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(239, 39);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng nhập tài khoản";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(602, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 39);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 81);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 165);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(359, 93);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(270, 31);
            txtDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(359, 177);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(270, 31);
            txtMatKhau.TabIndex = 5;
            // 
            // ckbShowPassword
            // 
            ckbShowPassword.AutoSize = true;
            ckbShowPassword.Location = new Point(344, 236);
            ckbShowPassword.Name = "ckbShowPassword";
            ckbShowPassword.Size = new Size(187, 29);
            ckbShowPassword.TabIndex = 6;
            ckbShowPassword.Text = "Hiển thị mật khẩu";
            ckbShowPassword.UseVisualStyleBackColor = true;
            ckbShowPassword.CheckedChanged += ckbShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(715, 385);
            Controls.Add(ckbShowPassword);
            Controls.Add(txtMatKhau);
            Controls.Add(txtDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Đăng nhập";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangNhap;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private TextBox txtDangNhap;
        private TextBox txtMatKhau;
        private CheckBox ckbShowPassword;
    }
}