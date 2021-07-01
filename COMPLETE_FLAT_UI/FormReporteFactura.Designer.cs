
namespace COMPLETE_FLAT_UI
{
     partial class FormReporteFactura
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
               this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
               this.rptFactura1 = new COMPLETE_FLAT_UI.Reportes.rptFactura();
               this.rptFactura2 = new COMPLETE_FLAT_UI.Reportes.rptFactura();
               this.SuspendLayout();
               // 
               // crystalReportViewer1
               // 
               this.crystalReportViewer1.ActiveViewIndex = 0;
               this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
               this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
               this.crystalReportViewer1.Name = "crystalReportViewer1";
               this.crystalReportViewer1.ReportSource = this.rptFactura2;
               this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
               this.crystalReportViewer1.TabIndex = 0;
               this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
               this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
               // 
               // FormReporteFactura
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.crystalReportViewer1);
               this.Name = "FormReporteFactura";
               this.Text = "FormReporteFactura";
               this.Load += new System.EventHandler(this.FormReporteFactura_Load);
               this.ResumeLayout(false);

          }

          #endregion
          private Reportes.rptFactura rptFactura1;
          private Reportes.rptFactura rptFactura2;
          public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
     }
}