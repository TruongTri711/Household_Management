using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace main
{
    public partial class frmdsPhieuTu : Form
    {
        public frmdsPhieuTu()
        {
            InitializeComponent();
        }

        DataSet DSPHIEUTU()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.DSPHIEUTU";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(view);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên           
            }
            return view;
        }
        DataSet TongPhieuTu()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.TongPhieuTu";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(view);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên           
            }
            return view;
        }
        DataSet FINDPHIEUTU()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.FINDPHIEUTU '"+txttimkiem.Text+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(view);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên           
            }
            return view;
        }
        DataSet DeletePHIEUTU()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.DeletePHIEUTU '"+txtmaphieutu.Text+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(view);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên           
            }
            return view;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvphieutu_Click(object sender, EventArgs e)
        {
            int i = dgvphieutu.CurrentRow.Index;
            txtmaphieutu.Text = dgvphieutu.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvphieutu.Rows[i].Cells[1].Value.ToString();
            txtnamsinh.Text = dgvphieutu.Rows[i].Cells[2].Value.ToString();
            txtngaymat.Text = dgvphieutu.Rows[i].Cells[3].Value.ToString();
            txtlydomat.Text = dgvphieutu.Rows[i].Cells[4].Value.ToString();
            txtnoimat.Text = dgvphieutu.Rows[i].Cells[5].Value.ToString();
            txtmashk.Text = dgvphieutu.Rows[i].Cells[6].Value.ToString();

            btnxoa.Enabled = true;
            btninreport.Enabled = true;
        }

        private void frmdsPhieuTu_Load(object sender, EventArgs e)
        {
            pnchuky.Hide();

            btninreport.Enabled = false;
            btnxoa.Enabled = false;

            dgvtongphieutu.DataSource = TongPhieuTu().Tables[0];
            txttongphieutu.DataBindings.Clear();
            txttongphieutu.DataBindings.Add("Text",dgvtongphieutu.DataSource,"Tong");

            dgvphieutu.DataSource = DSPHIEUTU().Tables[0];
            txttimkiem.Select();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvphieutu.DataSource = DSPHIEUTU().Tables[0];               
            }
            else
            {
                dgvphieutu.DataSource = FINDPHIEUTU().Tables[0];
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            pnchuky.Show();
            txtchuky.Select();
        }

        private void chkhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienan.Checked)
            {
                txtchuky.UseSystemPasswordChar = false;
            }
            else
            {
                txtchuky.UseSystemPasswordChar = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            txtchuky.Clear();
            pnchuky.Hide();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                if (MessageBox.Show("Xóa lựa chọn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvdeletePT.DataSource = DeletePHIEUTU();
                    dgvphieutu.DataSource = DSPHIEUTU().Tables[0];

                    txtmaphieutu.Clear();
                    txthoten.Clear();
                    txtnamsinh.Clear();
                    txtngaymat.Clear();
                    txtlydomat.Clear();
                    txtnoimat.Clear();
                    txtmashk.Clear();

                    txtchuky.Clear();
                    pnchuky.Hide();

                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }

        private void btninreport_Click(object sender, EventArgs e)
        {
            GetData.MaPhieuTu = txtmaphieutu.Text;
            FRM_IN_PHIEU_TU frm = new FRM_IN_PHIEU_TU();
            frm.ShowDialog();
        }
    }
}
