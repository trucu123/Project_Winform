using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            this.label1.Parent = this.pictureBox1;
            this.label2.Parent = this.pictureBox1;
            this.label3.Parent = this.pictureBox1;
            this.btnDangnhap.Parent = this.pictureBox1;
            this.btnThoat.Parent = this.pictureBox1;
        }
    }
}
