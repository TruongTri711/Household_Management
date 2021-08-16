namespace main
{
    partial class FRM_IN_SHK
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
            this.crpvinshk = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpvinshk
            // 
            this.crpvinshk.ActiveViewIndex = -1;
            this.crpvinshk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpvinshk.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpvinshk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpvinshk.Location = new System.Drawing.Point(0, 0);
            this.crpvinshk.Name = "crpvinshk";
            this.crpvinshk.Size = new System.Drawing.Size(874, 652);
            this.crpvinshk.TabIndex = 0;
            this.crpvinshk.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FRM_IN_SHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 652);
            this.Controls.Add(this.crpvinshk);
            this.Name = "FRM_IN_SHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In Sổ Hộ Khẩu";
            this.Load += new System.EventHandler(this.FRM_IN_SHK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpvinshk;
    }
}