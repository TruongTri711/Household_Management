namespace main
{
    partial class frmdsTDCH
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
            this.btndong = new System.Windows.Forms.Button();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgcDSTDCH = new System.Windows.Forms.DataGridView();
            this.MaphieuTDCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LYDOTHAYDOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHAYDOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QHCHUHOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QHCHUHOMOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmashk = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnamsinhvo = new System.Windows.Forms.TextBox();
            this.txthotenvo = new System.Windows.Forms.TextBox();
            this.txtqhchuhocu = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtngaythaydoi = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtlydothaydoi = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.txtqhchuhomoi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTongTDCH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txttongGKS = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvdeleteTDCH = new System.Windows.Forms.DataGridView();
            this.pnchuky = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chkhienan = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtchuky = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDSTDCH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongTDCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleteTDCH)).BeginInit();
            this.pnchuky.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH PHIẾU THAY ĐỔI CHỦ HỘ";
            // 
            // btndong
            // 
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(958, 751);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(84, 38);
            this.btndong.TabIndex = 132;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.BackColor = System.Drawing.Color.White;
            this.grbtimkiem.Controls.Add(this.txttimkiem);
            this.grbtimkiem.Controls.Add(this.label3);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(24, 200);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(374, 85);
            this.grbtimkiem.TabIndex = 131;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(219, 28);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập mã giấy thay đổi chủ hộ:";
            // 
            // dgcDSTDCH
            // 
            this.dgcDSTDCH.BackgroundColor = System.Drawing.Color.White;
            this.dgcDSTDCH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgcDSTDCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcDSTDCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaphieuTDCH,
            this.HoTen,
            this.NamSinh,
            this.LYDOTHAYDOI,
            this.NGAYTHAYDOI,
            this.QHCHUHOCU,
            this.QHCHUHOMOI,
            this.MaSHK});
            this.dgcDSTDCH.Location = new System.Drawing.Point(24, 514);
            this.dgcDSTDCH.Name = "dgcDSTDCH";
            this.dgcDSTDCH.Size = new System.Drawing.Size(1138, 222);
            this.dgcDSTDCH.TabIndex = 130;
            this.dgcDSTDCH.Click += new System.EventHandler(this.dgcDSTDCH_Click);
            // 
            // MaphieuTDCH
            // 
            this.MaphieuTDCH.DataPropertyName = "MaphieuTDCH";
            this.MaphieuTDCH.HeaderText = "Mã phiếu";
            this.MaphieuTDCH.Name = "MaphieuTDCH";
            this.MaphieuTDCH.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên vợ";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh vợ";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            // 
            // LYDOTHAYDOI
            // 
            this.LYDOTHAYDOI.DataPropertyName = "LYDOTHAYDOI";
            this.LYDOTHAYDOI.HeaderText = "Lý do thay đổi";
            this.LYDOTHAYDOI.Name = "LYDOTHAYDOI";
            this.LYDOTHAYDOI.ReadOnly = true;
            this.LYDOTHAYDOI.Width = 200;
            // 
            // NGAYTHAYDOI
            // 
            this.NGAYTHAYDOI.DataPropertyName = "NGAYTHAYDOI";
            this.NGAYTHAYDOI.HeaderText = "Ngày thay đổi";
            this.NGAYTHAYDOI.Name = "NGAYTHAYDOI";
            this.NGAYTHAYDOI.ReadOnly = true;
            this.NGAYTHAYDOI.Width = 120;
            // 
            // QHCHUHOCU
            // 
            this.QHCHUHOCU.DataPropertyName = "QHCHUHOCU";
            this.QHCHUHOCU.HeaderText = "Quan hệ chủ hộ cũ";
            this.QHCHUHOCU.Name = "QHCHUHOCU";
            this.QHCHUHOCU.ReadOnly = true;
            this.QHCHUHOCU.Width = 130;
            // 
            // QHCHUHOMOI
            // 
            this.QHCHUHOMOI.DataPropertyName = "QHCHUHOMOI";
            this.QHCHUHOMOI.HeaderText = "Quan hệ chủ hộ mới";
            this.QHCHUHOMOI.Name = "QHCHUHOMOI";
            this.QHCHUHOMOI.ReadOnly = true;
            this.QHCHUHOMOI.Width = 130;
            // 
            // MaSHK
            // 
            this.MaSHK.DataPropertyName = "MaSHK";
            this.MaSHK.HeaderText = "Mã sổ hộ khẩu";
            this.MaSHK.Name = "MaSHK";
            this.MaSHK.ReadOnly = true;
            this.MaSHK.Width = 145;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmashk);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtnamsinhvo);
            this.groupBox1.Controls.Add(this.txthotenvo);
            this.groupBox1.Controls.Add(this.txtqhchuhocu);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtngaythaydoi);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtlydothaydoi);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtmaphieu);
            this.groupBox1.Controls.Add(this.txtqhchuhomoi);
            this.groupBox1.Location = new System.Drawing.Point(509, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 372);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 249;
            this.label5.Text = "Mã sổ hộ khẩu:";
            // 
            // txtmashk
            // 
            this.txtmashk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmashk.BackColor = System.Drawing.Color.White;
            this.txtmashk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmashk.Location = new System.Drawing.Point(191, 327);
            this.txtmashk.Name = "txtmashk";
            this.txtmashk.ReadOnly = true;
            this.txtmashk.Size = new System.Drawing.Size(177, 26);
            this.txtmashk.TabIndex = 248;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(83, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 20);
            this.label25.TabIndex = 246;
            this.label25.Text = "Năm sinh vợ:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(101, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 247;
            this.label17.Text = "Họ tên vợ:";
            // 
            // txtnamsinhvo
            // 
            this.txtnamsinhvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnamsinhvo.BackColor = System.Drawing.Color.White;
            this.txtnamsinhvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamsinhvo.Location = new System.Drawing.Point(191, 107);
            this.txtnamsinhvo.Name = "txtnamsinhvo";
            this.txtnamsinhvo.ReadOnly = true;
            this.txtnamsinhvo.Size = new System.Drawing.Size(177, 26);
            this.txtnamsinhvo.TabIndex = 245;
            // 
            // txthotenvo
            // 
            this.txthotenvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthotenvo.BackColor = System.Drawing.Color.White;
            this.txthotenvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthotenvo.Location = new System.Drawing.Point(191, 63);
            this.txthotenvo.Name = "txthotenvo";
            this.txthotenvo.ReadOnly = true;
            this.txthotenvo.Size = new System.Drawing.Size(177, 26);
            this.txthotenvo.TabIndex = 244;
            // 
            // txtqhchuhocu
            // 
            this.txtqhchuhocu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtqhchuhocu.BackColor = System.Drawing.Color.White;
            this.txtqhchuhocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqhchuhocu.Location = new System.Drawing.Point(191, 240);
            this.txtqhchuhocu.Name = "txtqhchuhocu";
            this.txtqhchuhocu.ReadOnly = true;
            this.txtqhchuhocu.Size = new System.Drawing.Size(177, 26);
            this.txtqhchuhocu.TabIndex = 243;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(104, 25);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 20);
            this.label33.TabIndex = 206;
            this.label33.Text = "Mã phiếu:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(35, 246);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(147, 20);
            this.label24.TabIndex = 221;
            this.label24.Text = "Quan hệ chủ hộ cũ:";
            // 
            // txtngaythaydoi
            // 
            this.txtngaythaydoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtngaythaydoi.BackColor = System.Drawing.Color.White;
            this.txtngaythaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaythaydoi.Location = new System.Drawing.Point(191, 196);
            this.txtngaythaydoi.Name = "txtngaythaydoi";
            this.txtngaythaydoi.ReadOnly = true;
            this.txtngaythaydoi.Size = new System.Drawing.Size(177, 26);
            this.txtngaythaydoi.TabIndex = 242;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(27, 290);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 20);
            this.label23.TabIndex = 220;
            this.label23.Text = "Quan hệ chủ hộ mới:";
            // 
            // txtlydothaydoi
            // 
            this.txtlydothaydoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlydothaydoi.BackColor = System.Drawing.Color.White;
            this.txtlydothaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlydothaydoi.Location = new System.Drawing.Point(191, 151);
            this.txtlydothaydoi.Name = "txtlydothaydoi";
            this.txtlydothaydoi.ReadOnly = true;
            this.txtlydothaydoi.Size = new System.Drawing.Size(430, 26);
            this.txtlydothaydoi.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(74, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 20);
            this.label22.TabIndex = 219;
            this.label22.Text = "Ngày thay đổi:";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(72, 157);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(110, 20);
            this.label28.TabIndex = 222;
            this.label28.Text = "Lý do thay đổi:";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmaphieu.BackColor = System.Drawing.Color.White;
            this.txtmaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphieu.Location = new System.Drawing.Point(191, 19);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.ReadOnly = true;
            this.txtmaphieu.Size = new System.Drawing.Size(177, 26);
            this.txtmaphieu.TabIndex = 3;
            // 
            // txtqhchuhomoi
            // 
            this.txtqhchuhomoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtqhchuhomoi.BackColor = System.Drawing.Color.White;
            this.txtqhchuhomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqhchuhomoi.Location = new System.Drawing.Point(191, 284);
            this.txtqhchuhomoi.Name = "txtqhchuhomoi";
            this.txtqhchuhomoi.ReadOnly = true;
            this.txtqhchuhomoi.Size = new System.Drawing.Size(177, 26);
            this.txtqhchuhomoi.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvTongTDCH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttongGKS);
            this.panel1.Location = new System.Drawing.Point(24, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 85);
            this.panel1.TabIndex = 128;
            // 
            // dgvTongTDCH
            // 
            this.dgvTongTDCH.BackgroundColor = System.Drawing.Color.White;
            this.dgvTongTDCH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTongTDCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongTDCH.Enabled = false;
            this.dgvTongTDCH.Location = new System.Drawing.Point(164, 3);
            this.dgvTongTDCH.Name = "dgvTongTDCH";
            this.dgvTongTDCH.ReadOnly = true;
            this.dgvTongTDCH.Size = new System.Drawing.Size(63, 40);
            this.dgvTongTDCH.TabIndex = 5;
            this.dgvTongTDCH.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng số giấy thay đổi chủ hộ:";
            // 
            // txttongGKS
            // 
            this.txttongGKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txttongGKS.Enabled = false;
            this.txttongGKS.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongGKS.Location = new System.Drawing.Point(290, 29);
            this.txttongGKS.Multiline = true;
            this.txttongGKS.Name = "txttongGKS";
            this.txttongGKS.Size = new System.Drawing.Size(67, 40);
            this.txttongGKS.TabIndex = 8;
            this.txttongGKS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnxoa
            // 
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(630, 751);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(84, 38);
            this.btnxoa.TabIndex = 133;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvdeleteTDCH
            // 
            this.dgvdeleteTDCH.BackgroundColor = System.Drawing.Color.White;
            this.dgvdeleteTDCH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdeleteTDCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeleteTDCH.Location = new System.Drawing.Point(811, 751);
            this.dgvdeleteTDCH.Name = "dgvdeleteTDCH";
            this.dgvdeleteTDCH.Size = new System.Drawing.Size(75, 38);
            this.dgvdeleteTDCH.TabIndex = 134;
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
            this.pnchuky.Location = new System.Drawing.Point(372, 191);
            this.pnchuky.Name = "pnchuky";
            this.pnchuky.Size = new System.Drawing.Size(393, 232);
            this.pnchuky.TabIndex = 245;
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
            // frmdsTDCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 807);
            this.Controls.Add(this.pnchuky);
            this.Controls.Add(this.dgvdeleteTDCH);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dgcDSTDCH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbtimkiem);
            this.Name = "frmdsTDCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách thay đổi chủ hộ";
            this.Load += new System.EventHandler(this.frmdsthaydoichuho_Load);
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDSTDCH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongTDCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeleteTDCH)).EndInit();
            this.pnchuky.ResumeLayout(false);
            this.pnchuky.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgcDSTDCH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtqhchuhocu;
        private System.Windows.Forms.TextBox txtngaythaydoi;
        private System.Windows.Forms.TextBox txtlydothaydoi;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.TextBox txtqhchuhomoi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTongTDCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttongGKS;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvdeleteTDCH;
        private System.Windows.Forms.Panel pnchuky;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox chkhienan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtchuky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmashk;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtnamsinhvo;
        private System.Windows.Forms.TextBox txthotenvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaphieuTDCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LYDOTHAYDOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHAYDOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn QHCHUHOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn QHCHUHOMOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSHK;
    }
}