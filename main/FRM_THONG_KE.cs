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
    public partial class FRM_THONG_KE : Form
    {
        public FRM_THONG_KE()
        {
            InitializeComponent();
        }

        private void FRM_THONG_KE_Load(object sender, EventArgs e)
        {
            string sql = "EXEC PROC_thongke";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                DataTable tb = new DataTable();
                dap.Fill(tb);
                CRPVTHONGKE rp = new CRPVTHONGKE();
                rp.SetDataSource(tb);
                crpvthongke.ReportSource = rp;
                con.Close();
            }
        }
    }
}
