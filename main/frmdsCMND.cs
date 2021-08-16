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
    public partial class frmdsCMND : Form
    {
        public frmdsCMND()
        {
            InitializeComponent();
        }

        private void frmdsCMND_Load(object sender, EventArgs e)
        {
            txttimkiem.Select();
            dgvCMND.DataSource = laydsCMND().Tables[0];
            dgvtongCMND.DataSource = TongCMND().Tables[0];
            txttongCMND.DataBindings.Clear();
            txttongCMND.DataBindings.Add("Text",dgvtongCMND.DataSource,"TongCMND");
        }
        DataSet laydsCMND()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.DsCMND";
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
            string query = "SELECT * FROM dbo.CMND WHERE HoTen like N'%"+txttimkiem.Text+"%'";
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
        DataSet TongCMND()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.TongCMND";
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
        
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvCMND.DataSource = findhoten().Tables[0];
            }
            else
            {
                dgvCMND.DataSource = laydsCMND().Tables[0];
            }
        }

        private void dgvCMND_Click(object sender, EventArgs e)
        {
            int i = dgvCMND.CurrentRow.Index;
            txtmaso.Text = dgvCMND.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvCMND.Rows[i].Cells[1].Value.ToString();
            txtnamsinh.Text = dgvCMND.Rows[i].Cells[2].Value.ToString();
            txtnguyenquan.Text = dgvCMND.Rows[i].Cells[3].Value.ToString();
            txtnoicap.Text = dgvCMND.Rows[i].Cells[4].Value.ToString();
            txtngaycap.Text = dgvCMND.Rows[i].Cells[5].Value.ToString();
        }

        private void dgvCMND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
