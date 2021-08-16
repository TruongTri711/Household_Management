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
    public partial class FRM_IN_SHK : Form
    {
        public FRM_IN_SHK()
        {
            InitializeComponent();
        }

        private void FRM_IN_SHK_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.SOHOKHAU WHERE MaSHK = '"+GetData.MaSHK+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                CRPVINSHK rp = new CRPVINSHK();
                rp.SetDataSource(dt);
                crpvinshk.ReportSource = rp;
                con.Close();
            }
        }
    }
}
