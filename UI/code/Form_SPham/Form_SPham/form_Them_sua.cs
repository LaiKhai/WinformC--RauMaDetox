﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Form_SPham
{
    
    public partial class form_Them_sua : Form
    {
        public form_Them_sua()
        {
            InitializeComponent();
        }

        private void btn_taianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Hinh Anh|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr != System.Windows.Forms.DialogResult.Cancel) //co chon file
            {
                byte[] byteHA = File.ReadAllBytes(ofd.FileName);
                MemoryStream ms = new MemoryStream(byteHA);
               ptb_anhtai.Image = Image.FromStream(ms);
            }
            else
            {
                ptb_anhtai.Image = null;
            }
        }
    }
}
