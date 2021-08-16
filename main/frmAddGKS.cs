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
    public partial class frmAddGKS : Form
    {
        public frmAddGKS()
        {
            InitializeComponent();
        }
   
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        void ResetValues()
        {
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
       

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaGKS FROM GIAYKHAISINH WHERE MaGKS = '" + txtmagks.Text + "'";

            if (txtmagks.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã giấy khai sinh","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmagks.Focus();
                return;
            }
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoten.Focus();
                return;
            }
            else if(cbgioitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbgioitinh.Focus();
                return;
            }
            else if(txtnoisinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nơi sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnoisinh.Focus();
                return;
            }
            else if(txtdantoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantoc.Focus();
                return;
            }
            else if(txtquoctich.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquoctich.Focus();
                return;
            }
            else if(txtquequan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquequan.Focus();
                return;
            }
            else if(txthotencha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthotencha.Focus();
                return;
            }
            else if(txtdantoccha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantoccha.Focus();
                return;
            }
            else if(txtquoctichcha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquoctichcha.Focus();
                return;
            }
            else if(txthotenme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthotenme.Focus();
                return;
            }
            else if(txtdantocme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dân tộc mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdantocme.Focus();
                return;
            }
            else if(txtquoctichme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập quốc tịch mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquoctichme.Focus();
                return;
            }
            else if(txtngdiKS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập họ tên người đi khai sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtngdiKS.Focus();
                return;
            }
            else if(cbqhngks.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn quan hệ với người khai sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbqhngks.Focus();
                return;
            }
            
            else if(ChekKey(sql))
            {
                MessageBox.Show("Mã giấy khai sinh đã tồn tại, vui lòng nhập mã khác","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmagks.Focus();
                return;
            }
            else
            {
                pnchuky.Show();
                txtchuky.Select();             
            }

        }
       
        DataSet insertGKS()
        {
            DataSet insert = new DataSet();
            string query = "INSERT dbo.GIAYKHAISINH VALUES ( '" + txtmagks.Text + "' , N'" + txthoten.Text + "' , N'" + cbgioitinh.SelectedItem + "' , '" + dtpnamsinh.Text + "' , N'" + txtnoisinh.Text + "' , N'" + txtdantoc.Text + "' , N'" + txtquoctich.Text + "' , N'" + txtquequan.Text + "' , N'" + txthotencha.Text + "' , N'" + txtdantoccha.Text + "' , N'" + txtquoctichcha.Text + "' , N'" + txthotenme.Text + "' , N'" + txtdantocme.Text + "' , N'" + txtquoctichme.Text + "' , N'" + txtngdiKS.Text + "' , N'" + cbqhngks.SelectedItem + "' , '" + dtpngaydangky.Text + "' )";
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

        private void frmAddGKS_Load(object sender, EventArgs e)
        {
            txtmagks.Select();
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

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string mk = "123456";
            if (txtchuky.Text == mk)
            {
                dgvinsertGKS.DataSource = insertGKS();
                if (MessageBox.Show("Đăng ký giấy khai sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)== DialogResult.OK)
                {
                    txtchuky.Clear();
                    pnchuky.Hide();

                    frmAddNT frm = new frmAddNT();
                    frm.txtfindGKS.Text = txtmagks.Text; // phải đem trước reset value bởi vì nếu resetvalue trước thì dữ liệu sẽ mất và không thể gán giá trị cho form khác được

                    ResetValues();

                    this.Hide();

                    frm.ShowDialog();
                }                           
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtchuky.Focus();
                txtchuky.Clear();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            pnchuky.Hide();
            txtchuky.Clear();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
