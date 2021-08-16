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
    public partial class frmtachSHK : Form
    {
        public frmtachSHK()
        {
            InitializeComponent();
        }

        private void btnfindmashk_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvNT.DataSource = findhoten().Tables[0];
        }

        private void dgvNT_Click(object sender, EventArgs e)
        {
            int i = dgvNT.CurrentRow.Index;
            txtmashk.Text = dgvNT.Rows[i].Cells[0].Value.ToString();
            txtQHchuho.Text = dgvNT.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dgvNT.Rows[i].Cells[2].Value.ToString();
            txtbidanh.Text = dgvNT.Rows[i].Cells[3].Value.ToString();
            txtnamsinh.Text = dgvNT.Rows[i].Cells[4].Value.ToString();
            txtnoisinh.Text = dgvNT.Rows[i].Cells[5].Value.ToString();
            txtgioitinh.Text = dgvNT.Rows[i].Cells[6].Value.ToString();
            txtquequan.Text = dgvNT.Rows[i].Cells[7].Value.ToString();
            txtdantoc.Text = dgvNT.Rows[i].Cells[8].Value.ToString();
            txttongiao.Text = dgvNT.Rows[i].Cells[9].Value.ToString();
            txtcmnd.Text = dgvNT.Rows[i].Cells[10].Value.ToString();
            txthochieu.Text = dgvNT.Rows[i].Cells[11].Value.ToString();
            txtnghenghiep.Text = dgvNT.Rows[i].Cells[12].Value.ToString();
            txtchuyendenngay.Text = dgvNT.Rows[i].Cells[13].Value.ToString();
            txtnoiotruockhichuyenden.Text = dgvNT.Rows[i].Cells[14].Value.ToString();
            txtmagks.Text = dgvNT.Rows[i].Cells[15].Value.ToString();

            btntachSHK.Enabled = true;
        }

        private void frmthaydoichuho_Load(object sender, EventArgs e)
        {
            btntachSHK.Enabled = false;
            pnchukychong.Hide();
            txtfindhoten.Select();
            pnthaydoichuho.Hide();
        }
        void ResetValues()
        {
            txtnamsinh.Clear();
            txtchuyendenngay.Clear();
            txtmashk.Clear();
            txtQHchuho.Clear();
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
        DataSet findhoten()
        {
            DataSet find = new DataSet();
            string query = "SELECT * FROM NHANTHAN WHERE HoTen = N'" + txtfindhoten.Text + "'";
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
        DataSet insertthaydoichuho()
        {
            DataSet find = new DataSet();
            string query = "INSERT dbo.THAYDOICHUHO VALUES  ( '"+txtmaphieu.Text+"' , N'"+txthotenvo.Text+"' , '"+txtnamsinhvo.Text+"' , N'"+txtlydothaydoi.Text+"' , '"+dtpngaythaydoi.Text+"' , N'"+cbqhchucu.Text+"' , N'"+cbqhchumoi.Text+"' , '"+txtmashkvo.Text+"' )";
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
        DataSet updateNTVo()
        {
            DataSet find = new DataSet();
            string query = "UPDATE dbo.NHANTHAN SET QHCHUHO = N'Chủ Hộ' WHERE MaSHK = '" + txtmashk.Text + "' AND QHCHUHO = N'Vợ'";
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

        DataSet layhotennamsinhvo()
        {
            DataSet find = new DataSet();
            string query = "SELECT * FROM dbo.NHANTHAN WHERE MaSHK = '"+txtmashk.Text+"' AND QHCHUHO = N'Vợ'";
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
        bool ChekKey(string sql)
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

        private void btntachSHK_Click(object sender, EventArgs e)
        {            
            dgvhotennamsinhmashkvo.DataSource = layhotennamsinhvo().Tables[0];

            txthotenvo.DataBindings.Clear();
            txthotenvo.DataBindings.Add("Text", dgvhotennamsinhmashkvo.DataSource, "HoTen");
            txtnamsinhvo.DataBindings.Clear();
            txtnamsinhvo.DataBindings.Add("Text", dgvhotennamsinhmashkvo.DataSource, "NamSinh");
            txtmashkvo.DataBindings.Clear();
            txtmashkvo.DataBindings.Add("Text", dgvhotennamsinhmashkvo.DataSource, "MaSHK");

            string a = "Chủ Hộ";
            if (txtQHchuho.Text == a)
            {
                if (MessageBox.Show("Vì bạn là chủ hộ nên sau khi tách hộ khẩu vợ bạn sẽ là chủ hộ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    pnthaydoichuho.Show();
                    txtmaphieu.Select();
                }
            }
            else
            {
                pnchukychong.Show();
                txtchukyvo.Select();
                txtchukychong.Hide();
                txtchukyvo.Show();
            }
        }

        private void btnthaydoichuho_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaphieuTDCH AS Tong FROM dbo.THAYDOICHUHO WHERE MaphieuTDCH = '" + txtmaphieu.Text.Trim()+ "'";

            if (txtmaphieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu","Thong báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmaphieu.Focus();
                return;
            }
            else if (txtlydothaydoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập lý do thay đổi", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlydothaydoi.Focus();
                return;
            }
            else if (cbqhchucu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ chủ hộ cũ", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbqhchucu.Focus();
                return;
            }
            else if (cbqhchumoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ chủ hộ mới", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbqhchumoi.Focus();
                return;
            }
            else if (ChekKey(sql))
            {
                MessageBox.Show("Mã phiếu đã tồn tại, vui lòng nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphieu.Focus();
                return;
            }
            else
            {
                pnchukychong.Show();
                txtchukyvo.Hide();
                txtchukychong.Show();
                txtchukychong.Select();
            }
        }

        private void btndongpn_Click(object sender, EventArgs e)
        {
            txtmaphieu.Clear();
            txtlydothaydoi  .Clear();
            cbqhchucu.Text = "";
            cbqhchumoi.Text = "";

            pnthaydoichuho.Hide();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienan.Checked)
            {
                txtchukychong.UseSystemPasswordChar = false;
                txtchukyvo.UseSystemPasswordChar = false;
            }
            else
            {
                txtchukychong.UseSystemPasswordChar = true;
                txtchukyvo.UseSystemPasswordChar = true;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            txtchukyvo.Clear();
            txtchukychong.Clear();
            pnchukychong.Hide();
        }     

        private void chkhienan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkhienan.Checked)
            {
                txtchukychong.UseSystemPasswordChar = false;
                txtchukyvo.UseSystemPasswordChar = false;
            }
            else
            {
                txtchukychong.UseSystemPasswordChar = true;
                txtchukyvo.UseSystemPasswordChar = true;
            }
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            txtchukychong.Clear();
            txtchukyvo.Clear();
            pnchukychong.Hide();
        }

        private void btnthaydoichuho_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT MaphieuTDCH AS Tong FROM dbo.THAYDOICHUHO WHERE MaphieuTDCH = '" + txtmaphieu.Text.Trim() + "'";

            if (txtmaphieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphieu.Focus();
                return;
            }
            else if (txtlydothaydoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập lý do thay đổi", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlydothaydoi.Focus();
                return;
            }
            else if (cbqhchucu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ chủ hộ cũ", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbqhchucu.Focus();
                return;
            }
            else if (cbqhchumoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ chủ hộ mới", "Thong báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbqhchumoi.Focus();
                return;
            }
            else if (ChekKey(sql))
            {
                MessageBox.Show("Mã phiếu đã tồn tại, vui lòng nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphieu.Focus();
                return;
            }
            else
            {
                pnchukychong.Show();
                txtchukychong.Select();
                txtchukychong.Show();
                txtchukyvo.Hide();
            }
        }

        private void btndongpn_Click_1(object sender, EventArgs e)
        {
            txtmaphieu.Clear();
            txtlydothaydoi.Clear();

            pnthaydoichuho.Hide();
        }

        private void btnxacnhanchong_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchukychong.Text == mk)
            {
                if (MessageBox.Show("Tách hộ khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvinsertthaydoichuho.DataSource = insertthaydoichuho();
                    dgvupdateNT.DataSource = updateNTVo();
                    this.Hide();
                    frmĐKSHKVSNT frm = new frmĐKSHKVSNT();
                    frm.txtchuahoten.Text = txthoten.Text;
                    frm.txtchuanamsinh.Text = txtnamsinh.Text;
                    frm.ShowDialog();
                }
            }
            else if (txtchukyvo.Text == mk)
            {
                if (MessageBox.Show("Tách hộ khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Hide();
                    frmĐKSHKVSNT frm = new frmĐKSHKVSNT();
                    frm.txtchuahoten.Text = txthoten.Text;
                    frm.txtchuanamsinh.Text = txtnamsinh.Text;
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchukychong.Focus();
                txtchukychong.Clear();
                txtchukyvo.Focus();
                txtchukyvo.Clear();
            }
        }
    }
}
