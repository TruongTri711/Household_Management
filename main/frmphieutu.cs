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
    public partial class frmphieutu : Form
    {
        public frmphieutu()
        {
            InitializeComponent();
        }
        DataSet findhoten()
        {
            DataSet find = new DataSet();
            string query = "SELECT * FROM NHANTHAN WHERE HoTen LIKE N'%"+txtfindhoten.Text+"%' AND NamSinh = '"+txtfindnamsinh.Text+"'";
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
            string query = "SELECT * FROM dbo.NHANTHAN WHERE MaSHK = '" + txtmashk.Text + "' AND QHCHUHO = N'Vợ'";
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
        DataSet insertPhieuTu()
        {
            DataSet find = new DataSet();
            string query = "INSERT dbo.PHIEUTU VALUES  ( '"+txtmaphieutu.Text+"' , N'"+txthoten.Text+"' , '"+txtnamsinh.Text+"' , '"+dtpngaymat.Text+"' , N'"+txtlydomat.Text+"' , N'"+txtnoimat.Text+"' , '"+txtmashk.Text+"' )";
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
        DataSet updateNT()
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
        DataSet deleteNT()
        {
            DataSet find = new DataSet();
            string query = "DELETE NHANTHAN WHERE HoTen LIKE N'" + txthoten.Text + "' AND NamSinh = '"+txtnamsinh.Text+"'";
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
        DataSet deleteCMND()
        {
            DataSet find = new DataSet();
            string query = "DELETE CMND WHERE HoTen = N'" + txthoten.Text + "' AND NamSinh = '" + txtnamsinh.Text + "'";
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
        DataSet deleteGKS() 
        {
            DataSet find = new DataSet();
            string query = "DELETE GIAYKHAISINH WHERE MaGKS = '"+txtmaGKS.Text+"'";
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

        private void frmphieutu_Load(object sender, EventArgs e)
        {
            pnchuky.Hide();
            pnthaydoichuho.Hide();
            txtfindhoten.Select();
            btnluu.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // lấy thông tin của vợ chủ hộ
            dgvhotennamsinhvo.DataSource = layhotennamsinhvo().Tables[0];

            txthotenvo.DataBindings.Clear();
            txthotenvo.DataBindings.Add("Text", dgvhotennamsinhvo.DataSource, "HoTen");
            txtnamsinhvo.DataBindings.Clear();
            txtnamsinhvo.DataBindings.Add("Text", dgvhotennamsinhvo.DataSource, "NamSinh");

            string sql = "SELECT MaPhieuTu AS Tong FROM dbo.PHIEUTU WHERE MaPhieuTu = '" + txtmaphieutu.Text+"'";            

            if (txtmaphieutu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu tử", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphieutu.Focus();
                return; 
            }
            else if (txtlydomat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập lý do mất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlydomat.Focus();
                return;
            }
            else if (txtnoimat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nơi mất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnoimat.Focus();
                return;
            }
            else if(ChekKey(sql))
            {
                MessageBox.Show("Mã phiếu tử đã tồn tại, vui lòng nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphieutu.Focus();
                return;
            }
            else
            {
                string a = "Chủ Hộ";
                if (txtqhchuho.Text == a)
                {
                    if (MessageBox.Show("Vì bạn là chủ hộ nên sau khi làm phiếu tử vợ bạn sẽ là chủ hộ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        pnthaydoichuho.Show();
                        txtmaphieu.Select();
                    }
                }
                else
                {
                    pnchuky.Show();
                    txtchukyvo.Show();
                    txtchuky.Hide();
                    txtchukyvo.Select();
                }
            }           
        }

        private void btnthaydoichuho_Click(object sender, EventArgs e)
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
            else if (ChekKey(sql))
            {
                MessageBox.Show("Mã phiếu đã tồn tại, vui lòng nhập lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaphieu.Focus();
                return;
            }
            else
            {
                pnchuky.Show();              
                txtchuky.Show();
                txtchuky.Select();
                txtchukyvo.Hide();
            }
        }

        private void btndongpn_Click(object sender, EventArgs e)
        {
            txtmaphieutu.Clear();
            txtlydomat.Clear();
            cbqhchucu.Text = "";

            pnthaydoichuho.Hide();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                if (MessageBox.Show("Khai báo phiếu tử thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvinsertPhieuTu.DataSource = insertPhieuTu();
                    dgvupdateNT.DataSource = updateNT();
                   
                    dgvdeleteCMND.DataSource = deleteCMND();
                    dgvNT.DataSource = deleteNT();
                    dgvdeleteGKS.DataSource = deleteGKS();

                    txtfindnamsinh.Clear();
                    pnchuky.Hide();
                    txtchuky.Clear();
                    pnthaydoichuho.Hide();
                    txtmaphieu.Clear();
                    txtlydomat.Clear();
                    txthotenvo.Clear();
                    txtnamsinhvo.Clear();
                    txtmaphieutu.Clear();
                    txthoten.Clear();
                    txtnamsinh.Clear();
                    txtlydothaydoi.Clear();
                    txtnoimat.Clear();
                    txtmashk.Clear();
                    txtfindhoten.Clear();
                    txtfindhoten.Focus();                  
                }
            }
            else if (txtchukyvo.Text == mk)
            {
                if (MessageBox.Show("Khai báo phiếu tử thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvinsertPhieuTu.DataSource = insertPhieuTu();

                    dgvdeleteCMND.DataSource = deleteCMND();
                    dgvNT.DataSource = deleteNT();                   
                    dgvdeleteGKS.DataSource = deleteGKS();

                    pnchuky.Hide();
                    txtchuky.Clear();
                    pnthaydoichuho.Hide();
                    txtmaphieu.Clear();
                    txtlydomat.Clear();
                    cbqhchucu.Text = "";
                    txthotenvo.Clear();
                    txtnamsinhvo.Clear();
                    txtmaphieutu.Clear();
                    txthoten.Clear();
                    txtnamsinh.Clear();
                    txtlydothaydoi.Clear();
                    txtnoimat.Clear();
                    txtmashk.Clear();
                    txtfindhoten.Clear();
                    txtfindnamsinh.Clear();
                    txtfindhoten.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }

        private void chkhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhienan.Checked)
            {
                txtchuky.UseSystemPasswordChar = false;
                txtchukyvo.UseSystemPasswordChar = false;
            }
            else
            {
                txtchuky.UseSystemPasswordChar = true;
                txtchukyvo.UseSystemPasswordChar = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            txtchuky.Clear();
            pnchuky.Hide();
        }

        private void btnfindNT_Click(object sender, EventArgs e)
        {
            if (txtfindhoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfindhoten.Focus();
                return;
            }
            else if (txtfindnamsinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập năm sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfindnamsinh.Focus();
                return;
            }
            else
            {
                txtmaphieutu.Clear();
                txthoten.Clear();
                txtnamsinh.Clear();
                txtlydomat.Clear();
                txtnoimat.Clear();
                txtmashk.Clear();
                txtmaphieutu.Select();

                dgvNT.DataSource = findhoten().Tables[0];
                txthoten.DataBindings.Clear();
                txthoten.DataBindings.Add("Text", dgvNT.DataSource, "HoTen");
                txtnamsinh.DataBindings.Clear();
                txtnamsinh.DataBindings.Add("Text", dgvNT.DataSource, "NamSinh");
                txtqhchuho.DataBindings.Clear();
                txtqhchuho.DataBindings.Add("Text", dgvNT.DataSource, "QHCHUHO");
                txtmashk.DataBindings.Clear();
                txtmashk.DataBindings.Add("Text", dgvNT.DataSource, "MaSHK");
                txtmaGKS.DataBindings.Clear();
                txtmaGKS.DataBindings.Add("Text", dgvNT.DataSource, "maGKS");

                btnluu.Enabled = true;
            }
        }
    }
}
