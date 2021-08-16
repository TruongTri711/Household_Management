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
    public partial class frmdsTDCH : Form
    {
        public frmdsTDCH()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }     
        DataSet dsTDCH()
        {
            DataSet insert = new DataSet();
            string query = "EXEC dbo.dsTDCH";
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
        DataSet findTDCH()
        {
            DataSet insert = new DataSet();
            string query = "EXEC FindTDCH '"+txttimkiem.Text+"'";
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
        DataSet TongTDCH()
        {
            DataSet insert = new DataSet();
            string query = "EXEC dbo.TongTDCH";
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
        DataSet DeleteTDCH()
        {
            DataSet insert = new DataSet();
            string query = "EXEC dbo.DeleteTDCH '"+txtmaphieu.Text+"'";
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

        private void dgcDSTDCH_Click(object sender, EventArgs e)
        {
            int i = dgcDSTDCH.CurrentRow.Index;
            txtmaphieu.Text = dgcDSTDCH.Rows[i].Cells[0].Value.ToString();
            txthotenvo.Text = dgcDSTDCH.Rows[i].Cells[1].Value.ToString();
            txtnamsinhvo.Text = dgcDSTDCH.Rows[i].Cells[2].Value.ToString();
            txtlydothaydoi.Text = dgcDSTDCH.Rows[i].Cells[3].Value.ToString();
            txtngaythaydoi.Text = dgcDSTDCH.Rows[i].Cells[4].Value.ToString();
            txtqhchuhocu.Text = dgcDSTDCH.Rows[i].Cells[5].Value.ToString();
            txtqhchuhomoi.Text = dgcDSTDCH.Rows[i].Cells[6].Value.ToString();
            txtmashk.Text = dgcDSTDCH.Rows[i].Cells[7].Value.ToString();

            btnxoa.Enabled = true;
        }

        private void frmdsthaydoichuho_Load(object sender, EventArgs e)
        {
            pnchuky.Hide();

            btnxoa.Enabled = false;

            dgvTongTDCH.DataSource = TongTDCH().Tables[0];
            txttongGKS.DataBindings.Clear();
            txttongGKS.DataBindings.Add("Text",dgvTongTDCH.DataSource,"Tong");

            dgcDSTDCH.DataSource = dsTDCH().Tables[0];
            txttimkiem.Select();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgcDSTDCH.DataSource = findTDCH().Tables[0];
            }
            else
            {
                dgcDSTDCH.DataSource = dsTDCH().Tables[0];
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            pnchuky.Show();
            txtchuky.Select();          
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
                if (MessageBox.Show("Xóa lựa chọn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvdeleteTDCH.DataSource = DeleteTDCH();
                    dgcDSTDCH.DataSource = dsTDCH().Tables[0];

                    txtmaphieu.Clear();
                    txtlydothaydoi.Clear();
                    txtngaythaydoi.Clear();
                    txtqhchuhocu.Clear();
                    txtqhchuhomoi.Clear();
                    txthotenvo.Clear();
                    txtnamsinhvo.Clear();
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
    }
}
