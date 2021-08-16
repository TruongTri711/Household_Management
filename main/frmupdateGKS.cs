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
    public partial class frmupdateGKS : Form
    {
        public frmupdateGKS()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvupdateGKS.DataSource = XemGKS().Tables[0];
        }
        DataSet XemGKS()
        {
            DataSet view = new DataSet();
            string query = "EXEC FindGKS '" + txttimkiem.Text + "'";
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

        private void frmupdateGKS_Load(object sender, EventArgs e)
        {
            btncapnhat.Enabled = false;
            pnchuky.Hide();
            txttimkiem.Select();
        }

        void ResetValues()
        {
            dtpnamsinh.Clear();
            txtmagks.Clear();
            txthoten.Clear();
            cbgioitinh.SelectedItem = null;
            txtnoisinh.Clear();
            txtdantoc.Clear();
            txtquoctich.Clear();
            txtquequan.Clear();
            txthotencha.Clear();
            txtdantoccha.Clear();
            txtquoctichcha.Clear();
            txthotenme.Clear();
            txtdantocme.Clear();
            txtquoctichme.Clear();
            txtngdiKS.Clear();
            cbqhngks.SelectedItem = null;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txtmagks.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã giấy khai sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmagks.Focus();
                return;
            }
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoten.Focus();
                return;
            }
            else if (cbgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbgioitinh.Focus();
                return;
            }
            else if (txtnoisinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nơi sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnoisinh.Focus();
                return;
            }
            else if (txtdantoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantoc.Focus();
                return;
            }
            else if (txtquoctich.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquoctich.Focus();
                return;
            }
            else if (txtquequan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquequan.Focus();
                return;
            }
            else if (txthotencha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthotencha.Focus();
                return;
            }
            else if (txtdantoccha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantoccha.Focus();
                return;
            }
            else if (txtquoctichcha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquoctichcha.Focus();
                return;
            }
            else if (txthotenme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthotenme.Focus();
                return;
            }
            else if (txtdantocme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantocme.Focus();
                return;
            }
            else if (txtquoctichme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquoctichme.Focus();
                return;
            }
            else if (txtngdiKS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên người đi khai sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtngdiKS.Focus();
                return;
            }
            else if (cbqhngks.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ với người khai sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbqhngks.Focus();
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
                dgvupdateGKS.DataSource = updateGKS();
                if (MessageBox.Show("Cập nhật giấy khai sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtchuky.Clear();
                    pnchuky.Hide();
                    ResetValues();
                    dgvupdateGKS.DataSource = XemGKS().Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }
        DataSet updateGKS()
        {
            DataSet update = new DataSet();
            string query = "UPDATE dbo.GIAYKHAISINH SET MaGKS = '"+txtmagks.Text+"', HoTen = N'"+txthoten.Text+"', GioiTinh = N'"+cbgioitinh.SelectedItem+"', NamSinh = '"+dtpnamsinh.Text+"', NoiSinh = N'"+txtnoisinh.Text+"', DanToc = N'"+txtdantoc.Text+"', QuocTich = N'"+txtquoctich.Text+"', QueQuan = N'"+txtquequan.Text+"', HotenCha = N'"+txthotencha.Text+"', DanTocCha = N'"+txtdantoccha.Text+"', QuocTichCha = N'"+txtquoctichcha.Text+"', HotenMe = N'"+txthotenme.Text+"', DanTocMe = N'"+txtdantocme.Text+"', QuocTichMe = N'"+txtquoctichme.Text+"', HoTenNguoiDiKhaiSinh = N'"+txtngdiKS.Text+"', QHNguoiKhaiSinh = N'"+cbqhngks.Text+"', NgayDangKy = '"+dtpngaydangky.Text+"' WHERE MaGKS = '"+txtmagks.Text+"'";
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

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvupdateGKS_Click(object sender, EventArgs e)
        {
            int i = dgvupdateGKS.CurrentRow.Index;
            txtmagks.Text = dgvupdateGKS.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvupdateGKS.Rows[i].Cells[1].Value.ToString();
            cbgioitinh.Text = dgvupdateGKS.Rows[i].Cells[2].Value.ToString();
            dtpnamsinh.Text = dgvupdateGKS.Rows[i].Cells[3].Value.ToString();
            txtnoisinh.Text = dgvupdateGKS.Rows[i].Cells[4].Value.ToString();
            txtdantoc.Text = dgvupdateGKS.Rows[i].Cells[5].Value.ToString();
            txtquoctich.Text = dgvupdateGKS.Rows[i].Cells[6].Value.ToString();
            txtquequan.Text = dgvupdateGKS.Rows[i].Cells[7].Value.ToString();
            txthotencha.Text = dgvupdateGKS.Rows[i].Cells[8].Value.ToString();
            txtdantoccha.Text = dgvupdateGKS.Rows[i].Cells[9].Value.ToString();
            txtquoctichcha.Text = dgvupdateGKS.Rows[i].Cells[10].Value.ToString();
            txthotenme.Text = dgvupdateGKS.Rows[i].Cells[11].Value.ToString();
            txtdantocme.Text = dgvupdateGKS.Rows[i].Cells[12].Value.ToString();
            txtquoctichme.Text = dgvupdateGKS.Rows[i].Cells[13].Value.ToString();
            txtngdiKS.Text = dgvupdateGKS.Rows[i].Cells[14].Value.ToString();
            cbqhngks.Text = dgvupdateGKS.Rows[i].Cells[15].Value.ToString();
            dtpngaydangky.Text = dgvupdateGKS.Rows[i].Cells[16].Value.ToString();

            btncapnhat.Enabled = true;
        }
    }
}
