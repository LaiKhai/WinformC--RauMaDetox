namespace Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.UsernamePicture = new System.Windows.Forms.PictureBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordPic = new System.Windows.Forms.PictureBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLogo
            // 
            this.LoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.LoginLogo.BackgroundImage = global::Login.Properties.Resources.Logo;
            this.LoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginLogo.Location = new System.Drawing.Point(100, -12);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(528, 327);
            this.LoginLogo.TabIndex = 0;
            this.LoginLogo.TabStop = false;
            // 
            // UsernamePicture
            // 
            this.UsernamePicture.BackColor = System.Drawing.Color.Transparent;
            this.UsernamePicture.BackgroundImage = global::Login.Properties.Resources.Username_1;
            this.UsernamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsernamePicture.Location = new System.Drawing.Point(14, 349);
            this.UsernamePicture.Name = "UsernamePicture";
            this.UsernamePicture.Size = new System.Drawing.Size(86, 53);
            this.UsernamePicture.TabIndex = 1;
            this.UsernamePicture.TabStop = false;
            // 
            // UsernameText
            // 
            this.UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameText.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.ForeColor = System.Drawing.Color.LimeGreen;
            this.UsernameText.Location = new System.Drawing.Point(100, 365);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(244, 31);
            this.UsernameText.TabIndex = 2;
            this.UsernameText.Text = "Username";
            this.UsernameText.Click += new System.EventHandler(this.UsernameText_Click);
            this.UsernameText.MouseEnter += new System.EventHandler(this.UsernameText_MouseEnter);
            this.UsernameText.MouseLeave += new System.EventHandler(this.UsernameText_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(34, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(34, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 3);
            this.panel2.TabIndex = 6;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.Color.LimeGreen;
            this.PasswordTxt.Location = new System.Drawing.Point(100, 448);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(244, 31);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.Text = "Password";
            this.PasswordTxt.Click += new System.EventHandler(this.PasswordTxt_Click);
            this.PasswordTxt.MouseEnter += new System.EventHandler(this.PasswordTxt_MouseEnter);
            this.PasswordTxt.MouseLeave += new System.EventHandler(this.PasswordTxt_MouseLeave);
            // 
            // PasswordPic
            // 
            this.PasswordPic.BackColor = System.Drawing.Color.Transparent;
            this.PasswordPic.BackgroundImage = global::Login.Properties.Resources.Password_1;
            this.PasswordPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordPic.Location = new System.Drawing.Point(12, 434);
            this.PasswordPic.Name = "PasswordPic";
            this.PasswordPic.Size = new System.Drawing.Size(88, 52);
            this.PasswordPic.TabIndex = 4;
            this.PasswordPic.TabStop = false;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.SignInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(34, 520);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(514, 51);
            this.SignInBtn.TabIndex = 7;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Login.Properties.Resources.giao_diện;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 623);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordPic);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.UsernamePicture);
            this.Controls.Add(this.LoginLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.PictureBox UsernamePicture;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.PictureBox PasswordPic;
        private System.Windows.Forms.Button SignInBtn;
    }
}

