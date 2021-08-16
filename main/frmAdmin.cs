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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void mntrdangxuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        DataSet timkiemnhanthan()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.PROC_FindNT '" + txttimkiem.Text + "' ";
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

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            pbnam.Hide();
            pbnu.Hide();

            cbAp.Text = "Ấp An Hòa";

            dgvNTadmin.DataSource = findAp().Tables[0];
            dgvtongsoho.DataSource = tongsoho().Tables[0];
            txtongsoho.DataBindings.Clear();
            txtongsoho.DataBindings.Add("Text",dgvtongsoho.DataSource,"TongSoHo");
            txttimkiem.Select();
        }
        DataSet laydsnhanthan()
        {
            DataSet lay = new DataSet();
            string query = "EXEC dbo.PROC_DSNT";
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
        DataSet tongsoho()
        {
            DataSet lay = new DataSet();
            string query = " EXEC dbo.PROC_TongSoHo ";
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
        DataSet TonghotheoAp()
        {
            DataSet lay = new DataSet();
            string query = "SELECT COUNT(MaSHK) AS Tong FROM dbo.SOHOKHAU WHERE DiaChi LIKE N'%"+cbAp.SelectedItem+"%'";
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
        DataSet findAp()
        {
            DataSet lay = new DataSet();
            string query = "SELECT nt.MaSHK,nt.QHCHUHO,nt.HoTen,nt.BiDanh,nt.NamSinh,nt.NoiSinh,nt.GioiTinh,nt.QueQuan,nt.DanToc,nt.TonGiao,nt.CMND,nt.HoChieuSo,nt.NgheNghiep,nt.ChuyenDenNgay,nt.NoiOTruocKhiChuyenDen,nt.MaGKS FROM dbo.SOHOKHAU shk, dbo.NHANTHAN nt WHERE nt.MaSHK = shk.MaSHK AND shk.DiaChi LIKE N'%"+cbAp.SelectedItem+"%'";
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
        

        private void mnuAddGKS_Click(object sender, EventArgs e)
        {
            frmAddGKS frm = new frmAddGKS();
            frm.ShowDialog();
        }

        private void mnuupdateNT_Click(object sender, EventArgs e)
        {
            frmupdateNT frm = new frmupdateNT();
            frm.ShowDialog();
        }

        private void mnuupdateGKS_Click(object sender, EventArgs e)
        {
            frmupdateGKS frm = new frmupdateGKS();
            frm.ShowDialog();
        }

        private void mnudsGKS_Click(object sender, EventArgs e)
        {
            frmDSGKS frm = new frmDSGKS();
            frm.ShowDialog();
        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttimkiem.Text))
            {
                dgvNTadmin.DataSource = timkiemnhanthan().Tables[0];
            }
            else
            {
                dgvNTadmin.DataSource = findAp().Tables[0];
            }
        }

        private void dgvNTadmin_Click(object sender, EventArgs e)
        {
            int i = dgvNTadmin.CurrentRow.Index;
            txtmashk.Text = dgvNTadmin.Rows[i].Cells[0].Value.ToString();
            txtQHchuho.Text = dgvNTadmin.Rows[i].Cells[1].Value.ToString();
            txthoten.Text = dgvNTadmin.Rows[i].Cells[2].Value.ToString();
            txtbidanh.Text = dgvNTadmin.Rows[i].Cells[3].Value.ToString();
            txtnamsinh.Text = dgvNTadmin.Rows[i].Cells[4].Value.ToString();
            txtnoisinh.Text = dgvNTadmin.Rows[i].Cells[5].Value.ToString();
            txtgioitinh.Text = dgvNTadmin.Rows[i].Cells[6].Value.ToString();
            txtquequan.Text = dgvNTadmin.Rows[i].Cells[7].Value.ToString();
            txtdantoc.Text = dgvNTadmin.Rows[i].Cells[8].Value.ToString();
            txttongiao.Text = dgvNTadmin.Rows[i].Cells[9].Value.ToString();
            txtcmnd.Text = dgvNTadmin.Rows[i].Cells[10].Value.ToString();
            txthochieu.Text = dgvNTadmin.Rows[i].Cells[11].Value.ToString();
            txtnghenghiep.Text = dgvNTadmin.Rows[i].Cells[12].Value.ToString();
            txtchuyendenngay.Text = dgvNTadmin.Rows[i].Cells[13].Value.ToString();
            txtnoiotruockhichuyenden.Text = dgvNTadmin.Rows[i].Cells[14].Value.ToString();
            txtmagks.Text = dgvNTadmin.Rows[i].Cells[15].Value.ToString();

            string nam = "Nam";
            if (txtgioitinh.Text == nam)
            {
                pbnam.Show();
                pbnu.Hide();
            }
            else
            {
                pbnam.Hide();
                pbnu.Show();
            }
        }

        private void mnudkCMND_Click(object sender, EventArgs e)
        {
            frmdkCMND frm = new frmdkCMND();
            frm.ShowDialog();
        }

        private void mnuupdateCMND_Click(object sender, EventArgs e)
        {
            frmupdateCMND frm = new frmupdateCMND();
            frm.ShowDialog();
        }

        private void cbAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbAp.Text))
            {
                dgvtonghoAp.DataSource = TonghotheoAp().Tables[0];
                txttonghoAp.DataBindings.Clear();
                txttonghoAp.DataBindings.Add("Text", dgvtonghoAp.DataSource, "Tong");
                dgvNTadmin.DataSource = findAp().Tables[0];
            }
        }

        private void mnukhaibaophieutu_Click(object sender, EventArgs e)
        {
            dgvtongsoho.DataSource = tongsoho().Tables[0];
            txtongsoho.DataBindings.Clear();
            txtongsoho.DataBindings.Add("Text", dgvtongsoho.DataSource, "TongSoHo");
            frmphieutu frm = new frmphieutu();
            frm.ShowDialog();
        }

        private void mnudsphieutu_Click(object sender, EventArgs e)
        {
            dgvtongsoho.DataSource = tongsoho().Tables[0];
            txtongsoho.DataBindings.Clear();
            txtongsoho.DataBindings.Add("Text", dgvtongsoho.DataSource, "TongSoHo");
            frmdsPhieuTu frm = new frmdsPhieuTu();
            frm.ShowDialog();
        }

        private void mnutachhokhau_Click(object sender, EventArgs e)
        {
            frmtachSHK frm = new frmtachSHK();
            frm.ShowDialog();
        }

        private void mnudsthaydoichuho_Click(object sender, EventArgs e)
        {
            dgvtongsoho.DataSource = tongsoho().Tables[0];
            txtongsoho.DataBindings.Clear();
            txtongsoho.DataBindings.Add("Text", dgvtongsoho.DataSource, "TongSoHo");
            frmdsTDCH frm = new frmdsTDCH();
            frm.ShowDialog();
        }

        private void nhữngNgườiCóCMNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdsCMND frm = new frmdsCMND();
            frm.ShowDialog();
        }

        private void nhữngNgườiChưaCóCMNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdschuacoCMND frm = new frmdschuacoCMND();
            frm.ShowDialog();
        }

        private void mnudstamtrutamvang_Click(object sender, EventArgs e)
        {
            dgvtongsoho.DataSource = tongsoho().Tables[0];
            txtongsoho.DataBindings.Clear();
            txtongsoho.DataBindings.Add("Text", dgvtongsoho.DataSource, "TongSoHo");
            frmdsTTTV frm = new frmdsTTTV();
            frm.ShowDialog();
        }

        private void mnudktamtrutamvang_Click(object sender, EventArgs e)
        {
            dgvtongsoho.DataSource = tongsoho().Tables[0];
            txtongsoho.DataBindings.Clear();
            txtongsoho.DataBindings.Add("Text", dgvtongsoho.DataSource, "TongSoHo");
            frmdkTTTV frm = new frmdkTTTV();
            frm.ShowDialog();
        }

        private void mnudsSHK_Click(object sender, EventArgs e)
        {
            frmdsSHK frm = new frmdsSHK();
            frm.ShowDialog();
        }

        private void mnuupdateSHK_Click_1(object sender, EventArgs e)
        {
            frmupdateSHK frm = new frmupdateSHK();
            frm.ShowDialog();
        }

        private void mnuthongke_Click(object sender, EventArgs e)
        {
            FRM_THONG_KE frm = new FRM_THONG_KE();
            frm.ShowDialog();
        }
    }
}
