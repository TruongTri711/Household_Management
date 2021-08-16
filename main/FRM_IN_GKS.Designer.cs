namespace main
{
    partial class FRM_IN_GKS
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
            this.cprvGKS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cprvGKS
            // 
            this.cprvGKS.ActiveViewIndex = -1;
            this.cprvGKS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cprvGKS.Cursor = System.Windows.Forms.Cursors.Default;
            this.cprvGKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cprvGKS.Location = new System.Drawing.Point(0, 0);
            this.cprvGKS.Name = "cprvGKS";
            this.cprvGKS.Size = new System.Drawing.Size(877, 646);
            this.cprvGKS.TabIndex = 0;
            this.cprvGKS.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FRM_IN_GKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 646);
            this.Controls.Add(this.cprvGKS);
            this.Name = "FRM_IN_GKS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "In Giấy Khai Sinh";
            this.Load += new System.EventHandler(this.FRM_IN_GKS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cprvGKS;
    }
}