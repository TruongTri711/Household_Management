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
using CrystalDecisions.CrystalReports.Engine;
namespace main
{
    public partial class frmdsTTTV : Form
    {
        SqlConnection con = new SqlConnection(Connectionstring.connection);
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand lenh = new SqlCommand();
        public frmdsTTTV()
        {
            InitializeComponent();
        }

        DataSet DeleteTTTV()
        {
            DataSet insert = new DataSet();
            string query = "EXEC dbo.deleteTTTV '"+txtmagiaytamtru.Text+"'";
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
        DataSet dsTTTV()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.DSTTV";
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
        DataSet TongTTTV()
        {
            DataSet lay = new DataSet();
            string query = "EXEC TongTTTV";
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
        DataSet findMaSTT()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.findTTTV '"+txttimkiem.Text+"'";
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

        private void frmdsTTTV_Load(object sender, EventArgs e)
        {
            pnchuky.Hide();

            btnxoa.Enabled = false;

            btninreportTTTV.Enabled = false;

            txttimkiem.Select();

            dgvtamtrutamvang.DataSource = dsTTTV().Tables[0];

            dgvtongtttv.DataSource = TongTTTV().Tables[0];
            txttongTTTV.DataBindings.Clear();
            txttongTTTV.DataBindings.Add("Text",dgvtongtttv.DataSource,"Tong");
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvtamtrutamvang.DataSource = findMaSTT().Tables[0];
            }
            else
            {
                dgvtamtrutamvang.DataSource = dsTTTV().Tables[0];
            }
        }

        private void dgvtamtrutamvang_Click(object sender, EventArgs e)
        {
            int i = dgvtamtrutamvang.CurrentRow.Index;
            txtmagiaytamtru.Text = dgvtamtrutamvang.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvtamtrutamvang.Rows[i].Cells[1].Value.ToString();
            txtnamsinh.Text = dgvtamtrutamvang.Rows[i].Cells[2].Value.ToString();
            txtcmnd.Text = dgvtamtrutamvang.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dgvtamtrutamvang.Rows[i].Cells[4].Value.ToString();
            txtdangkytungay.Text = dgvtamtrutamvang.Rows[i].Cells[5].Value.ToString();
            txtdangkydenngay.Text = dgvtamtrutamvang.Rows[i].Cells[6].Value.ToString();
            txtlydo.Text = dgvtamtrutamvang.Rows[i].Cells[7].Value.ToString();
            txtmashk.Text = dgvtamtrutamvang.Rows[i].Cells[8].Value.ToString();

            btninreportTTTV.Enabled = true;

            btnxoa.Enabled = true;
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            pnchuky.Show();
            txtchuky.Select();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                if (MessageBox.Show("Xóa lựa chọn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvdeleteTTTV.DataSource = DeleteTTTV();
                    dgvtamtrutamvang.DataSource = dsTTTV().Tables[0];

                    dgvtongtttv.DataSource = TongTTTV().Tables[0];
                    txttongTTTV.DataBindings.Clear();
                    txttongTTTV.DataBindings.Add("Text", dgvtongtttv.DataSource, "Tong");

                    txtmagiaytamtru.Clear();
                    txthoten.Clear();
                    txtnamsinh.Clear();
                    txtcmnd.Clear();
                    txtdiachi.Clear();
                    txtdangkytungay.Clear();
                    txtdangkydenngay.Clear();
                    txtlydo.Clear();
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

        private void btninreportTTTV_Click(object sender, EventArgs e)
        {
            GetData.MaSTT = txtmagiaytamtru.Text;
            FRM_IN_TTTV frm = new FRM_IN_TTTV();
            frm.ShowDialog();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
