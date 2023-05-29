using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class fMucLuc : Form
    {
        public fMucLuc()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            fBai1 Bai1 = new fBai1();
            Bai1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            fBai2 Bai2 = new fBai2();
            Bai2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            fBai3 Bai3 = new fBai3();
            Bai3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            fBai4 Bai4 = new fBai4();
            Bai4.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            fBai5 Bai5 = new fBai5();
            Bai5.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            fBai6 Bai6 = new fBai6();
            Bai6.Show();
        }
    }
}
