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
    public partial class frmdkTTTV : Form
    {
        public frmdkTTTV()
        {
            InitializeComponent();
        }
        bool CheckkeyMaSHK(string sqlCheckkeyMaSHK)
        {
            SqlConnection con = new SqlConnection(Connectionstring.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCheckkeyMaSHK, con);
            DataTable table = new DataTable();
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
        bool CheckkeyMaSTT(string sqlCheckkeyMaSTT)
        {
            SqlConnection con = new SqlConnection(Connectionstring.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCheckkeyMaSTT, con);
            DataTable table = new DataTable();
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
        DataSet insertTTTV()
        {
            DataSet view = new DataSet();
            string query = "INSERT dbo.TAMTRUTAMVANG VALUES ( '"+txtmagiaytamtru.Text+"' , N'"+txthoten.Text+"' , '"+dtpnamsinh.Text+"' , '"+txtcmnd.Text+"' , N'"+txtdiachi.Text+"' , '"+dtpdktungay.Text+"' , '"+dtpdkdenngay.Text+"' , N'"+txtlydo.Text+"' , '"+txtmashk.Text+"' )";
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
        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmdkTTTV_Load(object sender, EventArgs e)
        {
            pnchuky.Hide();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sqlCheckkeyMaSHK = "EXEC dbo.CheckMaSHK '"+txtmashk.Text+"'";
            string sqlCheckkeyMaSTT = "EXEC dbo.CheckMaSTT '"+txtmagiaytamtru.Text+"'";
            if (txtmagiaytamtru.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã giấy tạm trú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmagiaytamtru.Focus();
                return;
            }
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoten.Focus();
                return;
            }
            else if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            else if (txtlydo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập lý do", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlydo.Focus();
                return;
            }
            else if (txtmashk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã sổ hộ khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmashk.Focus();
                return;
            }
            else if (CheckkeyMaSHK(sqlCheckkeyMaSHK))
            {
                MessageBox.Show("Không tồn tại mã sổ hộ khẩu này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmashk.Focus();
                return;
            }
            else if (CheckkeyMaSTT(sqlCheckkeyMaSTT))
            {
                MessageBox.Show("Đã tồn tại mã giấy tạm trú/tạm vắng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmagiaytamtru.Focus();
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmagiaytamtru.Clear();
        }

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {                
                if (MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dgvinsertTTTV.DataSource = insertTTTV();
                    txtchuky.Clear();
                    pnchuky.Hide();
                    ResetValues();
                    txtmagiaytamtru.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }

        private void brnlammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        void ResetValues()
        {
            txtmagiaytamtru.Clear();
            txthoten.Clear();
            txtcmnd.Clear();
            txtdiachi.Clear();
            txtlydo.Clear();
            txtmashk.Clear();
        }

    }
}
