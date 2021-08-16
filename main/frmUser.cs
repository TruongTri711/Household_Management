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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void mntrdangxuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ResetValues()
        {
            txtnamsinh.Clear();
            txtchuyendenngay.Clear();
            txtmashk.Clear();
            txtqhchuho.Clear();
            txthoten.Clear();
            txtbidanh.Clear();
            txtnoisinh.Clear();
            txtgioitinh.Clear();
            txtnoiotrckhichuyenden.Clear();
            txtquequan.Clear();
            txtdantoc.Clear();
            txttongiao.Clear();
            txtcmnd.Clear();
            txthochieu.Clear();
            txtnghenghiep.Clear();
            txtmagks.Clear();
        }
        DataSet findmashk()
        {
            DataSet find = new DataSet();
            string query = "EXEC dbo.PROC_FindNT '" + txtfindmashk.Text + "'";
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
        DataSet TongNT()
        {
            DataSet find = new DataSet();
            string query = " EXEC dbo.PROC_TongNT '"+txtfindmashk.Text+"' ";
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

        private void frmUser_Load(object sender, EventArgs e)
        {           
            txtfindmashk.Select();
        }

        private void btnchitietSHK_Click(object sender, EventArgs e)
        {
            frmSHK frm = new frmSHK();
            frm.ShowDialog();
        }

        private void mnuthongtinsohokhau_Click(object sender, EventArgs e)
        {
            frmSHK frm = new frmSHK();
            frm.ShowDialog();
        }

        private void mnugiaykhaisinh_Click(object sender, EventArgs e)
        {
            frmGKS frm = new frmGKS();
            frm.ShowDialog();
        }

        private void dgvnhanthanuser_Click_1(object sender, EventArgs e)
        {
            int i = dgvnhanthanuser.CurrentRow.Index;
            txtmashk.Text = dgvnhanthanuser.Rows[i].Cells[0].Value.ToString();
            txtqhchuho.Text = dgvnhanthanuser.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dgvnhanthanuser.Rows[i].Cells[2].Value.ToString();
            txtbidanh.Text = dgvnhanthanuser.Rows[i].Cells[3].Value.ToString();
            txtnamsinh.Text = dgvnhanthanuser.Rows[i].Cells[4].Value.ToString();
            txtnoisinh.Text = dgvnhanthanuser.Rows[i].Cells[5].Value.ToString();
            txtgioitinh.Text = dgvnhanthanuser.Rows[i].Cells[6].Value.ToString();
            txtquequan.Text = dgvnhanthanuser.Rows[i].Cells[7].Value.ToString();
            txtdantoc.Text = dgvnhanthanuser.Rows[i].Cells[8].Value.ToString();
            txttongiao.Text = dgvnhanthanuser.Rows[i].Cells[9].Value.ToString();
            txtcmnd.Text = dgvnhanthanuser.Rows[i].Cells[10].Value.ToString();
            txthochieu.Text = dgvnhanthanuser.Rows[i].Cells[11].Value.ToString();
            txtnghenghiep.Text = dgvnhanthanuser.Rows[i].Cells[12].Value.ToString();
            txtchuyendenngay.Text = dgvnhanthanuser.Rows[i].Cells[13].Value.ToString();
            txtnoiotrckhichuyenden.Text = dgvnhanthanuser.Rows[i].Cells[14].Value.ToString();
            txtmagks.Text = dgvnhanthanuser.Rows[i].Cells[15].Value.ToString();
        }
       
        private void btnfindmashk_Click(object sender, EventArgs e)
        {
            dgvtongNT.DataSource = TongNT().Tables[0];
            txttongNT.DataBindings.Clear();
            txttongNT.DataBindings.Add("Text", dgvtongNT.DataSource, "TongNT");
            ResetValues();
            dgvnhanthanuser.DataSource = findmashk().Tables[0];
            txtfindmashk.Clear();          
        }
    }
}