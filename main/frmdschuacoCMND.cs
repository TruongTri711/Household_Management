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
    public partial class frmdschuacoCMND : Form
    {
        public frmdschuacoCMND()
        {
            InitializeComponent();
        }
        DataSet laydschuacoCMND()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.DSCHUACOCMND";
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
        DataSet findhoten()
        {
            DataSet lay = new DataSet();
            string query = "SELECT * FROM dbo.NHANTHAN WHERE HoTen like N'%" + txttimkiem.Text + "%' AND CMND = ''";
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
        DataSet TongchuacoCMND()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.TongDSCHUACOCMND";
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
        private void frmdschuacoCMND_Load(object sender, EventArgs e)
        {
            txttimkiem.Select();
            dgvNT.DataSource = laydschuacoCMND().Tables[0];

            dgvtongCMND.DataSource = TongchuacoCMND().Tables[0];
            txttongCMND.DataBindings.Clear();
            txttongCMND.DataBindings.Add("text",dgvtongCMND.DataSource,"Tong");
        }      

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvNT.DataSource = findhoten().Tables[0];
            }
            else
            {
                dgvNT.DataSource = laydschuacoCMND().Tables[0];
            }
        }
        private void dgvCMND_Click_1(object sender, EventArgs e)
        {
            int i = dgvNT.CurrentRow.Index;
            txtmashk.Text = dgvNT.Rows[i].Cells[0].Value.ToString();
            txtqhchuho.Text = dgvNT.Rows[i].Cells[1].Value.ToString();
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
            txtnoiotrckhichuyenden.Text = dgvNT.Rows[i].Cells[14].Value.ToString();
            txtmagks.Text = dgvNT.Rows[i].Cells[15].Value.ToString();
        }
    }
}
