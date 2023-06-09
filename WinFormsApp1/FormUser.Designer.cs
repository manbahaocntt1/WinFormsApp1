namespace WinFormsApp1
{
    partial class FormUser
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
            label1 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            dtgvListUser = new DataGridView();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvListUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 105);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(55, 216);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 42);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(205, 216);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 42);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(348, 216);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 42);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(221, 36);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(221, 27);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(221, 109);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(221, 27);
            txtMatKhau.TabIndex = 6;
            // 
            // dtgvListUser
            // 
            dtgvListUser.BackgroundColor = SystemColors.ButtonFace;
            dtgvListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListUser.Location = new Point(477, 36);
            dtgvListUser.MultiSelect = false;
            dtgvListUser.Name = "dtgvListUser";
            dtgvListUser.ReadOnly = true;
            dtgvListUser.RowHeadersWidth = 51;
            dtgvListUser.RowTemplate.Height = 29;
            dtgvListUser.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgvListUser.Size = new Size(300, 300);
            dtgvListUser.TabIndex = 7;
            dtgvListUser.CellClick += dtgvListUser_CellClick;
           
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(55, 344);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 36);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(dtgvListUser);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private DataGridView dtgvListUser;
        private Button btnThoat;
    }
}