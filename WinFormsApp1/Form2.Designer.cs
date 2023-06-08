namespace WinFormsApp1
{
    partial class Form2
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
            btnDangXuat = new Button();
            btnThoat = new Button();
            label1 = new Label();
            btnDangNhap = new Button();
            btnQLYTaiKhoan = new Button();
            btnQLYNhanVien = new Button();
            btnLuong = new Button();
            SuspendLayout();
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.Location = new Point(599, 381);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(120, 40);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(760, 381);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 40);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(409, 27);
            label1.Name = "label1";
            label1.Size = new Size(165, 31);
            label1.TabIndex = 2;
            label1.Text = "Trang quản trị";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(102, 69);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(138, 38);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnQLYTaiKhoan
            // 
            btnQLYTaiKhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLYTaiKhoan.Location = new Point(246, 69);
            btnQLYTaiKhoan.Name = "btnQLYTaiKhoan";
            btnQLYTaiKhoan.Size = new Size(186, 38);
            btnQLYTaiKhoan.TabIndex = 5;
            btnQLYTaiKhoan.Text = "Quản lý tài khoản";
            btnQLYTaiKhoan.UseVisualStyleBackColor = true;
            btnQLYTaiKhoan.Click += btnQLYTaiKhoan_Click;
            // 
            // btnQLYNhanVien
            // 
            btnQLYNhanVien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLYNhanVien.Location = new Point(438, 69);
            btnQLYNhanVien.Name = "btnQLYNhanVien";
            btnQLYNhanVien.Size = new Size(231, 38);
            btnQLYNhanVien.TabIndex = 6;
            btnQLYNhanVien.Text = "Quản lý hồ sơ nhân viên";
            btnQLYNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnLuong
            // 
            btnLuong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuong.Location = new Point(675, 69);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new Size(179, 38);
            btnLuong.TabIndex = 7;
            btnLuong.Text = "Quản lý lương";
            btnLuong.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(btnLuong);
            Controls.Add(btnQLYNhanVien);
            Controls.Add(btnQLYTaiKhoan);
            Controls.Add(btnDangNhap);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangXuat);
            Name = "Form2";
            Text = "Trang chủ";
            FormClosing += Form2_FormClosing;
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangXuat;
        private Button btnThoat;
        private Label label1;
        private Button btnDangNhap;
        private Button btnQLYTaiKhoan;
        private Button btnQLYNhanVien;
        private Button btnLuong;
    }
}