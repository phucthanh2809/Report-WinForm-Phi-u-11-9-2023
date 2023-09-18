
namespace Report_WinForm_Phiếu_11_9_2023
{
    partial class RpPhieuKhamTienMe
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
            this.cRPPhieuKhamTienMe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cRPPhieuKhamTienMe
            // 
            this.cRPPhieuKhamTienMe.ActiveViewIndex = -1;
            this.cRPPhieuKhamTienMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRPPhieuKhamTienMe.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRPPhieuKhamTienMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRPPhieuKhamTienMe.Location = new System.Drawing.Point(0, 0);
            this.cRPPhieuKhamTienMe.Name = "cRPPhieuKhamTienMe";
            this.cRPPhieuKhamTienMe.Size = new System.Drawing.Size(800, 450);
            this.cRPPhieuKhamTienMe.TabIndex = 0;
            // 
            // RpPhieuKhamTienMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cRPPhieuKhamTienMe);
            this.Name = "RpPhieuKhamTienMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RpPhieuKhamTienMe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRPPhieuKhamTienMe;
    }
}