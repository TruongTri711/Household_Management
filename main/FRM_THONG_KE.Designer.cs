namespace main
{
    partial class FRM_THONG_KE
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
            this.crpvthongke = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpvthongke
            // 
            this.crpvthongke.ActiveViewIndex = -1;
            this.crpvthongke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpvthongke.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpvthongke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpvthongke.Location = new System.Drawing.Point(0, 0);
            this.crpvthongke.Name = "crpvthongke";
            this.crpvthongke.Size = new System.Drawing.Size(876, 649);
            this.crpvthongke.TabIndex = 0;
            this.crpvthongke.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FRM_THONG_KE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 649);
            this.Controls.Add(this.crpvthongke);
            this.Name = "FRM_THONG_KE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FRM_THONG_KE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvthongke;
    }
}