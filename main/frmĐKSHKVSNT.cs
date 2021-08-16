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
    public partial class frmĐKSHKVSNT : Form
    {
        public frmĐKSHKVSNT()
        {
            InitializeComponent();
        }

        private void frmdkSHK_Load(object sender, EventArgs e)
        {
            dgvNT.DataSource = findNTsaukhidangkySHK().Tables[0];

            txthoten.DataBindings.Clear();
            txthoten.DataBindings.Add("Text", dgvNT.DataSource, "HoTen");
            txtbidanh.DataBindings.Clear();
            txtbidanh.DataBindings.Add("Text", dgvNT.DataSource, "BiDanh");
            txtnamsinh.DataBindings.Clear();
            txtnamsinh.DataBindings.Add("Text", dgvNT.DataSource, "NamSinh");
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", dgvNT.DataSource, "NoiSinh");
            txtgioitinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Add("Text", dgvNT.DataSource, "GioiTinh");
            txtquequan.DataBindings.Clear();
            txtquequan.DataBindings.Add("Text", dgvNT.DataSource, "QueQuan");
            txtdantoc.DataBindings.Clear();
            txtdantoc.DataBindings.Add("Text", dgvNT.DataSource, "DanToc");
            txttongiao.DataBindings.Clear();
            txttongiao.DataBindings.Add("Text", dgvNT.DataSource, "TonGiao");
            txtcmnd.DataBindings.Clear();
            txtcmnd.DataBindings.Add("Text", dgvNT.DataSource, "CMND");
            txthochieu.DataBindings.Clear();
            txthochieu.DataBindings.Add("Text", dgvNT.DataSource, "HoChieuSo");
            txtnghenghiep.DataBindings.Clear();
            txtnghenghiep.DataBindings.Add("Text", dgvNT.DataSource, "NgheNghiep");
            txtchuyendenngay.DataBindings.Clear();
            txtchuyendenngay.DataBindings.Add("Text", dgvNT.DataSource, "ChuyenDenNgay");
            txtnoiotruockhichuyenden.DataBindings.Clear();
            txtnoiotruockhichuyenden.DataBindings.Add("Text", dgvNT.DataSource, "NoiOTruocKhiChuyenDen");
            txtmagks.DataBindings.Clear();
            txtmagks.DataBindings.Add("Text", dgvNT.DataSource, "MaGKS");

            btnluu.Enabled = true;

            // lấy dữ liệu từ tên và namsinh


            lblkhidangky.Hide();
            lblkhikhonfdangky.Hide();

            pnchuky.Hide();
            lblthemNT.Enabled = false;
            grbthannhan.Enabled = false;
            btnluu.Enabled = false;
        }
        DataSet updateNT()
        {
            DataSet find = new DataSet();
            string query = "UPDATE dbo.NHANTHAN SET MaSHK = '" + txtmashkthemNT.Text + "', QHCHUHO = N'" + cboqhchuho.SelectedItem+"' WHERE HoTen = N'"+txthoten.Text+"' AND NamSinh = '"+txtnamsinh.Text+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(find);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên
            }
            return find;
        }
        DataSet findNTsaukhidangkySHK()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.findNTsaukhidangkySHK N'"+txtchuahoten.Text+"' , '"+txtchuanamsinh.Text+"'";
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
        DataSet insertSHK()
        {
            DataSet view = new DataSet();
            string query = "INSERT dbo.SOHOKHAU VALUES( '" + txtmashk.Text + "', N'" + cbdiachi.SelectedItem + "', '" + dtpngaycap.Text + "' )";
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

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaSHK FROM SOHOKHAU WHERE MaSHK = '"+txtmashk.Text+"'";
            if (txtmashk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Mã sổ hộ khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmashk.Focus();
                return;
            }
            if (cbdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbdiachi.Focus();
                return;
            }
            else if (ChekKeyMaSHK(sql))
            {
                MessageBox.Show("Mã sổ hộ khẩu đã tồn tại, vui lòng nhập lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmashk.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Đăng ký sổ hộ khẩu thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvinsertSHK.DataSource = insertSHK();

                    grbdkshk.Enabled = false;
                    lbldkshk.Enabled = false;
                    lblthemNT.Enabled = true;
                    grbthannhan.Enabled = true;

                    lblkhidangky.Show();
                    lblkhikhonfdangky.Hide();
                    btnluu.Enabled = true;
                }         
            }            
        }
        bool ChekKeyMaSHK(string sql)
        {
            SqlConnection con = new SqlConnection(Connectionstring.connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool ChekKeyMaSHKLuu(string sql)
        {
            SqlConnection con = new SqlConnection(Connectionstring.connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaSHK FROM SOHOKHAU WHERE MaSHK = '" + txtmashkthemNT.Text + "'";

            if (txtmashkthemNT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã sổ hộ khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmashkthemNT.Focus();
                return;
            }
            else if (cboqhchuho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ chủ hộ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboqhchuho.Focus();
                return;
            }
            else if (ChekKeyMaSHKLuu(sql))
            {
                MessageBox.Show("Không tồn tại mã sổ hộ khẩu này, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmashkthemNT.Focus();
                return;
            }
            else
            {
                pnchuky.Show();
                txtchuky.Select();
            }            
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
            pnchuky.Hide();
            txtchuky.Clear();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                if (MessageBox.Show("Thêm nhân thân thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvupdateNT.DataSource = updateNT();
                    txtchuky.Clear();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }

        private void txtkhongdangky_Click(object sender, EventArgs e)
        {
            lbldkshk.Enabled = false;
            grbdkshk.Enabled = false;
            btntieptuc.Enabled = false;
            btnkhongdangky.Enabled = false;
            lblthemNT.Enabled = true;
            grbthannhan.Enabled = true;
            btnluu.Enabled = true;

            lblkhidangky.Hide();
            lblkhikhonfdangky.Show();
        }
    }
}
