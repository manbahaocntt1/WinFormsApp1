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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            
            string maNV;
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
            maNV = txtMaNV.Text;
            maLuong = txtLMauong.Text;
            tenNV = txtTenNV.Text;
            ngaySinh = txtNgaySinh.Text;
            gioiTinh = txtGioiTinh.Text;
            diaChi=txtDiaChi.Text;
            soDienThoai = txtSDT.Text;
            email = txtEmail.Text;
            id = txtID.Text;
            hocVanKinhNghiem=txtHVKN.Text;
            chucVu=txtChucVu.Text;
            phongBan=txtPhongBan.Text;
            Luong=txtLuong.Text;
            danhGiaKyLuat = txtDGKL.Text;
            if (MessageBox.Show("Ban co chac chan muon them ho so nhan vien?", "Xac nhan them", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                ListEmployee.AnInstance.ListEmployees.Add(new Employee(maNV,maLuong, tenNV, ngaySinh, gioiTinh, diaChi, soDienThoai, email,id, hocVanKinhNghiem,chucVu,phongBan,Luong,danhGiaKyLuat));
                
                FormEmployee f = new FormEmployee();
                f.loadListEmployee();
                f.ShowDialog();
            }    

        }
    }
}
