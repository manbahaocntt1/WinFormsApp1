using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class FormEmployee : Form
    {
        
        public int index = -1;
        public FormEmployee()
        {
            InitializeComponent();
        }
        public void loadListEmployee()
        {
            dtgvEmployee.DataSource = null;
            dtgvEmployee.DataSource = ListEmployee.AnInstance.ListEmployees;
            dtgvEmployee.Refresh();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormAddEmployee f = new FormAddEmployee();
            f.ShowDialog();
            this.Hide();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            loadListEmployee();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (index < 0)
            {
                MessageBox.Show("Vui long chon 1 ban ghi!", "Thong bao", MessageBoxButtons.OK);
            }

            else
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
                maNV = dtgvEmployee.Rows[index].Cells[0].Value.ToString();
                maLuong= dtgvEmployee.Rows[index].Cells[1].Value.ToString();
                tenNV= dtgvEmployee.Rows[index].Cells[2].Value.ToString();
                ngaySinh= dtgvEmployee.Rows[index].Cells[3].Value.ToString();
                gioiTinh= dtgvEmployee.Rows[index].Cells[4].Value.ToString();
                diaChi= dtgvEmployee.Rows[index].Cells[5].Value.ToString();
                soDienThoai= dtgvEmployee.Rows[index].Cells[6].Value.ToString();
                email= dtgvEmployee.Rows[index].Cells[7].Value.ToString();
                id= dtgvEmployee.Rows[index].Cells[8].Value.ToString();
                hocVanKinhNghiem= dtgvEmployee.Rows[index].Cells[9].Value.ToString();
                chucVu= dtgvEmployee.Rows[index].Cells[10].Value.ToString();
                phongBan= dtgvEmployee.Rows[index].Cells[11].Value.ToString();
                Luong= dtgvEmployee.Rows[index].Cells[12].Value.ToString();
                danhGiaKyLuat= dtgvEmployee.Rows[index].Cells[13].Value.ToString();
                FormEditEmployee f = new FormEditEmployee(index,maNV,maLuong,tenNV,ngaySinh,gioiTinh,diaChi,soDienThoai,email,id,hocVanKinhNghiem,chucVu,phongBan,Luong,danhGiaKyLuat);
                f.changeText();
                f.ShowDialog();
            }

        }

        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index = e.RowIndex;
            if (index < 0)
                return;
           





        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui long chon 1 ban ghi!", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Ban co chac chan muon xoa ho so?", "Xac nhan xoa", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    ListEmployee.AnInstance.ListEmployees.RemoveAt(index);
                    loadListEmployee();
                }
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
