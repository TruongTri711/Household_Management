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
    public partial class frmupdateCMND : Form
    {
        public frmupdateCMND()
        {
            InitializeComponent();
        }

        private void frmupdateCMND_Load(object sender, EventArgs e)
        {
            btncapnhat.Enabled = false;
            txttimkiem.Select();
            pnchuky.Hide();            
        }
        DataSet laydsCMND()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.DsCMND";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(lay);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên
            }

            return lay;
        }
        DataSet findCMND()
        {
            DataSet lay = new DataSet();
            string query = "SELECT * FROM dbo.CMND WHERE CMND = '"+txttimkiem.Text+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(lay);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên
            }

            return lay;
        }

        private void dgvupdateCMND_Click(object sender, EventArgs e)
        {
            int i = dgvupdateCMND.CurrentRow.Index;
            txtmaso.Text = dgvupdateCMND.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvupdateCMND.Rows[i].Cells[1].Value.ToString();
            dtpnamsinh.Text = dgvupdateCMND.Rows[i].Cells[2].Value.ToString();
            txtnguyenquan.Text = dgvupdateCMND.Rows[i].Cells[3].Value.ToString();
            txtnoicap.Text = dgvupdateCMND.Rows[i].Cells[4].Value.ToString();
            dtpngaycap.Text = dgvupdateCMND.Rows[i].Cells[5].Value.ToString();

            btncapnhat.Enabled = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvupdateCMND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txtmaso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtchuky.Clear();
            pnchuky.Hide();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                if (MessageBox.Show("Cập nhật CMND thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvupdateCMND.DataSource = updateCMND();
                    txtchuky.Clear();
                    pnchuky.Hide();
                    Reset();
                    dgvupdateCMND.DataSource = findCMND().Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }
        DataSet updateCMND()
        {
            DataSet update = new DataSet();
            string query = "UPDATE dbo.CMND SET CMND = '" + txtmaso.Text+"', HoTen = N'"+txthoten.Text+"', NamSinh = '"+dtpnamsinh.Text+"',NguyenQuan = N'"+txtnguyenquan.Text+"',NoiCap = N'"+txtnoicap.Text+"',NgayCap = '"+dtpngaycap.Text+"' WHERE CMND = '"+txtmaso.Text+"'";
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
        void Reset()
        {
            txtmaso.Clear();
            txthoten.Clear();
            txtnguyenquan.Clear();
            txtnoicap.Clear();
        }

        private void btnfindmashk_Click(object sender, EventArgs e)
        {
            dgvupdateCMND.DataSource = findCMND().Tables[0];
            txthoten.Clear();
            txtnguyenquan.Clear();
            txtnoicap.Clear();

        }
    }
}
