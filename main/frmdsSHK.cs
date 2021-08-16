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
    public partial class frmdsSHK : Form
    {
        public frmdsSHK()
        {
            InitializeComponent();
        }
        DataSet DSSHK()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.DSSHK";
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
        DataSet TongSHK()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.PROC_TongSoHo";
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
        DataSet findSHK()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.findSHKtheoMaSHK '"+txttimkiem.Text+"'";
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
            this.Close();
        }

        private void frmdsSHK_Load(object sender, EventArgs e)
        {
            btninreport.Enabled = false;
            txttimkiem.Select();
            dgvSHK.DataSource = DSSHK().Tables[0];
            dgvtongSHK.DataSource = TongSHK().Tables[0];

            txttongSHK.DataBindings.Clear();
            txttongSHK.DataBindings.Add("Text",dgvtongSHK.DataSource, "TongSoHo");
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvSHK.DataSource = findSHK().Tables[0];
            }
            else
            {
                dgvSHK.DataSource = DSSHK().Tables[0];
            }
        }

        private void dgvSHK_Click(object sender, EventArgs e)
        {
            int i = dgvSHK.CurrentRow.Index;
            txtmashk.Text = dgvSHK.Rows[i].Cells[0].Value.ToString();
            cbodiachi.Text = dgvSHK.Rows[i].Cells[1].Value.ToString();
            txtngaycap.Text = dgvSHK.Rows[i].Cells[2].Value.ToString();

            btninreport.Enabled = true;
        }

        private void btninreport_Click(object sender, EventArgs e)
        {
            GetData.MaSHK = txtmashk.Text;
            FRM_IN_SHK frm = new FRM_IN_SHK();
            frm.ShowDialog();
        }
    }
}
