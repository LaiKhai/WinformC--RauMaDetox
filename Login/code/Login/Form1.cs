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
                UsernamePicture.BackgroundImage = Properties.Resources.Username_2;   
        }

        private void UsernameText_MouseEnter(object sender, EventArgs e)
        {
            UsernamePicture.BackgroundImage = Properties.Resources.Username_2;
            
        }

        private void UsernameText_MouseLeave(object sender, EventArgs e)
        {
            UsernamePicture.BackgroundImage = Properties.Resources.Username_1;
        }

        private void PasswordTxt_Click(object sender, EventArgs e)
        {
            PasswordTxt.Clear();
            PasswordPic.BackgroundImage = Properties.Resources.Password_1;
        }

        private void PasswordTxt_MouseEnter(object sender, EventArgs e)
        {
            PasswordPic.BackgroundImage = Properties.Resources.Password_2;
        }

        private void PasswordTxt_MouseLeave(object sender, EventArgs e)
        {
            PasswordPic.BackgroundImage = Properties.Resources.Password_1;
        }
    }
}
