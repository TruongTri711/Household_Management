using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tknd = "user";
                string mknd = "123456";
                string tkad = "admin";
                string mkad = "123456";

                if (txttk.Text == tknd && txtmk.Text == mknd )
                {
                    frmUser fm = new frmUser();
                    fm.ShowDialog();
                    txttk.Clear();
                    txtmk.Clear();
                    txttk.Select();
                }
                else if (txttk.Text == tkad && txtmk.Text == mkad)
                {
                    frmAdmin fm = new frmAdmin();
                    fm.ShowDialog();
                    txttk.Clear();
                    txtmk.Clear();
                    txttk.Select();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void formdangnhap_Load(object sender, EventArgs e)
        {
            txttk.Select();

        }

        private void chkhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienan.Checked)
            {
                txtmk.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString().ToString();
        }
    }
}
