using DashBoar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        private void UsernameText_Click(object sender, EventArgs e)
        {
                UsernameText.Clear();
                UsernamePicture.BackgroundImage = Properties.Resources.Username_21;   
        }

        private void UsernameText_MouseEnter(object sender, EventArgs e)
        {
            UsernamePicture.BackgroundImage = Properties.Resources.Username_21;
            
        }

        private void UsernameText_MouseLeave(object sender, EventArgs e)
        {
            UsernamePicture.BackgroundImage = Properties.Resources.Username_11;
        }

        private void PasswordTxt_Click(object sender, EventArgs e)
        {
            PasswordTxt.Clear();
            PasswordPic.BackgroundImage = Properties.Resources.Password_11;
        }

        private void PasswordTxt_MouseEnter(object sender, EventArgs e)
        {
            PasswordPic.BackgroundImage = Properties.Resources.Password_21;
        }

        private void PasswordTxt_MouseLeave(object sender, EventArgs e)
        {
            PasswordPic.BackgroundImage = Properties.Resources.Password_11;
        }
        private void DangNhap()
        {
            LoginForm fm1 = new LoginForm();
            if (this.UsernameText.Text.Length == 0 && this.PasswordTxt.Text.Length == 0)
            {
                MessageBox.Show(" Bạn chưa nhập Username hoặc Password !");
            }
            else
                if (this.PasswordTxt.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu !");
            }
            else
                      if (this.UsernameText.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập UserName !");
            }
            else
                if (this.UsernameText.Text == "Adminstrator" && this.PasswordTxt.Text == "123456789")
            {
                MessageBox.Show("Đăng nhập thành công !");
                fm1.Close();
            }
            else
                MessageBox.Show("Đăng Nhập Thất Bại !");
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            if (UsernameText.Text == "Adminstrator" && PasswordTxt.Text == "123456789")
            {
                fm.Show();
            }
            DangNhap();
        }
    }
}
