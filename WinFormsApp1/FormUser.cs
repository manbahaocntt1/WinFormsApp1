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
    public partial class FormUser : Form
    {

        public static Random Random = new Random();
        int index = -1;
        public FormUser()
        {
            InitializeComponent();
        }
        void loadListUser()
        {
            dtgvListUser.DataSource = null;
            dtgvListUser.DataSource = ListUser.Instance.ListAccountUsers;
            dtgvListUser.Refresh();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string userName, passWord;
            userName = txtTaiKhoan.Text;
            passWord = txtMatKhau.Text;
            
            if (MessageBox.Show("Ban co chac chan muon them tai khoan?", "Xac nhan them", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                ListUser.Instance.ListAccountUsers.Add(new User(userName, passWord));
                loadListUser();
            }    
                
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            loadListUser();
        }

        private void dtgvListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0)
                return;
            txtTaiKhoan.Text = dtgvListUser.Rows[index].Cells[0].Value.ToString();
            txtMatKhau.Text = dtgvListUser.Rows[index].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui long chon 1 ban ghi!", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                string passWord;

                passWord = Random.Next(1000, 10000000).ToString();

                if (MessageBox.Show("Ban co chac chan muon sua tai khoan?", "Xac nhan sua", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    ListUser.Instance.ListAccountUsers[index].Password = passWord;
                    txtMatKhau.Text = passWord;
                    loadListUser();
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui long chon 1 ban ghi!", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                ListUser.Instance.ListAccountUsers.RemoveAt(index);
                if (MessageBox.Show("Ban co chac chan muon xoa tai khoan?", "Xac nhan xoa", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {

                    loadListUser();
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
