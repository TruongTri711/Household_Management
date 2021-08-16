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
    public partial class FRM_IN_PHIEU_TU : Form
    {
        public FRM_IN_PHIEU_TU()
        {
            InitializeComponent();
        }

        private void FRM_IN_PHIEU_TU_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *  FROM dbo.PHIEUTU WHERE MaPhieuTu = '"+GetData.MaPhieuTu+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                CRPVINPHIEUTU rp = new CRPVINPHIEUTU();
                rp.SetDataSource(dt);
                crpvinphieutu.ReportSource = rp;
                con.Close();
            }
        }
    }
}
