
namespace Report_WinForm_Phiếu_11_9_2023
{
    partial class RpGiayCamDoanChapNhanGayMe
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
            this.crysPhieuChapNhanGayMe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crysPhieuChapNhanGayMe
            // 
            this.crysPhieuChapNhanGayMe.ActiveViewIndex = -1;
            this.crysPhieuChapNhanGayMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysPhieuChapNhanGayMe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysPhieuChapNhanGayMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysPhieuChapNhanGayMe.Location = new System.Drawing.Point(0, 0);
            this.crysPhieuChapNhanGayMe.Name = "crysPhieuChapNhanGayMe";
            this.crysPhieuChapNhanGayMe.Size = new System.Drawing.Size(1350, 729);
            this.crysPhieuChapNhanGayMe.TabIndex = 0;
            // 
            // RpGiayCamDoanChapNhanGayMe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.crysPhieuChapNhanGayMe);
            this.Name = "RpGiayCamDoanChapNhanGayMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RpGiayCamDoanChapNhanGayMe";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crysPhieuChapNhanGayMe;
    }
}