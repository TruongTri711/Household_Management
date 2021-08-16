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
    public partial class frmupdateNT : Form
    {
        public frmupdateNT()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmupdateNT_Load(object sender, EventArgs e)
        {
            btncapnhat.Enabled = false;
            pnchuky.Hide();
            txttimkiem.Select();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvNTupdate.DataSource = findnhanthanwaten().Tables[0];
        }        
        DataSet findnhanthanwaten()
        {
            DataSet find = new DataSet();
            string query = "SELECT * FROM dbo.NHANTHAN WHERE HoTen LIKE N'%"+txttimkiem.Text+"%'";
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

        private void dgvNTupdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
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
            else if (cbgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbgioitinh.Focus();
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

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                dgvNTupdate.DataSource = updateNT();
                if (MessageBox.Show("Cập nhật nhân thân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtchuky.Clear();
                    pnchuky.Hide();
                    ResetValues();
                    dgvNTupdate.DataSource = findnhanthanwaten().Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }
        void ResetValues()
        {
            txtmashk.Clear();
            cbQHchuho.Text = "";
            txthoten.Clear();
            txtbidanh.Clear();
            txtnoisinh.Clear();
            cbgioitinh.SelectedItem = null;
            txtnoiotruockhichuyenden.Clear();
            txtquequan.Clear();
            txtdantoc.Clear();
            txttongiao.Clear();
            txtcmnd.Clear();
            txthochieu.Clear();
            txtnghenghiep.Clear();
            txtchuyendenngay.Clear();
            txtmagks.Clear();
        }      
        DataSet updateNT()
        {
            DataSet update = new DataSet();
            string query = "UPDATE dbo.NHANTHAN SET MaSHK = '"+txtmashk.Text+"', QHCHUHO = N'"+cbQHchuho.Text+"', HoTen = N'"+txthoten.Text+"', BiDanh = N'"+txtbidanh.Text+"', NamSinh = '"+txtnamsinh.Text+"', NoiSinh = N'"+txtnoisinh.Text+"', GioiTinh = N'"+cbgioitinh.SelectedItem+"', QueQuan = N'"+txtquequan.Text+"', DanToc = N'"+txtdantoc.Text+"', TonGiao = N'"+txttongiao.Text+"', CMND = '"+txtcmnd.Text+"', HoChieuSo = '"+txthochieu.Text+"', NgheNghiep = N'"+txtnghenghiep.Text+"', ChuyenDenNgay = '"+txtchuyendenngay.Text+"', NoiOTruocKhiChuyenDen = N'"+txtchuyendenngay.Text+"', MaGKS = '"+txtmagks.Text+ "' WHERE HoTen = N'"+txthoten.Text+"'";
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


        private void btnthoat_Click(object sender, EventArgs e)
        {
            pnchuky.Hide();
            txtchuky.Clear();
        }

        private void dgvNTupdate_Click(object sender, EventArgs e)
        {
            int i = dgvNTupdate.CurrentRow.Index;
            txtmashk.Text = dgvNTupdate.Rows[i].Cells[0].Value.ToString();
            cbQHchuho.Text = dgvNTupdate.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dgvNTupdate.Rows[i].Cells[2].Value.ToString();
            txtbidanh.Text = dgvNTupdate.Rows[i].Cells[3].Value.ToString();
            txtnamsinh.Text = dgvNTupdate.Rows[i].Cells[4].Value.ToString();
            txtnoisinh.Text = dgvNTupdate.Rows[i].Cells[5].Value.ToString();
            cbgioitinh.Text = dgvNTupdate.Rows[i].Cells[6].Value.ToString();
            txtquequan.Text = dgvNTupdate.Rows[i].Cells[7].Value.ToString();
            txtdantoc.Text = dgvNTupdate.Rows[i].Cells[8].Value.ToString();
            txttongiao.Text = dgvNTupdate.Rows[i].Cells[9].Value.ToString();
            txtcmnd.Text = dgvNTupdate.Rows[i].Cells[10].Value.ToString();
            txthochieu.Text = dgvNTupdate.Rows[i].Cells[11].Value.ToString();
            txtnghenghiep.Text = dgvNTupdate.Rows[i].Cells[12].Value.ToString();
            txtchuyendenngay.Text = dgvNTupdate.Rows[i].Cells[13].Value.ToString();
            txtnoiotruockhichuyenden.Text = dgvNTupdate.Rows[i].Cells[14].Value.ToString();
            txtmagks.Text = dgvNTupdate.Rows[i].Cells[15].Value.ToString();

            btncapnhat.Enabled = true;
        }
    }
}
