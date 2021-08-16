namespace main
{
    partial class frmdsPhieuTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grbthannhan = new System.Windows.Forms.GroupBox();
            this.txtngaymat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmashk = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlydomat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnamsinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmaphieutu = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtnoimat = new System.Windows.Forms.TextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvphieutu = new System.Windows.Forms.DataGridView();
            this.MaPhieuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LydoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvtongphieutu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongphieutu = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvdeletePT = new System.Windows.Forms.DataGridView();
            this.pnchuky = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chkhienan = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtchuky = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btninreport = new System.Windows.Forms.Button();
            this.grbthannhan.SuspendLayout();
            this.grbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieutu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtongphieutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletePT)).BeginInit();
            this.pnchuky.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(412, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHIẾU TỬ";
            // 
            // grbthannhan
            // 
            this.grbthannhan.BackColor = System.Drawing.Color.White;
            this.grbthannhan.Controls.Add(this.txtngaymat);
            this.grbthannhan.Controls.Add(this.label13);
            this.grbthannhan.Controls.Add(this.txtmashk);
            this.grbthannhan.Controls.Add(this.txthoten);
            this.grbthannhan.Controls.Add(this.label7);
            this.grbthannhan.Controls.Add(this.txtlydomat);
            this.grbthannhan.Controls.Add(this.label6);
            this.grbthannhan.Controls.Add(this.txtnamsinh);
            this.grbthannhan.Controls.Add(this.label5);
            this.grbthannhan.Controls.Add(this.label12);
            this.grbthannhan.Controls.Add(this.txtmaphieutu);
            this.grbthannhan.Controls.Add(this.label18);
            this.grbthannhan.Controls.Add(this.label20);
            this.grbthannhan.Controls.Add(this.txtnoimat);
            this.grbthannhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthannhan.Location = new System.Drawing.Point(411, 95);
            this.grbthannhan.Name = "grbthannhan";
            this.grbthannhan.Size = new System.Drawing.Size(855, 352);
            this.grbthannhan.TabIndex = 31;
            this.grbthannhan.TabStop = false;
            this.grbthannhan.Text = "Thông tin";
            // 
            // txtngaymat
            // 
            this.txtngaymat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtngaymat.BackColor = System.Drawing.Color.White;
            this.txtngaymat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaymat.Location = new System.Drawing.Point(186, 167);
            this.txtngaymat.Name = "txtngaymat";
            this.txtngaymat.ReadOnly = true;
            this.txtngaymat.Size = new System.Drawing.Size(177, 26);
            this.txtngaymat.TabIndex = 257;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 256;
            this.label13.Text = "Mã sổ hộ khẩu:";
            // 
            // txtmashk
            // 
            this.txtmashk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtmashk.BackColor = System.Drawing.Color.White;
            this.txtmashk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmashk.Location = new System.Drawing.Point(185, 298);
            this.txtmashk.Name = "txtmashk";
            this.txtmashk.ReadOnly = true;
            this.txtmashk.Size = new System.Drawing.Size(177, 26);
            this.txtmashk.TabIndex = 255;
            // 
            // txthoten
            // 
            this.txthoten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txthoten.BackColor = System.Drawing.Color.White;
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(186, 79);
            this.txthoten.Name = "txthoten";
            this.txthoten.ReadOnly = true;
            this.txthoten.Size = new System.Drawing.Size(177, 26);
            this.txthoten.TabIndex = 251;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 253;
            this.label7.Text = "Năm sinh:";
            // 
            // txtlydomat
            // 
            this.txtlydomat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtlydomat.BackColor = System.Drawing.Color.White;
            this.txtlydomat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlydomat.Location = new System.Drawing.Point(185, 214);
            this.txtlydomat.Name = "txtlydomat";
            this.txtlydomat.ReadOnly = true;
            this.txtlydomat.Size = new System.Drawing.Size(605, 26);
            this.txtlydomat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 254;
            this.label6.Text = "Họ tên:";
            // 
            // txtnamsinh
            // 
            this.txtnamsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtnamsinh.BackColor = System.Drawing.Color.White;
            this.txtnamsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamsinh.Location = new System.Drawing.Point(186, 125);
            this.txtnamsinh.Name = "txtnamsinh";
            this.txtnamsinh.ReadOnly = true;
            this.txtnamsinh.Size = new System.Drawing.Size(177, 26);
            this.txtnamsinh.TabIndex = 252;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nơi mất:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(96, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Lý do mất:";
            // 
            // txtmaphieutu
            // 
            this.txtmaphieutu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtmaphieutu.BackColor = System.Drawing.Color.White;
            this.txtmaphieutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphieutu.Location = new System.Drawing.Point(185, 37);
            this.txtmaphieutu.Name = "txtmaphieutu";
            this.txtmaphieutu.ReadOnly = true;
            this.txtmaphieutu.Size = new System.Drawing.Size(177, 26);
            this.txtmaphieutu.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(83, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã phiếu tử:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(98, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "Ngày mất:";
            // 
            // txtnoimat
            // 
            this.txtnoimat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtnoimat.BackColor = System.Drawing.Color.White;
            this.txtnoimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoimat.Location = new System.Drawing.Point(185, 258);
            this.txtnoimat.Name = "txtnoimat";
            this.txtnoimat.ReadOnly = true;
            this.txtnoimat.Size = new System.Drawing.Size(177, 26);
            this.txtnoimat.TabIndex = 6;
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.White;
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(971, 720);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(106, 34);
            this.btndong.TabIndex = 32;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.BackColor = System.Drawing.Color.White;
            this.grbtimkiem.Controls.Add(this.txttimkiem);
            this.grbtimkiem.Controls.Add(this.label2);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(12, 191);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(328, 85);
            this.grbtimkiem.TabIndex = 33;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(162, 28);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã phiếu tử:";
            // 
            // dgvphieutu
            // 
            this.dgvphieutu.BackgroundColor = System.Drawing.Color.White;
            this.dgvphieutu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvphieutu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieutu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuTu,
            this.HoTen,
            this.NamSinh,
            this.NgayMat,
            this.LydoMat,
            this.NoiMat,
            this.MaSHK});
            this.dgvphieutu.Location = new System.Drawing.Point(12, 478);
            this.dgvphieutu.Name = "dgvphieutu";
            this.dgvphieutu.Size = new System.Drawing.Size(1254, 222);
            this.dgvphieutu.TabIndex = 34;
            this.dgvphieutu.Click += new System.EventHandler(this.dgvphieutu_Click);
            // 
            // MaPhieuTu
            // 
            this.MaPhieuTu.DataPropertyName = "MaPhieuTu";
            this.MaPhieuTu.HeaderText = "Mã phiếu tử";
            this.MaPhieuTu.Name = "MaPhieuTu";
            this.MaPhieuTu.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 200;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            this.NamSinh.Width = 150;
            // 
            // NgayMat
            // 
            this.NgayMat.DataPropertyName = "NgayMat";
            this.NgayMat.HeaderText = "Ngày mất";
            this.NgayMat.Name = "NgayMat";
            this.NgayMat.ReadOnly = true;
            this.NgayMat.Width = 150;
            // 
            // LydoMat
            // 
            this.LydoMat.DataPropertyName = "LydoMat";
            this.LydoMat.HeaderText = "Lý do mất";
            this.LydoMat.Name = "LydoMat";
            this.LydoMat.ReadOnly = true;
            this.LydoMat.Width = 300;
            // 
            // NoiMat
            // 
            this.NoiMat.DataPropertyName = "NoiMat";
            this.NoiMat.HeaderText = "Nơi mất";
            this.NoiMat.Name = "NoiMat";
            this.NoiMat.ReadOnly = true;
            this.NoiMat.Width = 170;
            // 
            // MaSHK
            // 
            this.MaSHK.DataPropertyName = "MaSHK";
            this.MaSHK.HeaderText = "Mã sổ hộ khẩu";
            this.MaSHK.Name = "MaSHK";
            this.MaSHK.ReadOnly = true;
            this.MaSHK.Width = 140;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvtongphieutu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttongphieutu);
            this.panel1.Location = new System.Drawing.Point(12, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 85);
            this.panel1.TabIndex = 35;
            // 
            // dgvtongphieutu
            // 
            this.dgvtongphieutu.BackgroundColor = System.Drawing.Color.White;
            this.dgvtongphieutu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtongphieutu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtongphieutu.Enabled = false;
            this.dgvtongphieutu.Location = new System.Drawing.Point(132, 3);
            this.dgvtongphieutu.Name = "dgvtongphieutu";
            this.dgvtongphieutu.ReadOnly = true;
            this.dgvtongphieutu.Size = new System.Drawing.Size(63, 40);
            this.dgvtongphieutu.TabIndex = 5;
            this.dgvtongphieutu.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng số phiếu tử:";
            // 
            // txttongphieutu
            // 
            this.txttongphieutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txttongphieutu.Enabled = false;
            this.txttongphieutu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongphieutu.Location = new System.Drawing.Point(201, 29);
            this.txttongphieutu.Multiline = true;
            this.txttongphieutu.Name = "txttongphieutu";
            this.txttongphieutu.Size = new System.Drawing.Size(67, 40);
            this.txttongphieutu.TabIndex = 8;
            this.txttongphieutu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(709, 720);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(106, 34);
            this.btnxoa.TabIndex = 36;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvdeletePT
            // 
            this.dgvdeletePT.BackgroundColor = System.Drawing.Color.White;
            this.dgvdeletePT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdeletePT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeletePT.Location = new System.Drawing.Point(834, 720);
            this.dgvdeletePT.Name = "dgvdeletePT";
            this.dgvdeletePT.Size = new System.Drawing.Size(77, 34);
            this.dgvdeletePT.TabIndex = 37;
            // 
            // pnchuky
            // 
            this.pnchuky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnchuky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnchuky.Controls.Add(this.btnthoat);
            this.pnchuky.Controls.Add(this.chkhienan);
            this.pnchuky.Controls.Add(this.btndangnhap);
            this.pnchuky.Controls.Add(this.txtchuky);
            this.pnchuky.Controls.Add(this.label4);
            this.pnchuky.Location = new System.Drawing.Point(370, 240);
            this.pnchuky.Name = "pnchuky";
            this.pnchuky.Size = new System.Drawing.Size(393, 232);
            this.pnchuky.TabIndex = 246;
            // 
            // btnthoat
            // 
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(206, 158);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(106, 36);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // chkhienan
            // 
            this.chkhienan.AutoSize = true;
            this.chkhienan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkhienan.Location = new System.Drawing.Point(88, 117);
            this.chkhienan.Name = "chkhienan";
            this.chkhienan.Size = new System.Drawing.Size(145, 23);
            this.chkhienan.TabIndex = 3;
            this.chkhienan.Text = "Hiện / Ẩn mật khẩu";
            this.chkhienan.UseVisualStyleBackColor = true;
            this.chkhienan.CheckedChanged += new System.EventHandler(this.chkhienan_CheckedChanged);
            // 
            // btndangnhap
            // 
            this.btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(88, 158);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(106, 36);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Xác nhận";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtchuky
            // 
            this.txtchuky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchuky.Location = new System.Drawing.Point(88, 80);
            this.txtchuky.Name = "txtchuky";
            this.txtchuky.Size = new System.Drawing.Size(224, 26);
            this.txtchuky.TabIndex = 1;
            this.txtchuky.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cần có chữ ký của công an xã để xác nhận";
            // 
            // btninreport
            // 
            this.btninreport.BackColor = System.Drawing.Color.White;
            this.btninreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btninreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninreport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninreport.Location = new System.Drawing.Point(459, 720);
            this.btninreport.Name = "btninreport";
            this.btninreport.Size = new System.Drawing.Size(106, 34);
            this.btninreport.TabIndex = 247;
            this.btninreport.Text = "In Report";
            this.btninreport.UseVisualStyleBackColor = false;
            this.btninreport.Click += new System.EventHandler(this.btninreport_Click);
            // 
            // frmdsPhieuTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 775);
            this.Controls.Add(this.btninreport);
            this.Controls.Add(this.pnchuky);
            this.Controls.Add(this.dgvdeletePT);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvphieutu);
            this.Controls.Add(this.grbtimkiem);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.grbthannhan);
            this.Controls.Add(this.label1);
            this.Name = "frmdsPhieuTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách phiếu tử";
            this.Load += new System.EventHandler(this.frmdsPhieuTu_Load);
            this.grbthannhan.ResumeLayout(false);
            this.grbthannhan.PerformLayout();
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieutu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtongphieutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletePT)).EndInit();
            this.pnchuky.ResumeLayout(false);
            this.pnchuky.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbthannhan;
        private System.Windows.Forms.TextBox txtngaymat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmashk;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlydomat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnamsinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmaphieutu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtnoimat;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvphieutu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LydoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSHK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvtongphieutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongphieutu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvdeletePT;
        private System.Windows.Forms.Panel pnchuky;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox chkhienan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtchuky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninreport;
    }
}