
namespace Presentacion
{
    partial class frmRptVentas
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
            this.CrystalViewerVentas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystalViewerVentas
            // 
            this.CrystalViewerVentas.ActiveViewIndex = -1;
            this.CrystalViewerVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalViewerVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalViewerVentas.DisplayStatusBar = false;
            this.CrystalViewerVentas.DisplayToolbar = false;
            this.CrystalViewerVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalViewerVentas.Location = new System.Drawing.Point(0, 0);
            this.CrystalViewerVentas.Name = "CrystalViewerVentas";
            this.CrystalViewerVentas.Size = new System.Drawing.Size(1113, 647);
            this.CrystalViewerVentas.TabIndex = 0;
            this.CrystalViewerVentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRptVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 647);
            this.Controls.Add(this.CrystalViewerVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRptVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRptVentas_FormClosed);
            this.Load += new System.EventHandler(this.frmRptVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalViewerVentas;
    }
}