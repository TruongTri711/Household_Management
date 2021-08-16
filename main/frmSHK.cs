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
    public partial class frmSHK : Form
    {
        public frmSHK()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvSHK.DataSource = XemGKS().Tables[0];

            txtmashk.Clear();
            txtdiachi.Clear();
            txtngaycap.Clear();
            //txtmashk.DataBindings.Clear();
            //txtmashk.DataBindings.Add("Text",dgvSHK.DataSource, "MaSHK");
            //txtdiachi.DataBindings.Clear();
            //txtdiachi.DataBindings.Add("Text", dgvSHK.DataSource, "DiaChi");
            //txtngaycap.DataBindings.Clear();
            //txtngaycap.DataBindings.Add("Text", dgvSHK.DataSource, "NgayCap");
        }
        DataSet XemGKS()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.XemHK '"+txttimkiem.Text+"'";
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

        private void frmSHK_Load(object sender, EventArgs e)
        {
            txttimkiem.Select();
        }

        private void dgvSHK_Click(object sender, EventArgs e)
        {
            int i = dgvSHK.CurrentRow.Index;
            txtmashk.Text = dgvSHK.Rows[i].Cells[0].Value.ToString();
            txtdiachi.Text = dgvSHK.Rows[i].Cells[1].Value.ToString();
            txtngaycap.Text = dgvSHK.Rows[i].Cells[2].Value.ToString();
        }
    }
}
