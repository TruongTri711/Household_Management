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
    public partial class frmdkCMND : Form
    {
        public frmdkCMND()
        {
            InitializeComponent();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            txtmaso.Clear();
            txthoten.Clear();
            txtnguyenquan.Clear();
            txtnoicap.Clear();
            dtpnamsinh.Clear();
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "EXEC dbo.KTKEYCMND '"+txtmaso.Text+"'";
            if (txtmaso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã số","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmaso.Focus();
                return;
            }
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoten.Focus();
                return;
            }
            else if (txtnguyenquan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nguyên quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnguyenquan.Focus();
                return;
            }
            else if (txtnoicap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nơi cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnoicap.Focus();
                return;
            }
            else if(Checkkey(sql))
            {
                MessageBox.Show("Mã số CMND đã tồn tại, vui lòng nhập mã số khác !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmaso.Focus();
                return;
            }
            else
            {
                pnchuky.Show();
                txtchuky.Select();
            }
        }

        private void frmdkCMND_Load(object sender, EventArgs e)
        {
            txtmaso.Enabled = false;
            txthoten.Enabled = false;
            dtpnamsinh.Enabled = false;
            txtnguyenquan.Enabled = false;
            txtnoicap.Enabled = false;
            btnluu.Enabled = false;
            btnlammoi.Enabled = false;

            dgvchuacoCMND.DataSource = dschuacoCMND().Tables[0];
            pnchuky.Hide();
        }

        bool Checkkey(string sql)
        {
            SqlConnection con = new SqlConnection(Connectionstring.connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
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
                
                if (MessageBox.Show("Đăng ký CMND và cập nhật CMND vào hộ khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvinsertCMND.DataSource = insertCMND();
                    dgvupdateNT.DataSource = updateNT();
                    dgvchuacoCMND.DataSource = dschuacoCMND().Tables[0];

                    txtchuky.Clear();
                    pnchuky.Hide();
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }
        DataSet insertCMND()
        {
            DataSet insert = new DataSet();
            string query = "INSERT dbo.CMND VALUES  ( '"+txtmaso.Text+"', N'"+txthoten.Text+"' , '"+dtpnamsinh.Text+"' , N'"+txtnguyenquan.Text+"' , N'"+txtnoicap.Text+"' , '"+dtpngaycap.Text+"' )";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(insert);
                con.Close();
                con.Dispose();
            }
            return insert;
        }
        DataSet updateNT()
        {
            DataSet insert = new DataSet();
            string query = "UPDATE NHANTHAN SET CMND = '"+txtmaso.Text+"' WHERE HoTen LIKE N'"+txthoten.Text+"' AND NamSinh = '"+dtpnamsinh.Text+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(insert);
                con.Close();
                con.Dispose();
            }
            return insert;
        }
        DataSet dschuacoCMND()
        {
            DataSet insert = new DataSet();
            string query = "SELECT HoTen, NamSinh, QueQuan FROM dbo.NHANTHAN WHERE CMND = ''";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(insert);
                con.Close();
                con.Dispose();
            }
            return insert;
        }

        private void dgvchuacoCMND_Click(object sender, EventArgs e)
        {
            int i = dgvchuacoCMND.CurrentRow.Index;
            txthoten.Text = dgvchuacoCMND.Rows[i].Cells[0].Value.ToString();
            dtpnamsinh.Text = dgvchuacoCMND.Rows[i].Cells[1].Value.ToString();
            txtnguyenquan.Text = dgvchuacoCMND.Rows[i].Cells[2].Value.ToString();

            txtmaso.Enabled = true;
            txthoten.Enabled = true;
            dtpnamsinh.Enabled = true;
            txtnguyenquan.Enabled = true;
            txtnoicap.Enabled = true;
            btnluu.Enabled = true;
            btnlammoi.Enabled = true;
            txtmaso.Clear();
            txtnoicap.Clear();
        }
    }
}
