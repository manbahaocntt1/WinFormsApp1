using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormEditEmployee : Form
    {
        private int index;
        private string maNV;
        private string maLuong;
         private string tenNV;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDienThoai;
        private string email;
        private string id;
        private string hocVanKinhNghiem;
        private string chucVu;
        private string phongBan;
        private string Luong;
        private string danhGiaKyLuat;

        FormEmployee f = new FormEmployee();
        public FormEditEmployee(int index , string maNV, string maLuong,
        string tenNV,
        string ngaySinh,
        string gioiTinh,
        string diaChi,
        string soDienThoai,
        string email,
        string id,
        string hocVanKinhNghiem,
        string chucVu,
        string phongBan,
        string Luong,
        string danhGiaKyLuat)
        {
            this.maLuong = maLuong;
         this.tenNV = tenNV;
            this.maNV= maNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi= diaChi;
            this.soDienThoai= soDienThoai;
            this.email= email;
            this.id= id;
            this.hocVanKinhNghiem = hocVanKinhNghiem;
            this.chucVu= chucVu;
            this.phongBan= phongBan;
            this.Luong = Luong;
            this.danhGiaKyLuat = danhGiaKyLuat;
            this.index = index;
            InitializeComponent();
        }
        public void changeText()
        {
            txtMaNV.Text = this.maNV;
            txtMaLuong.Text = this.maLuong;
            txtTenNV.Text = this.tenNV;
            txtNgaySinh.Text = this.ngaySinh;
            txtGioiTinh.Text = this.gioiTinh;
            txtDiaChi.Text=this.diaChi;
            txtSDT.Text=this.soDienThoai;
            txtEmail.Text=this.email;
            txtID.Text=this.id;
            txtHVKN.Text = this.hocVanKinhNghiem;
            txtChucVu.Text = this.chucVu;
            txtPhongBan.Text = this.phongBan;
            txtLuong.Text = this.Luong;
            txtDGKL.Text = this.danhGiaKyLuat;


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLuong;
            string tenNV;
            string ngaySinh;
            string gioiTinh;
            string diaChi;
            string soDienThoai;
            string email;
            string id;
            string hocVanKinhNghiem;
            string chucVu;
            string phongBan;
            string Luong;
            string danhGiaKyLuat;

            maLuong = txtMaLuong.Text;
            tenNV = txtTenNV.Text;
            ngaySinh = txtNgaySinh.Text;
            gioiTinh = txtGioiTinh.Text;
            diaChi = txtDiaChi.Text;
            soDienThoai = txtSDT.Text;
            email = txtEmail.Text;
            id = txtID.Text;
            hocVanKinhNghiem = txtHVKN.Text;
            chucVu = txtChucVu.Text;
            phongBan = txtPhongBan.Text;
            Luong = txtLuong.Text;
            danhGiaKyLuat = txtDGKL.Text;
            if (MessageBox.Show("Ban co chac chan muon sua ho so nhan vien?", "Xac nhan sua", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {

                Employee selectedEmployee = ListEmployee.AnInstance.ListEmployees[index];
                selectedEmployee.MaLuong = maLuong;
                selectedEmployee.TenNV = tenNV;
                selectedEmployee.NgaySinh = ngaySinh;
                selectedEmployee.GioiTinh = gioiTinh;
                selectedEmployee.DiaChi = diaChi;
                selectedEmployee.SoDienThoai = soDienThoai;
                selectedEmployee.Email = email;
                selectedEmployee.Id = id;
                selectedEmployee.HocVanKinhNghiem = hocVanKinhNghiem;
                selectedEmployee.ChucVu = chucVu;
                selectedEmployee.PhongBan = phongBan;
                selectedEmployee.Luong1 = Luong;
                selectedEmployee.DanhGiaKyLuat = danhGiaKyLuat;


                f.loadListEmployee();
                f.ShowDialog();
            }
        }

      
    }
}
