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
    public partial class frmDSGKS : Form
    {
        SqlConnection con = new SqlConnection(Connectionstring.connection);
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public frmDSGKS()
        {
            InitializeComponent();
            con.Open();
            lenh.Connection = con;
        }

        private void frmDSGKS_Load(object sender, EventArgs e)
        {
            btninreport.Enabled = false;

            txttimkiem.Select();
            dgvdsGKS.DataSource = XemGKS().Tables[0];
            dgvtongGKS.DataSource = TongGKS().Tables[0];
            txttongGKS.DataBindings.Clear();
            txttongGKS.DataBindings.Add("Text",dgvtongGKS.DataSource,"TongGKS");
        }
        DataSet XemGKS()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.DSGKS";
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
        DataSet TongGKS()
        {
            DataSet count = new DataSet();
            string query = "EXEC dbo.PROC_TongGKS";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(count);
                con.Close();
                con.Dispose(); // giải phóng tài nguyên           
            }
            return count;
        }

        
        DataSet FindGKS()
        {
            DataSet view = new DataSet();
            string query = "EXEC dbo.FindGKS '" + txttimkiem.Text+"'";
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

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvdsGKS.DataSource = XemGKS().Tables[0];
            }
            else
            {
                dgvdsGKS.DataSource = FindGKS().Tables[0];
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtQHngKS.Text = dgvdsGKS.Rows[i].Cells[15].Value.ToString();
            txtngaydk.Text = dgvdsGKS.Rows[i].Cells[16].Value.ToString();

            btninreport.Enabled = true;
        }

        private void btninreport_Click(object sender, EventArgs e)
        {
            lenh.CommandType = CommandType.StoredProcedure;
            lenh.CommandText = "FindGKS";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@GKS",txtmagks.Text);
            adapter.SelectCommand = lenh;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CRPVINGKS rp = new CRPVINGKS();
            rp.SetDataSource(dt);
            FRM_IN_GKS frm = new FRM_IN_GKS();
            frm.cprvGKS.ReportSource = rp;
            frm.ShowDialog();
        }
    }
}
