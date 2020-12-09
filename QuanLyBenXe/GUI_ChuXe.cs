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
    public partial class GUI_ChuXe : Form
    {
        public GUI_ChuXe()
        {
            InitializeComponent();
        }

        private void GUI_ChuXe_Load(object sender, EventArgs e)
        {
            this.label1.Parent = this.pictureBox1;
            this.label2.Parent = this.pictureBox1;
            this.label3.Parent = this.pictureBox1;
            this.label4.Parent = this.pictureBox1;
            this.label5.Parent = this.pictureBox1;
            this.label6.Parent = this.pictureBox1;
            this.btnThem.Parent = this.pictureBox1;
            this.btnXoa.Parent = this.pictureBox1;
            this.btnSua.Parent = this.pictureBox1;
            this.btnThoat.Parent = this.pictureBox1;
        }
    }
}
