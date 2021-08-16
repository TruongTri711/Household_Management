namespace main
{
    partial class FRM_IN_PHIEU_TU
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
            this.crpvinphieutu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpvinphieutu
            // 
            this.crpvinphieutu.ActiveViewIndex = -1;
            this.crpvinphieutu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpvinphieutu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpvinphieutu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpvinphieutu.Location = new System.Drawing.Point(0, 0);
            this.crpvinphieutu.Name = "crpvinphieutu";
            this.crpvinphieutu.Size = new System.Drawing.Size(877, 648);
            this.crpvinphieutu.TabIndex = 0;
            this.crpvinphieutu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FRM_IN_PHIEU_TU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 648);
            this.Controls.Add(this.crpvinphieutu);
            this.Name = "FRM_IN_PHIEU_TU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In phiếu tử";
            this.Load += new System.EventHandler(this.FRM_IN_PHIEU_TU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvinphieutu;
    }
}