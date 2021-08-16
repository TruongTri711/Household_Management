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
    public partial class frmGKS : Form
    {
        public frmGKS()
        {
            InitializeComponent();
        }

        private void frmGKS_Load(object sender, EventArgs e)
        {
            txttimkiem.Select();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvdsGKS.DataSource = XemGKS().Tables[0];        
        }
        DataSet XemGKS() 
        {
            DataSet view = new DataSet();
            string query = "SELECT * FROM dbo.GIAYKHAISINH WHERE HoTen LIKE N'"+txttimkiem.Text+"'";
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

        private void btndong_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvdsGKS_Click(object sender, EventArgs e)
        {
            int i = dgvdsGKS.CurrentRow.Index;
            txtmagks.Text = dgvdsGKS.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvdsGKS.Rows[i].Cells[1].Value.ToString();
            txtgioitinh.Text = dgvdsGKS.Rows[i].Cells[2].Value.ToString();
            txtnamsinh.Text = dgvdsGKS.Rows[i].Cells[3].Value.ToString();
            txtnoisinh.Text = dgvdsGKS.Rows[i].Cells[4].Value.ToString();
            txtdantoc.Text = dgvdsGKS.Rows[i].Cells[5].Value.ToString();
            txtquoctich.Text = dgvdsGKS.Rows[i].Cells[6].Value.ToString();
            txtquequan.Text = dgvdsGKS.Rows[i].Cells[7].Value.ToString();
            txthotencha.Text = dgvdsGKS.Rows[i].Cells[8].Value.ToString();
            txtdantoccha.Text = dgvdsGKS.Rows[i].Cells[9].Value.ToString();
            txtquoctichcha.Text = dgvdsGKS.Rows[i].Cells[10].Value.ToString();
            txthotenme.Text = dgvdsGKS.Rows[i].Cells[11].Value.ToString();
            txtdantocme.Text = dgvdsGKS.Rows[i].Cells[12].Value.ToString();
            txtquoctichme.Text = dgvdsGKS.Rows[i].Cells[13].Value.ToString();
            txtngdiKS.Text = dgvdsGKS.Rows[i].Cells[14].Value.ToString();
            txtqhngks.Text = dgvdsGKS.Rows[i].Cells[15].Value.ToString();
            txtngaydk.Text = dgvdsGKS.Rows[i].Cells[16].Value.ToString();
        }
        void ResetValues()
        {
            txtmagks.Clear();
            txthoten.Clear();
            txtgioitinh.Clear();
            txtnamsinh.Clear();
            txtnoisinh.Clear();
            txtdantoc.Clear();
            txtquoctich.Clear();
            txtquequan.Clear();
            txthotencha.Clear();
            txtquoctichcha.Clear();
            txtdantoccha.Clear();
            txthotenme.Clear();
            txtdantocme.Clear();
            txtquoctichme.Clear();
            txtngdiKS.Clear();
            txtqhngks.Clear();
            txtngaydk.Clear();
        }
    }
}
