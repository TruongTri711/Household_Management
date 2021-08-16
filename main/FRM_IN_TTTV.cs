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
    public partial class FRM_IN_TTTV : Form
    {
        public FRM_IN_TTTV()
        {
            InitializeComponent();
        }

        private void FRM_IN_TTTV_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.TAMTRUTAMVANG WHERE MaSTT = '"+GetData.MaSTT+"'";
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                CRPVINTTTV rp = new CRPVINTTTV();
                rp.SetDataSource(dt);
                crptintttv.ReportSource = rp;
                con.Close();
            }
        }
    }
}
