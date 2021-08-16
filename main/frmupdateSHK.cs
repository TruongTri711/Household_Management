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
    public partial class frmupdateSHK : Form
    {
        public frmupdateSHK()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvSHK.DataSource = findshk().Tables[0];
        }

        private void frmupdateSHK_Load(object sender, EventArgs e)
        {
            btncapnhat.Enabled = false;
            txttimkiem.Select();           
            pnchuky.Hide();
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
                dgvSHK.DataSource = updateSHK();
                if (MessageBox.Show("Cập nhật sổ hộ khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    pnchuky.Hide();
                    txtchuky.Clear();
                    txtmashk.Clear();
                    cbodiachi.Text = "";
                    txtngaycap.Clear();
                    dgvSHK.DataSource = findshk().Tables[0];                                      
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }
        DataSet updateSHK()
        {
            DataSet update = new DataSet();
            string query = "UPDATE dbo.SOHOKHAU SET MaSHK = '" + txtmashk.Text + "', DiaChi = N'" + cbodiachi.Text + "',NgayCap = '" + txtngaycap.Text + "' WHERE MaSHK = '" + txtmashk.Text + "'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(update);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên
            }
            return update;
        }
        DataSet findshk()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.XemHK '" + txttimkiem.Text + "'";
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

        private void btncapnhat_Click_1(object sender, EventArgs e)
        {
            if (cbodiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn địa chỉ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbodiachi.Focus();
                return;
            }
            else if (txtngaycap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập ngày cấp !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtngaycap.Focus();
                return;
            }
            else
            {
                pnchuky.Show();
                txtchuky.Select();
            }
        }

        private void btndong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvupdateSHK_Click(object sender, EventArgs e)
        {
            int i = dgvSHK.CurrentRow.Index;
            txtmashk.Text = dgvSHK.Rows[i].Cells[0].Value.ToString();
            cbodiachi.Text = dgvSHK.Rows[i].Cells[1].Value.ToString();
            txtngaycap.Text = dgvSHK.Rows[i].Cells[2].Value.ToString();

            btncapnhat.Enabled = true;
        }
    }
}
