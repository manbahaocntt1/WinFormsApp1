namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool checkTK(String userName, String password)
        {
            for (int i = 0; i < ListUser.Instance.ListAccountUsers.Count; i++)
            {
                if (userName == ListUser.Instance.ListAccountUsers[i].UserName && password == ListUser.Instance.ListAccountUsers[i].Password)


                { return true; }


            }
            return false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (checkTK(txtDangNhap.Text, txtMatKhau.Text))
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }

            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!", "Loi", MessageBoxButtons.RetryCancel);
            }

        }


        private void F_Logout(object? sender, EventArgs e)
        {
            (sender as Form2).isExit = false;
            (sender as Form2).Close();
            this.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPassword.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            if(!ckbShowPassword.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}