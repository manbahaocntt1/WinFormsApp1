using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Employee
    {
        private string maNV;
        private string maLuong;
        private string tenNV;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDienThoai;
        private string  email;
        private string id;
        private string hocVanKinhNghiem;
        private string chucVu;
        private string phongBan;
        private string Luong;
        private string danhGiaKyLuat;

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaLuong { get => maLuong; set => maLuong = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }
        public string HocVanKinhNghiem { get => hocVanKinhNghiem; set => hocVanKinhNghiem = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string Luong1 { get => Luong; set => Luong = value; }
        public string DanhGiaKyLuat { get => danhGiaKyLuat; set => danhGiaKyLuat = value; }

        public Employee(string maNV, string maLuong, string tenNV, string ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string email, string id, string hocVanKinhNghiem, string chucVu, string phongBan, string luong, string danhGiaKyLuat)
        {
            this.MaNV = maNV;
            this.MaLuong = maLuong;
            this.TenNV = tenNV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.Email = email;
            this.Id = id;
            this.HocVanKinhNghiem = hocVanKinhNghiem;
            this.ChucVu = chucVu;
            this.PhongBan = phongBan;
            this.Luong = luong;
            this.DanhGiaKyLuat = danhGiaKyLuat;
           
        }
    }
}
