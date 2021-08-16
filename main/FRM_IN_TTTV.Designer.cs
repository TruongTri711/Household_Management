namespace main
{
    partial class FRM_IN_TTTV
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
            this.crptintttv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptintttv
            // 
            this.crptintttv.ActiveViewIndex = -1;
            this.crptintttv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptintttv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptintttv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptintttv.Location = new System.Drawing.Point(0, 0);
            this.crptintttv.Name = "crptintttv";
            this.crptintttv.Size = new System.Drawing.Size(878, 643);
            this.crptintttv.TabIndex = 0;
            this.crptintttv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FRM_IN_TTTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 643);
            this.Controls.Add(this.crptintttv);
            this.Name = "FRM_IN_TTTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_IN_TTTV";
            this.Load += new System.EventHandler(this.FRM_IN_TTTV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crptintttv;
    }
}