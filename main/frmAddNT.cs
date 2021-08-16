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
    public partial class frmAddNT : Form
    {
        public frmAddNT()
        {
            InitializeComponent();
        }

        frmAddGKS frm = new frmAddGKS();

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            // ResetValues();
        }
        void ResetValues()
        {
            txtnamsinh.Clear();
            txtmashk.Clear();

            txthoten.Clear();
            txtbidanh.Clear();
            txtnoisinh.Clear();
            txtgioitinh.Clear();
            txtnoiotruockhichuyenden.Clear();
            txtquequan.Clear();
            txtdantoc.Clear();
            txttongiao.Clear();
            txtcmnd.Clear();
            txthochieu.Clear();
            txtnghenghiep.Clear();
            txtmagks.Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SOHOKHAU WHERE MaSHK = '" + txtmashk.Text.Trim() + "'";

            if (txtmashk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã giấy sổ hộ khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmashk.Focus();
                return;
            }
            else if (cbQHchuho.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quan hệ chủ hộ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbQHchuho.Focus();
                return;
            }
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoten.Focus();
                return;
            }
            else if (txtnoisinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nơi sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnoisinh.Focus();
                return;
            }
            else if (txtgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgioitinh.Focus();
                return;
            }
            else if (txtquequan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquequan.Focus();
                return;
            }
            else if (txtdantoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantoc.Focus();
                return;
            }
            else if (txtmagks.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã giấy khai sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmagks.Focus();
                return;
            }
            
            else if (ChekKey(sql))
            {
                MessageBox.Show("Không tồn tại mã sổ hộ khẩu này, vui lòng nhập lại !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmashk.Focus();
                return;
            }
            else
            {
                pnchuky.Show();
                txtchuky.Select();
            }           
        }
        DataSet insertNT()
        {
            DataSet view = new DataSet();
            string query = "INSERT dbo.NHANTHAN VALUES ( '"+txtmashk.Text+"' , N'"+cbQHchuho.Text+"' , N'"+txthoten.Text+"' , N'"+txtbidanh.Text+"' , '"+txtnamsinh.Text+"' , N'"+txtnoisinh.Text+"' , N'"+txtgioitinh.Text+"' , N'"+txtquequan.Text+"' , N'"+txtdantoc.Text+"' , N'"+txttongiao.Text+"' , '"+txtcmnd.Text+"' , '"+txthochieu.Text+"' , N'"+txtnghenghiep.Text+"' , '"+dtpchuyendenngay.Text+"' , N'"+txtnoiotruockhichuyenden.Text+"' , '"+txtmagks.Text+"' )";
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
        DataSet laythongtingiongnhaubenGKS()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.FindGKS '" + txtfindGKS.Text + "'";
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
        bool ChekKey(string sql)
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

        private void frmAddNT_Load(object sender, EventArgs e)
        {
            pnchuky.Hide();

            dgvGKS.DataSource = laythongtingiongnhaubenGKS().Tables[0];

            txthoten.DataBindings.Clear();
            txthoten.DataBindings.Add("Text", dgvGKS.DataSource, "HoTen");
            txtnamsinh.DataBindings.Clear();
            txtnamsinh.DataBindings.Add("Text", dgvGKS.DataSource, "NamSinh");
            txtgioitinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Add("Text", dgvGKS.DataSource, "GioiTinh");
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", dgvGKS.DataSource, "NoiSinh");
            txtdantoc.DataBindings.Clear();
            txtdantoc.DataBindings.Add("Text", dgvGKS.DataSource, "DanToc");
            txtquequan.DataBindings.Clear();
            txtquequan.DataBindings.Add("Text", dgvGKS.DataSource, "QueQuan");
            txtmagks.DataBindings.Clear();
            txtmagks.DataBindings.Add("Text", dgvGKS.DataSource, "MaGKS");

            cbQHchuho.Text = "Con";
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

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                dgvinsertNT.DataSource = insertNT();
                if (MessageBox.Show("Thêm nhân thân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtchuky.Clear();
                    pnchuky.Hide();
                    ResetValues();

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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            pnchuky.Hide();
            txtchuky.Clear();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
